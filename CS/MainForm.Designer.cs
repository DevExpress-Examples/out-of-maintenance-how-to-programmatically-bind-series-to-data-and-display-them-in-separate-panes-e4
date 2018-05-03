namespace TwoBoundSeriesInPanes
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.gspTableAdapter = new TwoBoundSeriesInPanes.gspDataSetTableAdapters.GSPTableAdapter();
            this.gspBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gspDataSet = new TwoBoundSeriesInPanes.gspDataSet();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gspBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gspDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl
            // 
            this.chartControl.CrosshairOptions.ShowOnlyInFocusedPane = false;
            this.chartControl.DataAdapter = this.gspTableAdapter;
            this.chartControl.DataSource = this.gspBindingSource;
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Location = new System.Drawing.Point(0, 0);
            this.chartControl.Name = "chartControl";
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl.Size = new System.Drawing.Size(638, 448);
            this.chartControl.TabIndex = 1;
            // 
            // gspTableAdapter
            // 
            this.gspTableAdapter.ClearBeforeFill = true;
            // 
            // gspBindingSource
            // 
            this.gspBindingSource.DataMember = "GSP";
            this.gspBindingSource.DataSource = this.gspDataSet;
            this.gspBindingSource.Sort = "";
            // 
            // gspDataSet
            // 
            this.gspDataSet.DataSetName = "gspDataSet";
            this.gspDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 448);
            this.Controls.Add(this.chartControl);
            this.Name = "MainForm";
            this.Text = "Panes Example";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gspBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gspDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl chartControl;
        private gspDataSetTableAdapters.GSPTableAdapter gspTableAdapter;
        private System.Windows.Forms.BindingSource gspBindingSource;
        private gspDataSet gspDataSet;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
    }
}

