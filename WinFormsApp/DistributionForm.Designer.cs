namespace WinFormsApp
{
    partial class DistributionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartSpeciality = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartSpeciality).BeginInit();
            SuspendLayout();
            // 
            // chartSpeciality
            // 
            chartArea2.Name = "ChartArea1";
            chartSpeciality.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartSpeciality.Legends.Add(legend2);
            chartSpeciality.Location = new Point(18, 15);
            chartSpeciality.Name = "chartSpeciality";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartSpeciality.Series.Add(series2);
            chartSpeciality.Size = new Size(765, 410);
            chartSpeciality.TabIndex = 0;
            chartSpeciality.Text = "chart1";
            // 
            // DistributionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chartSpeciality);
            Name = "DistributionForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chartSpeciality).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpeciality;
    }
}