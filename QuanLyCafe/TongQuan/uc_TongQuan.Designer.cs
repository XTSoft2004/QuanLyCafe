namespace QuanLyCafe.TongQuan
{
    partial class uc_TongQuan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.ChartThongKe = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.ChartThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartThongKe
            // 
            this.ChartThongKe.Legend.LegendID = -1;
            this.ChartThongKe.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.ChartThongKe.Location = new System.Drawing.Point(117, 229);
            this.ChartThongKe.Name = "ChartThongKe";
            series1.Name = "Series 1";
            series1.SeriesID = 7;
            series1.View = pieSeriesView1;
            this.ChartThongKe.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.ChartThongKe.Size = new System.Drawing.Size(439, 308);
            this.ChartThongKe.TabIndex = 0;
            // 
            // uc_TongQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChartThongKe);
            this.Name = "uc_TongQuan";
            this.Size = new System.Drawing.Size(1124, 556);
            this.Load += new System.EventHandler(this.uc_TongQuan_Load);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl ChartThongKe;
    }
}
