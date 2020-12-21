namespace StraightLineMission
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.maskedTextBoxStartCoord1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxStartCoord2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxEndCoord2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxEndCoord1 = new System.Windows.Forms.MaskedTextBox();
            this.labelNS = new System.Windows.Forms.Label();
            this.labelEW = new System.Windows.Forms.Label();
            this.labelStartCoord = new System.Windows.Forms.Label();
            this.labelEndCoords = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelFile = new System.Windows.Forms.Label();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.toolTipCoords = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDirectory = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipGpxRead = new System.Windows.Forms.ToolTip(this.components);
            this.labelArea = new System.Windows.Forms.Label();
            this.labelMSE = new System.Windows.Forms.Label();
            this.labelOver10 = new System.Windows.Forms.Label();
            this.labelOver25 = new System.Windows.Forms.Label();
            this.labelOver50 = new System.Windows.Forms.Label();
            this.labelOver80 = new System.Windows.Forms.Label();
            this.labelOver120 = new System.Windows.Forms.Label();
            this.labelAreaResult = new System.Windows.Forms.Label();
            this.labelMSEResult = new System.Windows.Forms.Label();
            this.labelOver10Result = new System.Windows.Forms.Label();
            this.labelOver25Result = new System.Windows.Forms.Label();
            this.labelOver50Result = new System.Windows.Forms.Label();
            this.labelOver80Result = new System.Windows.Forms.Label();
            this.labelOver120Result = new System.Windows.Forms.Label();
            this.labelAreaNormResult = new System.Windows.Forms.Label();
            this.labelAreaNorm = new System.Windows.Forms.Label();
            this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelMaxDeviation = new System.Windows.Forms.Label();
            this.labelMaxDeviationResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBoxStartCoord1
            // 
            this.maskedTextBoxStartCoord1.Location = new System.Drawing.Point(484, 105);
            this.maskedTextBoxStartCoord1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBoxStartCoord1.Name = "maskedTextBoxStartCoord1";
            this.maskedTextBoxStartCoord1.Size = new System.Drawing.Size(148, 26);
            this.maskedTextBoxStartCoord1.TabIndex = 0;
            // 
            // maskedTextBoxStartCoord2
            // 
            this.maskedTextBoxStartCoord2.Location = new System.Drawing.Point(684, 105);
            this.maskedTextBoxStartCoord2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBoxStartCoord2.Name = "maskedTextBoxStartCoord2";
            this.maskedTextBoxStartCoord2.Size = new System.Drawing.Size(148, 26);
            this.maskedTextBoxStartCoord2.TabIndex = 1;
            // 
            // maskedTextBoxEndCoord2
            // 
            this.maskedTextBoxEndCoord2.Location = new System.Drawing.Point(684, 180);
            this.maskedTextBoxEndCoord2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBoxEndCoord2.Name = "maskedTextBoxEndCoord2";
            this.maskedTextBoxEndCoord2.Size = new System.Drawing.Size(148, 26);
            this.maskedTextBoxEndCoord2.TabIndex = 3;
            // 
            // maskedTextBoxEndCoord1
            // 
            this.maskedTextBoxEndCoord1.Location = new System.Drawing.Point(484, 180);
            this.maskedTextBoxEndCoord1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBoxEndCoord1.Name = "maskedTextBoxEndCoord1";
            this.maskedTextBoxEndCoord1.Size = new System.Drawing.Size(148, 26);
            this.maskedTextBoxEndCoord1.TabIndex = 2;
            // 
            // labelNS
            // 
            this.labelNS.AutoSize = true;
            this.labelNS.Location = new System.Drawing.Point(480, 80);
            this.labelNS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNS.Name = "labelNS";
            this.labelNS.Size = new System.Drawing.Size(35, 20);
            this.labelNS.TabIndex = 4;
            this.labelNS.Text = "N/S";
            // 
            // labelEW
            // 
            this.labelEW.AutoSize = true;
            this.labelEW.Location = new System.Drawing.Point(680, 80);
            this.labelEW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEW.Name = "labelEW";
            this.labelEW.Size = new System.Drawing.Size(39, 20);
            this.labelEW.TabIndex = 5;
            this.labelEW.Text = "E/W";
            // 
            // labelStartCoord
            // 
            this.labelStartCoord.AutoSize = true;
            this.labelStartCoord.Location = new System.Drawing.Point(182, 115);
            this.labelStartCoord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartCoord.Name = "labelStartCoord";
            this.labelStartCoord.Size = new System.Drawing.Size(229, 20);
            this.labelStartCoord.TabIndex = 6;
            this.labelStartCoord.Text = "Starting coordinates of the line:";
            // 
            // labelEndCoords
            // 
            this.labelEndCoords.AutoSize = true;
            this.labelEndCoords.Location = new System.Drawing.Point(182, 191);
            this.labelEndCoords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndCoords.Name = "labelEndCoords";
            this.labelEndCoords.Size = new System.Drawing.Size(202, 20);
            this.labelEndCoords.TabIndex = 7;
            this.labelEndCoords.Text = "End coordinates of the line:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "GPX files (.gpx)|*.gpx";
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(182, 252);
            this.labelFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(115, 20);
            this.labelFile.TabIndex = 8;
            this.labelFile.Text = "Select .gpx file:";
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Location = new System.Drawing.Point(484, 248);
            this.textBoxDirectory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(346, 26);
            this.textBoxDirectory.TabIndex = 9;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(856, 246);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(92, 31);
            this.buttonBrowse.TabIndex = 10;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCalculate.Location = new System.Drawing.Point(291, 327);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(179, 86);
            this.buttonCalculate.TabIndex = 11;
            this.buttonCalculate.Text = "calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // toolTipCoords
            // 
            this.toolTipCoords.ToolTipTitle = "Invalid Coordinates";
            // 
            // toolTipDirectory
            // 
            this.toolTipDirectory.ToolTipTitle = "Invalid Directory";
            // 
            // toolTipGpxRead
            // 
            this.toolTipGpxRead.ToolTipTitle = "Invalid .gpx File";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(80, 452);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(323, 20);
            this.labelArea.TabIndex = 12;
            this.labelArea.Text = "Area between the route and the straight line:";
            // 
            // labelMSE
            // 
            this.labelMSE.AutoSize = true;
            this.labelMSE.Location = new System.Drawing.Point(202, 512);
            this.labelMSE.Name = "labelMSE";
            this.labelMSE.Size = new System.Drawing.Size(201, 20);
            this.labelMSE.TabIndex = 13;
            this.labelMSE.Text = "Mean squared error (MSE):";
            // 
            // labelOver10
            // 
            this.labelOver10.AutoSize = true;
            this.labelOver10.Location = new System.Drawing.Point(181, 572);
            this.labelOver10.Name = "labelOver10";
            this.labelOver10.Size = new System.Drawing.Size(222, 20);
            this.labelOver10.TabIndex = 14;
            this.labelOver10.Text = "% of time spend outside 10 m:";
            // 
            // labelOver25
            // 
            this.labelOver25.AutoSize = true;
            this.labelOver25.Location = new System.Drawing.Point(339, 602);
            this.labelOver25.Name = "labelOver25";
            this.labelOver25.Size = new System.Drawing.Size(64, 20);
            this.labelOver25.TabIndex = 15;
            this.labelOver25.Text = "... 25 m:";
            // 
            // labelOver50
            // 
            this.labelOver50.AutoSize = true;
            this.labelOver50.Location = new System.Drawing.Point(339, 632);
            this.labelOver50.Name = "labelOver50";
            this.labelOver50.Size = new System.Drawing.Size(64, 20);
            this.labelOver50.TabIndex = 16;
            this.labelOver50.Text = "... 50 m:";
            // 
            // labelOver80
            // 
            this.labelOver80.AutoSize = true;
            this.labelOver80.Location = new System.Drawing.Point(339, 662);
            this.labelOver80.Name = "labelOver80";
            this.labelOver80.Size = new System.Drawing.Size(64, 20);
            this.labelOver80.TabIndex = 17;
            this.labelOver80.Text = "... 80 m:";
            // 
            // labelOver120
            // 
            this.labelOver120.AutoSize = true;
            this.labelOver120.Location = new System.Drawing.Point(330, 692);
            this.labelOver120.Name = "labelOver120";
            this.labelOver120.Size = new System.Drawing.Size(73, 20);
            this.labelOver120.TabIndex = 18;
            this.labelOver120.Text = "... 120 m:";
            // 
            // labelAreaResult
            // 
            this.labelAreaResult.AutoSize = true;
            this.labelAreaResult.Location = new System.Drawing.Point(439, 452);
            this.labelAreaResult.Name = "labelAreaResult";
            this.labelAreaResult.Size = new System.Drawing.Size(36, 20);
            this.labelAreaResult.TabIndex = 19;
            this.labelAreaResult.Text = "- m²";
            // 
            // labelMSEResult
            // 
            this.labelMSEResult.AutoSize = true;
            this.labelMSEResult.Location = new System.Drawing.Point(439, 512);
            this.labelMSEResult.Name = "labelMSEResult";
            this.labelMSEResult.Size = new System.Drawing.Size(36, 20);
            this.labelMSEResult.TabIndex = 20;
            this.labelMSEResult.Text = "- m²";
            // 
            // labelOver10Result
            // 
            this.labelOver10Result.AutoSize = true;
            this.labelOver10Result.Location = new System.Drawing.Point(443, 572);
            this.labelOver10Result.Name = "labelOver10Result";
            this.labelOver10Result.Size = new System.Drawing.Size(32, 20);
            this.labelOver10Result.TabIndex = 21;
            this.labelOver10Result.Text = "- %";
            // 
            // labelOver25Result
            // 
            this.labelOver25Result.AutoSize = true;
            this.labelOver25Result.Location = new System.Drawing.Point(443, 602);
            this.labelOver25Result.Name = "labelOver25Result";
            this.labelOver25Result.Size = new System.Drawing.Size(32, 20);
            this.labelOver25Result.TabIndex = 22;
            this.labelOver25Result.Text = "- %";
            // 
            // labelOver50Result
            // 
            this.labelOver50Result.AutoSize = true;
            this.labelOver50Result.Location = new System.Drawing.Point(443, 632);
            this.labelOver50Result.Name = "labelOver50Result";
            this.labelOver50Result.Size = new System.Drawing.Size(32, 20);
            this.labelOver50Result.TabIndex = 23;
            this.labelOver50Result.Text = "- %";
            // 
            // labelOver80Result
            // 
            this.labelOver80Result.AutoSize = true;
            this.labelOver80Result.Location = new System.Drawing.Point(443, 662);
            this.labelOver80Result.Name = "labelOver80Result";
            this.labelOver80Result.Size = new System.Drawing.Size(32, 20);
            this.labelOver80Result.TabIndex = 24;
            this.labelOver80Result.Text = "- %";
            // 
            // labelOver120Result
            // 
            this.labelOver120Result.AutoSize = true;
            this.labelOver120Result.Location = new System.Drawing.Point(443, 692);
            this.labelOver120Result.Name = "labelOver120Result";
            this.labelOver120Result.Size = new System.Drawing.Size(32, 20);
            this.labelOver120Result.TabIndex = 25;
            this.labelOver120Result.Text = "- %";
            // 
            // labelAreaNormResult
            // 
            this.labelAreaNormResult.AutoSize = true;
            this.labelAreaNormResult.Location = new System.Drawing.Point(439, 482);
            this.labelAreaNormResult.Name = "labelAreaNormResult";
            this.labelAreaNormResult.Size = new System.Drawing.Size(31, 20);
            this.labelAreaNormResult.TabIndex = 27;
            this.labelAreaNormResult.Text = "- m";
            // 
            // labelAreaNorm
            // 
            this.labelAreaNorm.AutoSize = true;
            this.labelAreaNorm.Location = new System.Drawing.Point(283, 482);
            this.labelAreaNorm.Name = "labelAreaNorm";
            this.labelAreaNorm.Size = new System.Drawing.Size(120, 20);
            this.labelAreaNorm.TabIndex = 26;
            this.labelAreaNorm.Text = "Mean deviation:";
            // 
            // chartHistogram
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHistogram.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartHistogram.Legends.Add(legend1);
            this.chartHistogram.Location = new System.Drawing.Point(755, 356);
            this.chartHistogram.Name = "chartHistogram";
            this.chartHistogram.Size = new System.Drawing.Size(541, 326);
            this.chartHistogram.TabIndex = 28;
            this.chartHistogram.Text = "chart1";
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonPlus.Location = new System.Drawing.Point(1323, 372);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(30, 30);
            this.buttonPlus.TabIndex = 29;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(1323, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 30;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMaxDeviation
            // 
            this.labelMaxDeviation.AutoSize = true;
            this.labelMaxDeviation.Location = new System.Drawing.Point(256, 542);
            this.labelMaxDeviation.Name = "labelMaxDeviation";
            this.labelMaxDeviation.Size = new System.Drawing.Size(147, 20);
            this.labelMaxDeviation.TabIndex = 31;
            this.labelMaxDeviation.Text = "Maximum deviation:";
            // 
            // labelMaxDeviationResult
            // 
            this.labelMaxDeviationResult.AutoSize = true;
            this.labelMaxDeviationResult.Location = new System.Drawing.Point(444, 542);
            this.labelMaxDeviationResult.Name = "labelMaxDeviationResult";
            this.labelMaxDeviationResult.Size = new System.Drawing.Size(31, 20);
            this.labelMaxDeviationResult.TabIndex = 32;
            this.labelMaxDeviationResult.Text = "- m";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 736);
            this.Controls.Add(this.labelMaxDeviationResult);
            this.Controls.Add(this.labelMaxDeviation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.chartHistogram);
            this.Controls.Add(this.labelAreaNormResult);
            this.Controls.Add(this.labelAreaNorm);
            this.Controls.Add(this.labelOver120Result);
            this.Controls.Add(this.labelOver80Result);
            this.Controls.Add(this.labelOver50Result);
            this.Controls.Add(this.labelOver25Result);
            this.Controls.Add(this.labelOver10Result);
            this.Controls.Add(this.labelMSEResult);
            this.Controls.Add(this.labelAreaResult);
            this.Controls.Add(this.labelOver120);
            this.Controls.Add(this.labelOver80);
            this.Controls.Add(this.labelOver50);
            this.Controls.Add(this.labelOver25);
            this.Controls.Add(this.labelOver10);
            this.Controls.Add(this.labelMSE);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxDirectory);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.labelEndCoords);
            this.Controls.Add(this.labelStartCoord);
            this.Controls.Add(this.labelEW);
            this.Controls.Add(this.labelNS);
            this.Controls.Add(this.maskedTextBoxEndCoord2);
            this.Controls.Add(this.maskedTextBoxEndCoord1);
            this.Controls.Add(this.maskedTextBoxStartCoord2);
            this.Controls.Add(this.maskedTextBoxStartCoord1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Straight Line Mission Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartCoord1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStartCoord2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEndCoord2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEndCoord1;
        private System.Windows.Forms.Label labelNS;
        private System.Windows.Forms.Label labelEW;
        private System.Windows.Forms.Label labelStartCoord;
        private System.Windows.Forms.Label labelEndCoords;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ToolTip toolTipCoords;
        private System.Windows.Forms.ToolTip toolTipDirectory;
        private System.Windows.Forms.ToolTip toolTipGpxRead;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelMSE;
        private System.Windows.Forms.Label labelOver10;
        private System.Windows.Forms.Label labelOver25;
        private System.Windows.Forms.Label labelOver50;
        private System.Windows.Forms.Label labelOver80;
        private System.Windows.Forms.Label labelOver120;
        private System.Windows.Forms.Label labelAreaResult;
        private System.Windows.Forms.Label labelMSEResult;
        private System.Windows.Forms.Label labelOver10Result;
        private System.Windows.Forms.Label labelOver25Result;
        private System.Windows.Forms.Label labelOver50Result;
        private System.Windows.Forms.Label labelOver80Result;
        private System.Windows.Forms.Label labelOver120Result;
        private System.Windows.Forms.Label labelAreaNormResult;
        private System.Windows.Forms.Label labelAreaNorm;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMaxDeviation;
        private System.Windows.Forms.Label labelMaxDeviationResult;
    }
}

