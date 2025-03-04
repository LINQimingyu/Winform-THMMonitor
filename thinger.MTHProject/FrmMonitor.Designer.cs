namespace thinger.MTHProject
{
    partial class FrmMonitor
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
            SeeSharpTools.JY.GUI.StripChartXSeries stripChartXSeries1 = new SeeSharpTools.JY.GUI.StripChartXSeries();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonitor));
            this.stripChartX1 = new SeeSharpTools.JY.GUI.StripChartX();
            this.lst_info = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBoxEX12 = new thinger.MTHConttrolLib.CheckBoxEX();
            this.checkBoxEX8 = new thinger.MTHConttrolLib.CheckBoxEX();
            this.checkBoxEX4 = new thinger.MTHConttrolLib.CheckBoxEX();
            this.checkBoxEX11 = new thinger.MTHConttrolLib.CheckBoxEX();
            this.checkBoxEX7 = new thinger.MTHConttrolLib.CheckBoxEX();
            this.checkBoxEX3 = new thinger.MTHConttrolLib.CheckBoxEX();
            this.checkBoxEX10 = new thinger.MTHConttrolLib.CheckBoxEX();
            this.checkBoxEX6 = new thinger.MTHConttrolLib.CheckBoxEX();
            this.checkBoxEX2 = new thinger.MTHConttrolLib.CheckBoxEX();
            this.checkBoxEX9 = new thinger.MTHConttrolLib.CheckBoxEX();
            this.checkBoxEX5 = new thinger.MTHConttrolLib.CheckBoxEX();
            this.checkBoxEX1 = new thinger.MTHConttrolLib.CheckBoxEX();
            this.title2 = new thinger.MTHConttrolLib.Title();
            this.title1 = new thinger.MTHConttrolLib.Title();
            this.thmControl6 = new thinger.MTHConttrolLib.THMControl();
            this.thmControl3 = new thinger.MTHConttrolLib.THMControl();
            this.thmControl5 = new thinger.MTHConttrolLib.THMControl();
            this.thmControl4 = new thinger.MTHConttrolLib.THMControl();
            this.thmControl2 = new thinger.MTHConttrolLib.THMControl();
            this.thmControl1 = new thinger.MTHConttrolLib.THMControl();
            this.panelEnhanced1 = new thinger.MTHConttrolLib.PanelEnhanced();
            this.panelEnhanced1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stripChartX1
            // 
            this.stripChartX1.AxisX.AutoScale = false;
            this.stripChartX1.AxisX.AutoZoomReset = false;
            this.stripChartX1.AxisX.Color = System.Drawing.Color.White;
            this.stripChartX1.AxisX.InitWithScaleView = false;
            this.stripChartX1.AxisX.IsLogarithmic = false;
            this.stripChartX1.AxisX.LabelAngle = 0;
            this.stripChartX1.AxisX.LabelEnabled = true;
            this.stripChartX1.AxisX.LabelFormat = null;
            this.stripChartX1.AxisX.MajorGridColor = System.Drawing.Color.White;
            this.stripChartX1.AxisX.MajorGridCount = 6;
            this.stripChartX1.AxisX.MajorGridEnabled = true;
            this.stripChartX1.AxisX.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.stripChartX1.AxisX.Maximum = 1000D;
            this.stripChartX1.AxisX.Minimum = 0D;
            this.stripChartX1.AxisX.MinorGridColor = System.Drawing.Color.Black;
            this.stripChartX1.AxisX.MinorGridEnabled = false;
            this.stripChartX1.AxisX.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.stripChartX1.AxisX.TickWidth = 1F;
            this.stripChartX1.AxisX.Title = "";
            this.stripChartX1.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.stripChartX1.AxisX.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.stripChartX1.AxisX.ViewMaximum = 1000D;
            this.stripChartX1.AxisX.ViewMinimum = 0D;
            this.stripChartX1.AxisX2.AutoScale = false;
            this.stripChartX1.AxisX2.AutoZoomReset = false;
            this.stripChartX1.AxisX2.Color = System.Drawing.Color.Black;
            this.stripChartX1.AxisX2.InitWithScaleView = false;
            this.stripChartX1.AxisX2.IsLogarithmic = false;
            this.stripChartX1.AxisX2.LabelAngle = 0;
            this.stripChartX1.AxisX2.LabelEnabled = true;
            this.stripChartX1.AxisX2.LabelFormat = null;
            this.stripChartX1.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.stripChartX1.AxisX2.MajorGridCount = 6;
            this.stripChartX1.AxisX2.MajorGridEnabled = true;
            this.stripChartX1.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.stripChartX1.AxisX2.Maximum = 1000D;
            this.stripChartX1.AxisX2.Minimum = 0D;
            this.stripChartX1.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.stripChartX1.AxisX2.MinorGridEnabled = false;
            this.stripChartX1.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.stripChartX1.AxisX2.TickWidth = 1F;
            this.stripChartX1.AxisX2.Title = "";
            this.stripChartX1.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.stripChartX1.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.stripChartX1.AxisX2.ViewMaximum = 1000D;
            this.stripChartX1.AxisX2.ViewMinimum = 0D;
            this.stripChartX1.AxisY.AutoScale = true;
            this.stripChartX1.AxisY.AutoZoomReset = false;
            this.stripChartX1.AxisY.Color = System.Drawing.Color.White;
            this.stripChartX1.AxisY.InitWithScaleView = false;
            this.stripChartX1.AxisY.IsLogarithmic = false;
            this.stripChartX1.AxisY.LabelAngle = 0;
            this.stripChartX1.AxisY.LabelEnabled = true;
            this.stripChartX1.AxisY.LabelFormat = null;
            this.stripChartX1.AxisY.MajorGridColor = System.Drawing.Color.White;
            this.stripChartX1.AxisY.MajorGridCount = 6;
            this.stripChartX1.AxisY.MajorGridEnabled = true;
            this.stripChartX1.AxisY.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.stripChartX1.AxisY.Maximum = 3.5D;
            this.stripChartX1.AxisY.Minimum = 0.5D;
            this.stripChartX1.AxisY.MinorGridColor = System.Drawing.Color.Black;
            this.stripChartX1.AxisY.MinorGridEnabled = false;
            this.stripChartX1.AxisY.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.stripChartX1.AxisY.TickWidth = 1F;
            this.stripChartX1.AxisY.Title = "";
            this.stripChartX1.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.stripChartX1.AxisY.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.stripChartX1.AxisY.ViewMaximum = 3.5D;
            this.stripChartX1.AxisY.ViewMinimum = 0.5D;
            this.stripChartX1.AxisY2.AutoScale = true;
            this.stripChartX1.AxisY2.AutoZoomReset = false;
            this.stripChartX1.AxisY2.Color = System.Drawing.Color.Black;
            this.stripChartX1.AxisY2.InitWithScaleView = false;
            this.stripChartX1.AxisY2.IsLogarithmic = false;
            this.stripChartX1.AxisY2.LabelAngle = 0;
            this.stripChartX1.AxisY2.LabelEnabled = true;
            this.stripChartX1.AxisY2.LabelFormat = null;
            this.stripChartX1.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.stripChartX1.AxisY2.MajorGridCount = 6;
            this.stripChartX1.AxisY2.MajorGridEnabled = true;
            this.stripChartX1.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.Dash;
            this.stripChartX1.AxisY2.Maximum = 3.5D;
            this.stripChartX1.AxisY2.Minimum = 0.5D;
            this.stripChartX1.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.stripChartX1.AxisY2.MinorGridEnabled = false;
            this.stripChartX1.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.StripChartXAxis.GridStyle.DashDot;
            this.stripChartX1.AxisY2.TickWidth = 1F;
            this.stripChartX1.AxisY2.Title = "";
            this.stripChartX1.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextOrientation.Auto;
            this.stripChartX1.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.StripChartXAxis.AxisTextPosition.Center;
            this.stripChartX1.AxisY2.ViewMaximum = 3.5D;
            this.stripChartX1.AxisY2.ViewMinimum = 0.5D;
            this.stripChartX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.stripChartX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stripChartX1.ChartAreaBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.stripChartX1.Direction = SeeSharpTools.JY.GUI.StripChartX.ScrollDirection.LeftToRight;
            this.stripChartX1.DisplayPoints = 4000;
            this.stripChartX1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.stripChartX1.ForeColor = System.Drawing.Color.White;
            this.stripChartX1.GradientStyle = SeeSharpTools.JY.GUI.StripChartX.ChartGradientStyle.None;
            this.stripChartX1.LegendBackColor = System.Drawing.Color.Transparent;
            this.stripChartX1.LegendFont = new System.Drawing.Font("微软雅黑", 11F);
            this.stripChartX1.LegendForeColor = System.Drawing.Color.White;
            this.stripChartX1.LegendVisible = true;
            stripChartXSeries1.Color = System.Drawing.Color.Red;
            stripChartXSeries1.Marker = SeeSharpTools.JY.GUI.StripChartXSeries.MarkerType.None;
            stripChartXSeries1.Name = "1号站点温度";
            stripChartXSeries1.Type = SeeSharpTools.JY.GUI.StripChartXSeries.LineType.FastLine;
            stripChartXSeries1.Visible = true;
            stripChartXSeries1.Width = SeeSharpTools.JY.GUI.StripChartXSeries.LineWidth.Thin;
            stripChartXSeries1.XPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            stripChartXSeries1.YPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            this.stripChartX1.LineSeries.Add(stripChartXSeries1);
            this.stripChartX1.Location = new System.Drawing.Point(828, 53);
            this.stripChartX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stripChartX1.Miscellaneous.CheckInfinity = false;
            this.stripChartX1.Miscellaneous.CheckNaN = false;
            this.stripChartX1.Miscellaneous.CheckNegtiveOrZero = false;
            this.stripChartX1.Miscellaneous.DirectionChartCount = 3;
            this.stripChartX1.Miscellaneous.Fitting = SeeSharpTools.JY.GUI.StripChartX.FitType.Range;
            this.stripChartX1.Miscellaneous.MaxSeriesCount = 32;
            this.stripChartX1.Miscellaneous.MaxSeriesPointCount = 4000;
            this.stripChartX1.Miscellaneous.SplitLayoutColumnInterval = 0F;
            this.stripChartX1.Miscellaneous.SplitLayoutDirection = SeeSharpTools.JY.GUI.StripChartXUtility.LayoutDirection.LeftToRight;
            this.stripChartX1.Miscellaneous.SplitLayoutRowInterval = 0F;
            this.stripChartX1.Miscellaneous.SplitViewAutoLayout = true;
            this.stripChartX1.Name = "stripChartX1";
            this.stripChartX1.NextTimeStamp = new System.DateTime(((long)(0)));
            this.stripChartX1.ScrollType = SeeSharpTools.JY.GUI.StripChartX.StripScrollType.Cumulation;
            this.stripChartX1.SeriesCount = 1;
            this.stripChartX1.Size = new System.Drawing.Size(559, 287);
            this.stripChartX1.SplitView = false;
            this.stripChartX1.StartIndex = 0;
            this.stripChartX1.TabIndex = 3;
            this.stripChartX1.TimeInterval = System.TimeSpan.Parse("00:00:00");
            this.stripChartX1.TimeStampFormat = null;
            this.stripChartX1.XCursor.AutoInterval = true;
            this.stripChartX1.XCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.stripChartX1.XCursor.Interval = 0.001D;
            this.stripChartX1.XCursor.Mode = SeeSharpTools.JY.GUI.StripChartXCursor.CursorMode.Zoom;
            this.stripChartX1.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.stripChartX1.XCursor.Value = double.NaN;
            this.stripChartX1.XDataType = SeeSharpTools.JY.GUI.StripChartX.XAxisDataType.Index;
            this.stripChartX1.YCursor.AutoInterval = true;
            this.stripChartX1.YCursor.Color = System.Drawing.Color.DeepSkyBlue;
            this.stripChartX1.YCursor.Interval = 0.001D;
            this.stripChartX1.YCursor.Mode = SeeSharpTools.JY.GUI.StripChartXCursor.CursorMode.Disabled;
            this.stripChartX1.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.stripChartX1.YCursor.Value = double.NaN;
            // 
            // lst_info
            // 
            this.lst_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.lst_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lst_info.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lst_info.HideSelection = false;
            this.lst_info.Location = new System.Drawing.Point(828, 532);
            this.lst_info.Name = "lst_info";
            this.lst_info.ShowItemToolTips = true;
            this.lst_info.Size = new System.Drawing.Size(559, 193);
            this.lst_info.SmallImageList = this.imageList1;
            this.lst_info.TabIndex = 4;
            this.lst_info.UseCompatibleStateImageBehavior = false;
            this.lst_info.View = System.Windows.Forms.View.Details;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "info.png");
            this.imageList1.Images.SetKeyName(1, "warning.png");
            this.imageList1.Images.SetKeyName(2, "error.png");
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "日志时间";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "日志内容";
            this.columnHeader2.Width = 200;
            // 
            // checkBoxEX12
            // 
            this.checkBoxEX12.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX12.CheckBackColor = System.Drawing.Color.White;
            this.checkBoxEX12.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEX12.Checked = true;
            this.checkBoxEX12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEX12.DefaultCheckButtonWidth = 20;
            this.checkBoxEX12.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX12.Location = new System.Drawing.Point(1284, 442);
            this.checkBoxEX12.Name = "checkBoxEX12";
            this.checkBoxEX12.Size = new System.Drawing.Size(103, 31);
            this.checkBoxEX12.TabIndex = 2;
            this.checkBoxEX12.Text = "6号站湿度";
            this.checkBoxEX12.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX8
            // 
            this.checkBoxEX8.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX8.CheckBackColor = System.Drawing.Color.White;
            this.checkBoxEX8.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEX8.Checked = true;
            this.checkBoxEX8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEX8.DefaultCheckButtonWidth = 20;
            this.checkBoxEX8.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX8.Location = new System.Drawing.Point(1284, 395);
            this.checkBoxEX8.Name = "checkBoxEX8";
            this.checkBoxEX8.Size = new System.Drawing.Size(103, 31);
            this.checkBoxEX8.TabIndex = 2;
            this.checkBoxEX8.Text = "4号站湿度";
            this.checkBoxEX8.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX4
            // 
            this.checkBoxEX4.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX4.CheckBackColor = System.Drawing.Color.White;
            this.checkBoxEX4.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEX4.Checked = true;
            this.checkBoxEX4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEX4.DefaultCheckButtonWidth = 20;
            this.checkBoxEX4.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX4.Location = new System.Drawing.Point(1284, 348);
            this.checkBoxEX4.Name = "checkBoxEX4";
            this.checkBoxEX4.Size = new System.Drawing.Size(103, 31);
            this.checkBoxEX4.TabIndex = 2;
            this.checkBoxEX4.Text = "2号站湿度";
            this.checkBoxEX4.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX11
            // 
            this.checkBoxEX11.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX11.CheckBackColor = System.Drawing.Color.White;
            this.checkBoxEX11.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEX11.Checked = true;
            this.checkBoxEX11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEX11.DefaultCheckButtonWidth = 20;
            this.checkBoxEX11.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX11.Location = new System.Drawing.Point(1132, 442);
            this.checkBoxEX11.Name = "checkBoxEX11";
            this.checkBoxEX11.Size = new System.Drawing.Size(103, 31);
            this.checkBoxEX11.TabIndex = 2;
            this.checkBoxEX11.Text = "6号站温度";
            this.checkBoxEX11.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX7
            // 
            this.checkBoxEX7.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX7.CheckBackColor = System.Drawing.Color.White;
            this.checkBoxEX7.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEX7.Checked = true;
            this.checkBoxEX7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEX7.DefaultCheckButtonWidth = 20;
            this.checkBoxEX7.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX7.Location = new System.Drawing.Point(1132, 395);
            this.checkBoxEX7.Name = "checkBoxEX7";
            this.checkBoxEX7.Size = new System.Drawing.Size(103, 31);
            this.checkBoxEX7.TabIndex = 2;
            this.checkBoxEX7.Text = "4号站温度";
            this.checkBoxEX7.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX3
            // 
            this.checkBoxEX3.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX3.CheckBackColor = System.Drawing.Color.White;
            this.checkBoxEX3.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEX3.Checked = true;
            this.checkBoxEX3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEX3.DefaultCheckButtonWidth = 20;
            this.checkBoxEX3.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX3.Location = new System.Drawing.Point(1132, 348);
            this.checkBoxEX3.Name = "checkBoxEX3";
            this.checkBoxEX3.Size = new System.Drawing.Size(103, 31);
            this.checkBoxEX3.TabIndex = 2;
            this.checkBoxEX3.Text = "2号站温度";
            this.checkBoxEX3.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX10
            // 
            this.checkBoxEX10.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX10.CheckBackColor = System.Drawing.Color.White;
            this.checkBoxEX10.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEX10.Checked = true;
            this.checkBoxEX10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEX10.DefaultCheckButtonWidth = 20;
            this.checkBoxEX10.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX10.Location = new System.Drawing.Point(980, 442);
            this.checkBoxEX10.Name = "checkBoxEX10";
            this.checkBoxEX10.Size = new System.Drawing.Size(103, 31);
            this.checkBoxEX10.TabIndex = 2;
            this.checkBoxEX10.Text = "5号站湿度";
            this.checkBoxEX10.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX6
            // 
            this.checkBoxEX6.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX6.CheckBackColor = System.Drawing.Color.White;
            this.checkBoxEX6.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEX6.Checked = true;
            this.checkBoxEX6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEX6.DefaultCheckButtonWidth = 20;
            this.checkBoxEX6.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX6.Location = new System.Drawing.Point(980, 395);
            this.checkBoxEX6.Name = "checkBoxEX6";
            this.checkBoxEX6.Size = new System.Drawing.Size(103, 31);
            this.checkBoxEX6.TabIndex = 2;
            this.checkBoxEX6.Text = "3号站湿度";
            this.checkBoxEX6.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX2
            // 
            this.checkBoxEX2.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX2.CheckBackColor = System.Drawing.Color.White;
            this.checkBoxEX2.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEX2.Checked = true;
            this.checkBoxEX2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEX2.DefaultCheckButtonWidth = 20;
            this.checkBoxEX2.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX2.Location = new System.Drawing.Point(980, 348);
            this.checkBoxEX2.Name = "checkBoxEX2";
            this.checkBoxEX2.Size = new System.Drawing.Size(103, 31);
            this.checkBoxEX2.TabIndex = 2;
            this.checkBoxEX2.Text = "1号站湿度";
            this.checkBoxEX2.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX9
            // 
            this.checkBoxEX9.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX9.CheckBackColor = System.Drawing.Color.White;
            this.checkBoxEX9.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEX9.Checked = true;
            this.checkBoxEX9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEX9.DefaultCheckButtonWidth = 20;
            this.checkBoxEX9.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX9.Location = new System.Drawing.Point(828, 442);
            this.checkBoxEX9.Name = "checkBoxEX9";
            this.checkBoxEX9.Size = new System.Drawing.Size(103, 31);
            this.checkBoxEX9.TabIndex = 2;
            this.checkBoxEX9.Text = "5号站温度";
            this.checkBoxEX9.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX5
            // 
            this.checkBoxEX5.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX5.CheckBackColor = System.Drawing.Color.White;
            this.checkBoxEX5.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEX5.Checked = true;
            this.checkBoxEX5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEX5.DefaultCheckButtonWidth = 20;
            this.checkBoxEX5.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX5.Location = new System.Drawing.Point(828, 395);
            this.checkBoxEX5.Name = "checkBoxEX5";
            this.checkBoxEX5.Size = new System.Drawing.Size(103, 31);
            this.checkBoxEX5.TabIndex = 2;
            this.checkBoxEX5.Text = "3号站温度";
            this.checkBoxEX5.UseVisualStyleBackColor = false;
            // 
            // checkBoxEX1
            // 
            this.checkBoxEX1.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEX1.CheckBackColor = System.Drawing.Color.White;
            this.checkBoxEX1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxEX1.Checked = true;
            this.checkBoxEX1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEX1.DefaultCheckButtonWidth = 20;
            this.checkBoxEX1.ForeColor = System.Drawing.Color.White;
            this.checkBoxEX1.Location = new System.Drawing.Point(828, 348);
            this.checkBoxEX1.Name = "checkBoxEX1";
            this.checkBoxEX1.Size = new System.Drawing.Size(103, 31);
            this.checkBoxEX1.TabIndex = 2;
            this.checkBoxEX1.Text = "1号站温度";
            this.checkBoxEX1.UseVisualStyleBackColor = false;
            // 
            // title2
            // 
            this.title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.title2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("title2.BackgroundImage")));
            this.title2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.title2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title2.Location = new System.Drawing.Point(787, 493);
            this.title2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(109, 31);
            this.title2.TabIndex = 1;
            this.title2.TitleName = "系统日志";
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.title1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("title1.BackgroundImage")));
            this.title1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.title1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title1.Location = new System.Drawing.Point(787, 12);
            this.title1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(109, 31);
            this.title1.TabIndex = 1;
            this.title1.TitleName = "实时趋势";
            // 
            // thmControl6
            // 
            this.thmControl6.BackColor = System.Drawing.Color.Transparent;
            this.thmControl6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thmControl6.Humidity = "0.0";
            this.thmControl6.HunidityVarName = "";
            this.thmControl6.Location = new System.Drawing.Point(412, 493);
            this.thmControl6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thmControl6.ModuleError = false;
            this.thmControl6.Name = "thmControl6";
            this.thmControl6.Size = new System.Drawing.Size(412, 236);
            this.thmControl6.StateVarName = "";
            this.thmControl6.TabIndex = 0;
            this.thmControl6.Temp = "0.0";
            this.thmControl6.TempVarName = "";
            this.thmControl6.Title = "6#站点";
            // 
            // thmControl3
            // 
            this.thmControl3.BackColor = System.Drawing.Color.Transparent;
            this.thmControl3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thmControl3.Humidity = "0.0";
            this.thmControl3.HunidityVarName = "";
            this.thmControl3.Location = new System.Drawing.Point(6, 493);
            this.thmControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thmControl3.ModuleError = false;
            this.thmControl3.Name = "thmControl3";
            this.thmControl3.Size = new System.Drawing.Size(412, 236);
            this.thmControl3.StateVarName = "";
            this.thmControl3.TabIndex = 0;
            this.thmControl3.Temp = "0.0";
            this.thmControl3.TempVarName = "";
            this.thmControl3.Title = "5#站点";
            // 
            // thmControl5
            // 
            this.thmControl5.BackColor = System.Drawing.Color.Transparent;
            this.thmControl5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thmControl5.Humidity = "0.0";
            this.thmControl5.HunidityVarName = "";
            this.thmControl5.Location = new System.Drawing.Point(412, 247);
            this.thmControl5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thmControl5.ModuleError = false;
            this.thmControl5.Name = "thmControl5";
            this.thmControl5.Size = new System.Drawing.Size(412, 236);
            this.thmControl5.StateVarName = "";
            this.thmControl5.TabIndex = 0;
            this.thmControl5.Temp = "0.0";
            this.thmControl5.TempVarName = "";
            this.thmControl5.Title = "4#站点";
            // 
            // thmControl4
            // 
            this.thmControl4.BackColor = System.Drawing.Color.Transparent;
            this.thmControl4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thmControl4.Humidity = "41.1";
            this.thmControl4.HunidityVarName = "";
            this.thmControl4.Location = new System.Drawing.Point(412, 1);
            this.thmControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thmControl4.ModuleError = false;
            this.thmControl4.Name = "thmControl4";
            this.thmControl4.Size = new System.Drawing.Size(412, 236);
            this.thmControl4.StateVarName = "";
            this.thmControl4.TabIndex = 0;
            this.thmControl4.Temp = "53.1";
            this.thmControl4.TempVarName = "";
            this.thmControl4.Title = "2#站点";
            // 
            // thmControl2
            // 
            this.thmControl2.BackColor = System.Drawing.Color.Transparent;
            this.thmControl2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thmControl2.Humidity = "0.0";
            this.thmControl2.HunidityVarName = "";
            this.thmControl2.Location = new System.Drawing.Point(6, 247);
            this.thmControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thmControl2.ModuleError = false;
            this.thmControl2.Name = "thmControl2";
            this.thmControl2.Size = new System.Drawing.Size(412, 236);
            this.thmControl2.StateVarName = "";
            this.thmControl2.TabIndex = 0;
            this.thmControl2.Temp = "0.0";
            this.thmControl2.TempVarName = "";
            this.thmControl2.Title = "3#站点";
            // 
            // thmControl1
            // 
            this.thmControl1.BackColor = System.Drawing.Color.Transparent;
            this.thmControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thmControl1.Humidity = "7";
            this.thmControl1.HunidityVarName = "";
            this.thmControl1.Location = new System.Drawing.Point(6, 1);
            this.thmControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thmControl1.ModuleError = false;
            this.thmControl1.Name = "thmControl1";
            this.thmControl1.Size = new System.Drawing.Size(412, 236);
            this.thmControl1.StateVarName = "";
            this.thmControl1.TabIndex = 0;
            this.thmControl1.Temp = "50";
            this.thmControl1.TempVarName = "";
            this.thmControl1.Title = "1#站点";
            // 
            // panelEnhanced1
            // 
            this.panelEnhanced1.BackgroundImage = global::thinger.MTHProject.Properties.Resources.BackGround;
            this.panelEnhanced1.Controls.Add(this.title2);
            this.panelEnhanced1.Controls.Add(this.title1);
            this.panelEnhanced1.Controls.Add(this.lst_info);
            this.panelEnhanced1.Controls.Add(this.thmControl5);
            this.panelEnhanced1.Controls.Add(this.stripChartX1);
            this.panelEnhanced1.Controls.Add(this.thmControl1);
            this.panelEnhanced1.Controls.Add(this.checkBoxEX12);
            this.panelEnhanced1.Controls.Add(this.thmControl2);
            this.panelEnhanced1.Controls.Add(this.checkBoxEX8);
            this.panelEnhanced1.Controls.Add(this.thmControl4);
            this.panelEnhanced1.Controls.Add(this.checkBoxEX4);
            this.panelEnhanced1.Controls.Add(this.thmControl3);
            this.panelEnhanced1.Controls.Add(this.checkBoxEX11);
            this.panelEnhanced1.Controls.Add(this.thmControl6);
            this.panelEnhanced1.Controls.Add(this.checkBoxEX7);
            this.panelEnhanced1.Controls.Add(this.checkBoxEX3);
            this.panelEnhanced1.Controls.Add(this.checkBoxEX10);
            this.panelEnhanced1.Controls.Add(this.checkBoxEX1);
            this.panelEnhanced1.Controls.Add(this.checkBoxEX6);
            this.panelEnhanced1.Controls.Add(this.checkBoxEX5);
            this.panelEnhanced1.Controls.Add(this.checkBoxEX2);
            this.panelEnhanced1.Controls.Add(this.checkBoxEX9);
            this.panelEnhanced1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEnhanced1.Location = new System.Drawing.Point(0, 0);
            this.panelEnhanced1.Name = "panelEnhanced1";
            this.panelEnhanced1.Size = new System.Drawing.Size(1394, 736);
            this.panelEnhanced1.TabIndex = 5;
            // 
            // FrmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1394, 736);
            this.Controls.Add(this.panelEnhanced1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMonitor";
            this.Text = "集中监控";
            this.panelEnhanced1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MTHConttrolLib.THMControl thmControl1;
        private MTHConttrolLib.THMControl thmControl2;
        private MTHConttrolLib.THMControl thmControl3;
        private MTHConttrolLib.THMControl thmControl4;
        private MTHConttrolLib.THMControl thmControl5;
        private MTHConttrolLib.THMControl thmControl6;
        private MTHConttrolLib.Title title1;
        private MTHConttrolLib.Title title2;
        private MTHConttrolLib.CheckBoxEX checkBoxEX1;
        private SeeSharpTools.JY.GUI.StripChartX stripChartX1;
        private MTHConttrolLib.CheckBoxEX checkBoxEX2;
        private MTHConttrolLib.CheckBoxEX checkBoxEX3;
        private MTHConttrolLib.CheckBoxEX checkBoxEX4;
        private MTHConttrolLib.CheckBoxEX checkBoxEX5;
        private MTHConttrolLib.CheckBoxEX checkBoxEX6;
        private MTHConttrolLib.CheckBoxEX checkBoxEX7;
        private MTHConttrolLib.CheckBoxEX checkBoxEX8;
        private MTHConttrolLib.CheckBoxEX checkBoxEX9;
        private MTHConttrolLib.CheckBoxEX checkBoxEX10;
        private MTHConttrolLib.CheckBoxEX checkBoxEX11;
        private MTHConttrolLib.CheckBoxEX checkBoxEX12;
        private System.Windows.Forms.ListView lst_info;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MTHConttrolLib.PanelEnhanced panelEnhanced1;
    }
}