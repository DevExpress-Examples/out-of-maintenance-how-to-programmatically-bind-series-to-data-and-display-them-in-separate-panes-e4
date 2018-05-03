Namespace TwoBoundSeriesInPanes
    Partial Public Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.chartControl = New DevExpress.XtraCharts.ChartControl()
            Me.gspTableAdapter = New TwoBoundSeriesInPanes.gspDataSetTableAdapters.GSPTableAdapter()
            Me.gspBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gspDataSet = New TwoBoundSeriesInPanes.gspDataSet()
            Me.defaultLookAndFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            CType(Me.chartControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gspBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gspDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl
            ' 
            Me.chartControl.CrosshairOptions.ShowOnlyInFocusedPane = False
            Me.chartControl.DataAdapter = Me.gspTableAdapter
            Me.chartControl.DataSource = Me.gspBindingSource
            Me.chartControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartControl.Legend.Name = "Default Legend"
            Me.chartControl.Location = New System.Drawing.Point(0, 0)
            Me.chartControl.Name = "chartControl"
            Me.chartControl.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
            Me.chartControl.Size = New System.Drawing.Size(638, 448)
            Me.chartControl.TabIndex = 1
            ' 
            ' gspTableAdapter
            ' 
            Me.gspTableAdapter.ClearBeforeFill = True
            ' 
            ' gspBindingSource
            ' 
            Me.gspBindingSource.DataMember = "GSP"
            Me.gspBindingSource.DataSource = Me.gspDataSet
            Me.gspBindingSource.Sort = ""
            ' 
            ' gspDataSet
            ' 
            Me.gspDataSet.DataSetName = "gspDataSet"
            Me.gspDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' defaultLookAndFeel
            ' 
            Me.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(638, 448)
            Me.Controls.Add(Me.chartControl)
            Me.Name = "MainForm"
            Me.Text = "Panes Example"
            CType(Me.chartControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gspBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gspDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private chartControl As DevExpress.XtraCharts.ChartControl
        Private gspTableAdapter As gspDataSetTableAdapters.GSPTableAdapter
        Private gspBindingSource As System.Windows.Forms.BindingSource
        Private gspDataSet As gspDataSet
        Private defaultLookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

