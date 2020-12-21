using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gpx;
using Gps;
using System.IO;

namespace StraightLineMission
{
    public static class GpxParser
    {
        /// <summary>
        /// Parses a stream of a gpx file and returns a list of all gpx points in the track(s).
        /// </summary>
        /// <param name="stream">stream of a gpx file</param>
        /// <returns>list of all gpx points in the track(s)</returns>
        public static GpxPointCollection<GpxPoint> parseGpx(Stream stream)
        {
            GpxPointCollection<GpxPoint> pointList = new GpxPointCollection<GpxPoint>();
            using (GpxReader gpxReader = new GpxReader(stream))
            {
                while(gpxReader.Read())
                {
                    // track found
                    if (gpxReader.ObjectType == GpxObjectType.Track)
                    {
                        // add points of the track
                        GpxPointCollection<GpxPoint> pointsToAdd = gpxReader.Track.ToGpxPoints();
                        foreach (GpxPoint point in pointsToAdd)
                        {
                            pointList.AddPoint(point);
                        }
                    }
                }
            }
            return pointList;
        }

        /// <summary>
        /// Creates a GpxPoint with the same Longitude and Latitude as a GpsLocation.
        /// </summary>
        /// <param name="gpsLocation">the GpsLocation</param>
        /// <returns>the corrresponding GpxPoint</returns>
        public static GpxPoint gpsToGpx(GpsLocation gpsLocation)
        {
            GpxPoint point = new GpxPoint();
            point.Longitude = gpsLocation.Longitude;
            point.Latitude = gpsLocation.Latitude;
            return point;
        }
    }
}
