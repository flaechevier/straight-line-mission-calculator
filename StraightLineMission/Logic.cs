/// author: Stefan Tölle
/// Date: 21.12.2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gps;
using Gpx;
using System.Windows.Forms.DataVisualization.Charting;

namespace StraightLineMission
{
    /// <summary>
    /// Contains all backend logic of the Program.
    /// </summary>
    public struct CalculationResult
    {
        public IList<double> deviations;
        public double awgDeviation;
        public double awgSquareDeviation;
        public double area;
        public double areaNorm;
        public double over10, over25, over50, over80, over120;
        public int numOver10, numOver25, numOver50, numOver80, numOver120;
        public Series histogramData;
        public double maxDeviation;
    }

    public class Logic
    {
        // user given start and end position of the line
        public GpsLocation startingPoint { get; set; }
        public GpsLocation endPoint { get; set; }

        // gpx file
        public GpxPointCollection<GpxPoint> gpxData { get; set; }

        private double lineLength;

        public CalculationResult calculate()
        {
            CalculationResult result;
            lineLength = 1000*GpxParser.gpsToGpx(startingPoint).GetDistanceFrom(GpxParser.gpsToGpx(endPoint)); // length of the line

            // calculate deviations
            List<double> deviations = new List<double>();
            List<double> distancesAlongLine = new List<double>();
            foreach (GpxPoint point in gpxData)
            {
                deviations.Add(getDeviation(point));
                distancesAlongLine.Add(getDistanceAlongLine(point));
            }

            // calculate metrics
            result.deviations = deviations;
            result.awgDeviation = getAwgDeviation(deviations);
            result.awgSquareDeviation = getAwgSquareDeviation(deviations);
            result.area = getArea(deviations, distancesAlongLine);
            result.areaNorm = result.area / lineLength;
            result.over10 = percentageOverThreshold(deviations, 10);
            result.over25 = percentageOverThreshold(deviations, 25);
            result.over50 = percentageOverThreshold(deviations, 50);
            result.over80 = percentageOverThreshold(deviations, 80);
            result.over120 = percentageOverThreshold(deviations, 120);
            result.numOver10 = numberOverThreshold(deviations, 10);
            result.numOver25 = numberOverThreshold(deviations, 25);
            result.numOver50 = numberOverThreshold(deviations, 50);
            result.numOver80 = numberOverThreshold(deviations, 80);
            result.numOver120 = numberOverThreshold(deviations, 120);
            result.maxDeviation = getMaximumDeviation(deviations);

            // create histogram data
            result.histogramData = getHistogramData(deviations);

            return result;
        }

        // calculates cos(phi) where phi is the angle between the line and a line from the start point to the current point
        private double getCosPhi(GpxPoint point)
        {
            // distances to start/end point
            double distanceA = 1000 * GpxParser.gpsToGpx(startingPoint).GetDistanceFrom(point);
            double distanceB = 1000 * GpxParser.gpsToGpx(endPoint).GetDistanceFrom(point);

            // using cosine theorem; phi is the angle between the line and a line from the start point to the current point
            double cos_phi = (lineLength * lineLength + distanceA * distanceA - distanceB * distanceB) / (2 * lineLength * distanceA);
            if (cos_phi > 1) // prevents errors due to rounding
                return 1;
            else if (cos_phi < -1)
                return -1;
            else
                return cos_phi;
        }

        // calculates the deviation of a point to the line
        private double getDeviation(GpxPoint point)
        {
            double distanceA = 1000 * GpxParser.gpsToGpx(startingPoint).GetDistanceFrom(point); // distances to start point
            double cos_phi = getCosPhi(point);
            double sin_phi = System.Math.Sqrt(1 - cos_phi * cos_phi);
            // deviation is the heigth of the triangle
            double deviation = sin_phi * distanceA;

            // if point is left of the line, deviation is negativ
            double deltaLong = endPoint.Longitude - startingPoint.Longitude;
            double deltaLat = endPoint.Latitude - startingPoint.Latitude;
            double slope = deltaLat / deltaLong;
            if (slope*(point.Longitude-startingPoint.Longitude) < point.Latitude-startingPoint.Latitude)
            {
                deviation *= -1;
            }
            if (startingPoint.Longitude > endPoint.Longitude) // the direction you walk the line changes left/right
            {
                deviation *= -1;
            }
            return deviation;
        }

        // calculates the distance from start to the point projected onto the line
        private double getDistanceAlongLine(GpxPoint point)
        {
            double distanceA = 1000 * GpxParser.gpsToGpx(startingPoint).GetDistanceFrom(point); // distances to start point
            double cos_phi = getCosPhi(point);

            return cos_phi * distanceA;
        }

        // calculates the avarage deviation
        private double getAwgDeviation(IList<double> deviations)
        {
            double sum = 0;
            foreach(double d in deviations)
            {
                sum += System.Math.Abs(d);
            }
            return sum / deviations.Count;
        }

        // calculates the avarage squared deviation
        private double getAwgSquareDeviation(IList<double> deviations)
        {
            double sum = 0;
            foreach (double d in deviations)
            {
                sum += d*d;
            }
            return sum / deviations.Count;
        }

        // calculates the area between the track and the line
        private double getArea(IList<double> deviations, IList<double> distancesAlongLine)
        {
            double area = 0;
            for (int i = 1; i < deviations.Count; i++)
            {
                double a = deviations[i - 1];
                double b = deviations[i];
                double ds = System.Math.Abs(distancesAlongLine[i] - distancesAlongLine[i-1]); // non negative increment
                double partialArea;
                if (a*b < 0) // sign of deviations is different
                {
                    partialArea = 0.5 * ds * (a * a + b * b) / (System.Math.Abs(a) + System.Math.Abs(b)); // special case for different signs
                }
                else
                {
                    partialArea = System.Math.Abs(0.5 * (deviations[i] + deviations[i - 1]) * ds); // area of the trapez
                }
                area += partialArea;
            }
            return area;
        }

        // calculates the percentage of time spend outside of a certain threshhold
        private double percentageOverThreshold(IList<double> deviations, double threshold)
        {
            int count = 0;
            foreach(double deviation in deviations)
            {
                if (deviation > threshold || deviation < -threshold)
                    count++;
            }
            return ((double)count) / deviations.Count;
        }

        // calculates the individual occurances the deviation is over a certain threshold
        private int numberOverThreshold(IList<double> deviations, double threshold)
        {
            int count = 0;
            bool active = false;
            foreach (double deviation in deviations)
            {
                if (!active && (deviation > threshold || deviation < -threshold))
                {
                    count++;
                    active = true;
                }
                else if (active && (deviation < threshold && deviation > -threshold))
                {
                    active = false;
                }
            }
            return count;
        }

        // calculates data for the histogram
        private Series getHistogramData(IList<double> deviations)
        {
            Series series = new Series();
            int[] occurences = new int[2001]; // counting occurences from -1000...1000m
            foreach(double dev in deviations)
            {
                int d = Convert.ToInt32(dev);
                if (d >= -1000 && d <= 1000)
                    occurences[d+1000]++;
            }
            for (int i = -1000; i <= 1000; i++)
            {
                series.Points.AddXY(i, 100*((double)occurences[i+1000])/deviations.Count); // add the data in percent
            }
            return series;
        }

        // calculates maximum deviation
        private double getMaximumDeviation(IList<double> deviations)
        {
            double max = 0;
            foreach(double d in deviations)
            {
                if (System.Math.Abs(d) > max)
                    max = System.Math.Abs(d);
            }
            return max;
        }
    }
}
