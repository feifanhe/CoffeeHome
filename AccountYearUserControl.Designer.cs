namespace CoffeeHome
{
    partial class AccountYearUserControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AccountYearPanel = new System.Windows.Forms.Panel();
            this.AccountYearChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AccountYearStatisticsPanel = new System.Windows.Forms.Panel();
            this.AccountYearSalesPanel2 = new System.Windows.Forms.Panel();
            this.AccountYearAchievementPanel = new System.Windows.Forms.Panel();
            this.AccountYearAchievementTextBox = new System.Windows.Forms.TextBox();
            this.AccountYearAchievementButton = new System.Windows.Forms.Button();
            this.AccountYearMistakePanel = new System.Windows.Forms.Panel();
            this.AccountYearMistakeTextBox = new System.Windows.Forms.TextBox();
            this.AccountYearMistakeButton = new System.Windows.Forms.Button();
            this.AccountYearCashPanel = new System.Windows.Forms.Panel();
            this.AccountYearCashTextBox = new System.Windows.Forms.TextBox();
            this.AccountYearCashButton = new System.Windows.Forms.Button();
            this.AccountYearSalesPanel = new System.Windows.Forms.Panel();
            this.AccountYearDeliveryPanel = new System.Windows.Forms.Panel();
            this.AccountYearDeliveryTextBox = new System.Windows.Forms.TextBox();
            this.AccountYearDeliveryButton = new System.Windows.Forms.Button();
            this.AccountYearCreditCardPanel = new System.Windows.Forms.Panel();
            this.AccountYearCreditCardTextBox = new System.Windows.Forms.TextBox();
            this.AccountYearCreditCardButton = new System.Windows.Forms.Button();
            this.AccountYearNoReceiptPanel = new System.Windows.Forms.Panel();
            this.AccountYearNoReceiptTextBox = new System.Windows.Forms.TextBox();
            this.AccountYearNoReceiptButton = new System.Windows.Forms.Button();
            this.AccountYearReceiptPanel = new System.Windows.Forms.Panel();
            this.AccountYearReceiptTextBox = new System.Windows.Forms.TextBox();
            this.AccountYearReceiptButton = new System.Windows.Forms.Button();
            this.AccountYearSelectPanel = new System.Windows.Forms.Panel();
            this.AccountYearComboBox = new System.Windows.Forms.ComboBox();
            this.AccountYearPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountYearChart)).BeginInit();
            this.AccountYearStatisticsPanel.SuspendLayout();
            this.AccountYearSalesPanel2.SuspendLayout();
            this.AccountYearAchievementPanel.SuspendLayout();
            this.AccountYearMistakePanel.SuspendLayout();
            this.AccountYearCashPanel.SuspendLayout();
            this.AccountYearSalesPanel.SuspendLayout();
            this.AccountYearDeliveryPanel.SuspendLayout();
            this.AccountYearCreditCardPanel.SuspendLayout();
            this.AccountYearNoReceiptPanel.SuspendLayout();
            this.AccountYearReceiptPanel.SuspendLayout();
            this.AccountYearSelectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountYearPanel
            // 
            this.AccountYearPanel.Controls.Add(this.AccountYearChart);
            this.AccountYearPanel.Controls.Add(this.AccountYearStatisticsPanel);
            this.AccountYearPanel.Controls.Add(this.AccountYearSelectPanel);
            this.AccountYearPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountYearPanel.Location = new System.Drawing.Point(0, 0);
            this.AccountYearPanel.Name = "AccountYearPanel";
            this.AccountYearPanel.Size = new System.Drawing.Size(1024, 600);
            this.AccountYearPanel.TabIndex = 7;
            // 
            // AccountYearChart
            // 
            chartArea1.AxisX.Maximum = 12D;
            chartArea1.AxisX.Minimum = 1D;
            chartArea1.AxisY.IsLogarithmic = true;
            chartArea1.Name = "AccountYearChartArea";
            this.AccountYearChart.ChartAreas.Add(chartArea1);
            this.AccountYearChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BorderWidth = 3;
            legend1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "MonthAchievementLegend";
            this.AccountYearChart.Legends.Add(legend1);
            this.AccountYearChart.Location = new System.Drawing.Point(0, 150);
            this.AccountYearChart.Name = "AccountYearChart";
            series1.BorderWidth = 5;
            series1.ChartArea = "AccountYearChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.CustomProperties = "EmptyPointValue=Zero, LabelStyle=Top";
            series1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series1.LabelForeColor = System.Drawing.Color.Red;
            series1.Legend = "MonthAchievementLegend";
            series1.LegendText = "月營業額";
            series1.Name = "AchievementSeries";
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series1.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series1.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            series2.BorderWidth = 3;
            series2.ChartArea = "AccountYearChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.ForestGreen;
            series2.CustomProperties = "EmptyPointValue=Zero, LabelStyle=Bottom";
            series2.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            series2.IsValueShownAsLabel = true;
            series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series2.LabelForeColor = System.Drawing.Color.ForestGreen;
            series2.Legend = "MonthAchievementLegend";
            series2.LegendText = "咖啡豆";
            series2.Name = "BeansSubtotalSeries";
            series2.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series2.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series2.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            series3.BorderWidth = 3;
            series3.ChartArea = "AccountYearChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.SkyBlue;
            series3.CustomProperties = "EmptyPointValue=Zero";
            series3.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            series3.IsValueShownAsLabel = true;
            series3.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series3.LabelForeColor = System.Drawing.Color.SkyBlue;
            series3.Legend = "MonthAchievementLegend";
            series3.LegendText = "器材";
            series3.Name = "InstrumentSubtotalSeries";
            series3.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series3.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series3.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            series4.BorderWidth = 3;
            series4.ChartArea = "AccountYearChartArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Chocolate;
            series4.CustomProperties = "EmptyPointValue=Zero";
            series4.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            series4.IsValueShownAsLabel = true;
            series4.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series4.LabelForeColor = System.Drawing.Color.Chocolate;
            series4.Legend = "MonthAchievementLegend";
            series4.LegendText = "掛耳包";
            series4.Name = "CoffeeBagSubtotalSeries";
            series4.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series4.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series4.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            series5.BorderWidth = 3;
            series5.ChartArea = "AccountYearChartArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Violet;
            series5.CustomProperties = "EmptyPointValue=Zero";
            series5.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            series5.IsValueShownAsLabel = true;
            series5.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series5.LabelForeColor = System.Drawing.Color.Violet;
            series5.Legend = "MonthAchievementLegend";
            series5.LegendText = "咖啡";
            series5.Name = "DrinkSubtotalSeries";
            series5.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series5.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series5.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom)));
            this.AccountYearChart.Series.Add(series1);
            this.AccountYearChart.Series.Add(series2);
            this.AccountYearChart.Series.Add(series3);
            this.AccountYearChart.Series.Add(series4);
            this.AccountYearChart.Series.Add(series5);
            this.AccountYearChart.Size = new System.Drawing.Size(1024, 450);
            this.AccountYearChart.TabIndex = 3;
            this.AccountYearChart.Text = "年營業額";
            // 
            // AccountYearStatisticsPanel
            // 
            this.AccountYearStatisticsPanel.BackColor = System.Drawing.Color.White;
            this.AccountYearStatisticsPanel.Controls.Add(this.AccountYearSalesPanel2);
            this.AccountYearStatisticsPanel.Controls.Add(this.AccountYearSalesPanel);
            this.AccountYearStatisticsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountYearStatisticsPanel.Location = new System.Drawing.Point(0, 50);
            this.AccountYearStatisticsPanel.Name = "AccountYearStatisticsPanel";
            this.AccountYearStatisticsPanel.Size = new System.Drawing.Size(1024, 100);
            this.AccountYearStatisticsPanel.TabIndex = 1;
            // 
            // AccountYearSalesPanel2
            // 
            this.AccountYearSalesPanel2.Controls.Add(this.AccountYearAchievementPanel);
            this.AccountYearSalesPanel2.Controls.Add(this.AccountYearMistakePanel);
            this.AccountYearSalesPanel2.Controls.Add(this.AccountYearCashPanel);
            this.AccountYearSalesPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountYearSalesPanel2.Location = new System.Drawing.Point(0, 50);
            this.AccountYearSalesPanel2.Name = "AccountYearSalesPanel2";
            this.AccountYearSalesPanel2.Size = new System.Drawing.Size(1024, 50);
            this.AccountYearSalesPanel2.TabIndex = 2;
            // 
            // AccountYearAchievementPanel
            // 
            this.AccountYearAchievementPanel.Controls.Add(this.AccountYearAchievementTextBox);
            this.AccountYearAchievementPanel.Controls.Add(this.AccountYearAchievementButton);
            this.AccountYearAchievementPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountYearAchievementPanel.Location = new System.Drawing.Point(512, 0);
            this.AccountYearAchievementPanel.Name = "AccountYearAchievementPanel";
            this.AccountYearAchievementPanel.Size = new System.Drawing.Size(256, 50);
            this.AccountYearAchievementPanel.TabIndex = 6;
            // 
            // AccountYearAchievementTextBox
            // 
            this.AccountYearAchievementTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountYearAchievementTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountYearAchievementTextBox.Name = "AccountYearAchievementTextBox";
            this.AccountYearAchievementTextBox.ReadOnly = true;
            this.AccountYearAchievementTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountYearAchievementTextBox.TabIndex = 1;
            // 
            // AccountYearAchievementButton
            // 
            this.AccountYearAchievementButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountYearAchievementButton.FlatAppearance.BorderSize = 0;
            this.AccountYearAchievementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountYearAchievementButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountYearAchievementButton.Location = new System.Drawing.Point(0, 0);
            this.AccountYearAchievementButton.Name = "AccountYearAchievementButton";
            this.AccountYearAchievementButton.Size = new System.Drawing.Size(75, 50);
            this.AccountYearAchievementButton.TabIndex = 0;
            this.AccountYearAchievementButton.TabStop = false;
            this.AccountYearAchievementButton.Text = "總業績";
            this.AccountYearAchievementButton.UseVisualStyleBackColor = true;
            // 
            // AccountYearMistakePanel
            // 
            this.AccountYearMistakePanel.Controls.Add(this.AccountYearMistakeTextBox);
            this.AccountYearMistakePanel.Controls.Add(this.AccountYearMistakeButton);
            this.AccountYearMistakePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountYearMistakePanel.Location = new System.Drawing.Point(256, 0);
            this.AccountYearMistakePanel.Name = "AccountYearMistakePanel";
            this.AccountYearMistakePanel.Size = new System.Drawing.Size(256, 50);
            this.AccountYearMistakePanel.TabIndex = 7;
            // 
            // AccountYearMistakeTextBox
            // 
            this.AccountYearMistakeTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountYearMistakeTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountYearMistakeTextBox.Name = "AccountYearMistakeTextBox";
            this.AccountYearMistakeTextBox.ReadOnly = true;
            this.AccountYearMistakeTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountYearMistakeTextBox.TabIndex = 1;
            // 
            // AccountYearMistakeButton
            // 
            this.AccountYearMistakeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountYearMistakeButton.FlatAppearance.BorderSize = 0;
            this.AccountYearMistakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountYearMistakeButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountYearMistakeButton.Location = new System.Drawing.Point(0, 0);
            this.AccountYearMistakeButton.Name = "AccountYearMistakeButton";
            this.AccountYearMistakeButton.Size = new System.Drawing.Size(75, 50);
            this.AccountYearMistakeButton.TabIndex = 0;
            this.AccountYearMistakeButton.TabStop = false;
            this.AccountYearMistakeButton.Text = "總誤打";
            this.AccountYearMistakeButton.UseVisualStyleBackColor = true;
            // 
            // AccountYearCashPanel
            // 
            this.AccountYearCashPanel.Controls.Add(this.AccountYearCashTextBox);
            this.AccountYearCashPanel.Controls.Add(this.AccountYearCashButton);
            this.AccountYearCashPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountYearCashPanel.Location = new System.Drawing.Point(0, 0);
            this.AccountYearCashPanel.Name = "AccountYearCashPanel";
            this.AccountYearCashPanel.Size = new System.Drawing.Size(256, 50);
            this.AccountYearCashPanel.TabIndex = 8;
            // 
            // AccountYearCashTextBox
            // 
            this.AccountYearCashTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountYearCashTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountYearCashTextBox.Name = "AccountYearCashTextBox";
            this.AccountYearCashTextBox.ReadOnly = true;
            this.AccountYearCashTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountYearCashTextBox.TabIndex = 1;
            // 
            // AccountYearCashButton
            // 
            this.AccountYearCashButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountYearCashButton.FlatAppearance.BorderSize = 0;
            this.AccountYearCashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountYearCashButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountYearCashButton.Location = new System.Drawing.Point(0, 0);
            this.AccountYearCashButton.Name = "AccountYearCashButton";
            this.AccountYearCashButton.Size = new System.Drawing.Size(75, 50);
            this.AccountYearCashButton.TabIndex = 0;
            this.AccountYearCashButton.TabStop = false;
            this.AccountYearCashButton.Text = "總現金";
            this.AccountYearCashButton.UseVisualStyleBackColor = true;
            // 
            // AccountYearSalesPanel
            // 
            this.AccountYearSalesPanel.Controls.Add(this.AccountYearDeliveryPanel);
            this.AccountYearSalesPanel.Controls.Add(this.AccountYearCreditCardPanel);
            this.AccountYearSalesPanel.Controls.Add(this.AccountYearNoReceiptPanel);
            this.AccountYearSalesPanel.Controls.Add(this.AccountYearReceiptPanel);
            this.AccountYearSalesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountYearSalesPanel.Location = new System.Drawing.Point(0, 0);
            this.AccountYearSalesPanel.Name = "AccountYearSalesPanel";
            this.AccountYearSalesPanel.Size = new System.Drawing.Size(1024, 50);
            this.AccountYearSalesPanel.TabIndex = 0;
            // 
            // AccountYearDeliveryPanel
            // 
            this.AccountYearDeliveryPanel.Controls.Add(this.AccountYearDeliveryTextBox);
            this.AccountYearDeliveryPanel.Controls.Add(this.AccountYearDeliveryButton);
            this.AccountYearDeliveryPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountYearDeliveryPanel.Location = new System.Drawing.Point(768, 0);
            this.AccountYearDeliveryPanel.Name = "AccountYearDeliveryPanel";
            this.AccountYearDeliveryPanel.Size = new System.Drawing.Size(256, 50);
            this.AccountYearDeliveryPanel.TabIndex = 5;
            // 
            // AccountYearDeliveryTextBox
            // 
            this.AccountYearDeliveryTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountYearDeliveryTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountYearDeliveryTextBox.Name = "AccountYearDeliveryTextBox";
            this.AccountYearDeliveryTextBox.ReadOnly = true;
            this.AccountYearDeliveryTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountYearDeliveryTextBox.TabIndex = 2;
            // 
            // AccountYearDeliveryButton
            // 
            this.AccountYearDeliveryButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountYearDeliveryButton.FlatAppearance.BorderSize = 0;
            this.AccountYearDeliveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountYearDeliveryButton.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountYearDeliveryButton.Location = new System.Drawing.Point(0, 0);
            this.AccountYearDeliveryButton.Name = "AccountYearDeliveryButton";
            this.AccountYearDeliveryButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.AccountYearDeliveryButton.Size = new System.Drawing.Size(75, 50);
            this.AccountYearDeliveryButton.TabIndex = 1;
            this.AccountYearDeliveryButton.TabStop = false;
            this.AccountYearDeliveryButton.Text = "貨到付款";
            this.AccountYearDeliveryButton.UseVisualStyleBackColor = true;
            // 
            // AccountYearCreditCardPanel
            // 
            this.AccountYearCreditCardPanel.Controls.Add(this.AccountYearCreditCardTextBox);
            this.AccountYearCreditCardPanel.Controls.Add(this.AccountYearCreditCardButton);
            this.AccountYearCreditCardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountYearCreditCardPanel.Location = new System.Drawing.Point(512, 0);
            this.AccountYearCreditCardPanel.Name = "AccountYearCreditCardPanel";
            this.AccountYearCreditCardPanel.Size = new System.Drawing.Size(256, 50);
            this.AccountYearCreditCardPanel.TabIndex = 2;
            // 
            // AccountYearCreditCardTextBox
            // 
            this.AccountYearCreditCardTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountYearCreditCardTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountYearCreditCardTextBox.Name = "AccountYearCreditCardTextBox";
            this.AccountYearCreditCardTextBox.ReadOnly = true;
            this.AccountYearCreditCardTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountYearCreditCardTextBox.TabIndex = 2;
            // 
            // AccountYearCreditCardButton
            // 
            this.AccountYearCreditCardButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountYearCreditCardButton.FlatAppearance.BorderSize = 0;
            this.AccountYearCreditCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountYearCreditCardButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountYearCreditCardButton.Location = new System.Drawing.Point(0, 0);
            this.AccountYearCreditCardButton.Name = "AccountYearCreditCardButton";
            this.AccountYearCreditCardButton.Size = new System.Drawing.Size(75, 50);
            this.AccountYearCreditCardButton.TabIndex = 1;
            this.AccountYearCreditCardButton.TabStop = false;
            this.AccountYearCreditCardButton.Text = "信用卡";
            this.AccountYearCreditCardButton.UseVisualStyleBackColor = true;
            // 
            // AccountYearNoReceiptPanel
            // 
            this.AccountYearNoReceiptPanel.Controls.Add(this.AccountYearNoReceiptTextBox);
            this.AccountYearNoReceiptPanel.Controls.Add(this.AccountYearNoReceiptButton);
            this.AccountYearNoReceiptPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountYearNoReceiptPanel.Location = new System.Drawing.Point(256, 0);
            this.AccountYearNoReceiptPanel.Name = "AccountYearNoReceiptPanel";
            this.AccountYearNoReceiptPanel.Size = new System.Drawing.Size(256, 50);
            this.AccountYearNoReceiptPanel.TabIndex = 1;
            // 
            // AccountYearNoReceiptTextBox
            // 
            this.AccountYearNoReceiptTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountYearNoReceiptTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountYearNoReceiptTextBox.Name = "AccountYearNoReceiptTextBox";
            this.AccountYearNoReceiptTextBox.ReadOnly = true;
            this.AccountYearNoReceiptTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountYearNoReceiptTextBox.TabIndex = 2;
            // 
            // AccountYearNoReceiptButton
            // 
            this.AccountYearNoReceiptButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountYearNoReceiptButton.FlatAppearance.BorderSize = 0;
            this.AccountYearNoReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountYearNoReceiptButton.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountYearNoReceiptButton.Location = new System.Drawing.Point(0, 0);
            this.AccountYearNoReceiptButton.Name = "AccountYearNoReceiptButton";
            this.AccountYearNoReceiptButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.AccountYearNoReceiptButton.Size = new System.Drawing.Size(75, 50);
            this.AccountYearNoReceiptButton.TabIndex = 1;
            this.AccountYearNoReceiptButton.TabStop = false;
            this.AccountYearNoReceiptButton.Text = "未開發票";
            this.AccountYearNoReceiptButton.UseVisualStyleBackColor = true;
            // 
            // AccountYearReceiptPanel
            // 
            this.AccountYearReceiptPanel.Controls.Add(this.AccountYearReceiptTextBox);
            this.AccountYearReceiptPanel.Controls.Add(this.AccountYearReceiptButton);
            this.AccountYearReceiptPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountYearReceiptPanel.Location = new System.Drawing.Point(0, 0);
            this.AccountYearReceiptPanel.Name = "AccountYearReceiptPanel";
            this.AccountYearReceiptPanel.Size = new System.Drawing.Size(256, 50);
            this.AccountYearReceiptPanel.TabIndex = 0;
            // 
            // AccountYearReceiptTextBox
            // 
            this.AccountYearReceiptTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountYearReceiptTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountYearReceiptTextBox.Name = "AccountYearReceiptTextBox";
            this.AccountYearReceiptTextBox.ReadOnly = true;
            this.AccountYearReceiptTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountYearReceiptTextBox.TabIndex = 1;
            // 
            // AccountYearReceiptButton
            // 
            this.AccountYearReceiptButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountYearReceiptButton.FlatAppearance.BorderSize = 0;
            this.AccountYearReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountYearReceiptButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountYearReceiptButton.Location = new System.Drawing.Point(0, 0);
            this.AccountYearReceiptButton.Name = "AccountYearReceiptButton";
            this.AccountYearReceiptButton.Size = new System.Drawing.Size(75, 50);
            this.AccountYearReceiptButton.TabIndex = 0;
            this.AccountYearReceiptButton.TabStop = false;
            this.AccountYearReceiptButton.Text = "發票";
            this.AccountYearReceiptButton.UseVisualStyleBackColor = true;
            // 
            // AccountYearSelectPanel
            // 
            this.AccountYearSelectPanel.BackColor = System.Drawing.Color.White;
            this.AccountYearSelectPanel.Controls.Add(this.AccountYearComboBox);
            this.AccountYearSelectPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountYearSelectPanel.Location = new System.Drawing.Point(0, 0);
            this.AccountYearSelectPanel.Name = "AccountYearSelectPanel";
            this.AccountYearSelectPanel.Size = new System.Drawing.Size(1024, 50);
            this.AccountYearSelectPanel.TabIndex = 0;
            // 
            // AccountYearComboBox
            // 
            this.AccountYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountYearComboBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountYearComboBox.FormattingEnabled = true;
            this.AccountYearComboBox.Location = new System.Drawing.Point(6, 6);
            this.AccountYearComboBox.Name = "AccountYearComboBox";
            this.AccountYearComboBox.Size = new System.Drawing.Size(121, 35);
            this.AccountYearComboBox.TabIndex = 0;
            this.AccountYearComboBox.SelectedIndexChanged += new System.EventHandler(this.AccountYearComboBox_SelectedIndexChanged);
            // 
            // AccountYearUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AccountYearPanel);
            this.Name = "AccountYearUserControl";
            this.Size = new System.Drawing.Size(1024, 600);
            this.AccountYearPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountYearChart)).EndInit();
            this.AccountYearStatisticsPanel.ResumeLayout(false);
            this.AccountYearSalesPanel2.ResumeLayout(false);
            this.AccountYearAchievementPanel.ResumeLayout(false);
            this.AccountYearAchievementPanel.PerformLayout();
            this.AccountYearMistakePanel.ResumeLayout(false);
            this.AccountYearMistakePanel.PerformLayout();
            this.AccountYearCashPanel.ResumeLayout(false);
            this.AccountYearCashPanel.PerformLayout();
            this.AccountYearSalesPanel.ResumeLayout(false);
            this.AccountYearDeliveryPanel.ResumeLayout(false);
            this.AccountYearDeliveryPanel.PerformLayout();
            this.AccountYearCreditCardPanel.ResumeLayout(false);
            this.AccountYearCreditCardPanel.PerformLayout();
            this.AccountYearNoReceiptPanel.ResumeLayout(false);
            this.AccountYearNoReceiptPanel.PerformLayout();
            this.AccountYearReceiptPanel.ResumeLayout(false);
            this.AccountYearReceiptPanel.PerformLayout();
            this.AccountYearSelectPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AccountYearPanel;
        private System.Windows.Forms.Panel AccountYearStatisticsPanel;
        private System.Windows.Forms.Panel AccountYearSalesPanel2;
        private System.Windows.Forms.Panel AccountYearAchievementPanel;
        private System.Windows.Forms.TextBox AccountYearAchievementTextBox;
        private System.Windows.Forms.Button AccountYearAchievementButton;
        private System.Windows.Forms.Panel AccountYearMistakePanel;
        private System.Windows.Forms.TextBox AccountYearMistakeTextBox;
        private System.Windows.Forms.Button AccountYearMistakeButton;
        private System.Windows.Forms.Panel AccountYearCashPanel;
        private System.Windows.Forms.TextBox AccountYearCashTextBox;
        private System.Windows.Forms.Button AccountYearCashButton;
        private System.Windows.Forms.Panel AccountYearSalesPanel;
        private System.Windows.Forms.Panel AccountYearDeliveryPanel;
        private System.Windows.Forms.TextBox AccountYearDeliveryTextBox;
        private System.Windows.Forms.Button AccountYearDeliveryButton;
        private System.Windows.Forms.Panel AccountYearCreditCardPanel;
        private System.Windows.Forms.TextBox AccountYearCreditCardTextBox;
        private System.Windows.Forms.Button AccountYearCreditCardButton;
        private System.Windows.Forms.Panel AccountYearNoReceiptPanel;
        private System.Windows.Forms.TextBox AccountYearNoReceiptTextBox;
        private System.Windows.Forms.Button AccountYearNoReceiptButton;
        private System.Windows.Forms.Panel AccountYearReceiptPanel;
        private System.Windows.Forms.TextBox AccountYearReceiptTextBox;
        private System.Windows.Forms.Button AccountYearReceiptButton;
        private System.Windows.Forms.Panel AccountYearSelectPanel;
        private System.Windows.Forms.ComboBox AccountYearComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart AccountYearChart;
    }
}
