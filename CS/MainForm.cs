using System;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;

namespace TwoBoundSeriesInPanes {
    public partial class MainForm : XtraForm {
        public MainForm() {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            gspTableAdapter.Fill(gspDataSet.GSP);
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            Series year2003Series = new Series();
            year2003Series.Name = "2003";
            year2003Series.ArgumentDataMember = "Region";
            year2003Series.ValueDataMembers[0] = "GSP";
            year2003Series.FilterString = @"[Year] == 2003";

            Series year2004Series = new Series();
            year2004Series.Name = "2004";
            year2004Series.ArgumentDataMember = "Region";
            year2004Series.ValueDataMembers[0] = "GSP";
            year2004Series.FilterString = @"[Year] == 2004";

            chartControl.Series.AddRange(year2003Series, year2004Series);

            XYDiagram diagram = (XYDiagram)chartControl.Diagram;
            XYDiagramPane secondPane = new XYDiagramPane("Second Pane");
            diagram.Panes.Add(secondPane);

            Legend secondLegend = new Legend("Second Legend") {
                DockTarget = secondPane,
                AlignmentHorizontal = LegendAlignmentHorizontal.Right,
                AlignmentVertical = LegendAlignmentVertical.Top
            };
            chartControl.Legends.Add(secondLegend);

            XYDiagramSeriesViewBase xyView = (XYDiagramSeriesViewBase)year2004Series.View;
            year2004Series.Legend = secondLegend;
            xyView.Pane = secondPane;
        }
    }
}