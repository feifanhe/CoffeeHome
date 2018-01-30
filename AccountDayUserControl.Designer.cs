namespace CoffeeHome
{
    partial class AccountDayUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AccountPanel = new System.Windows.Forms.Panel();
            this.AccountDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.AccountStatisticsPanel = new System.Windows.Forms.Panel();
            this.AccountSalesPanel3 = new System.Windows.Forms.Panel();
            this.ReceiptWithMistakePanel = new System.Windows.Forms.Panel();
            this.ReceiptWithMistakeTextBox = new System.Windows.Forms.TextBox();
            this.ReceiptWithMistakeButton = new System.Windows.Forms.Button();
            this.AchievementPanel = new System.Windows.Forms.Panel();
            this.AchievementTextBox = new System.Windows.Forms.TextBox();
            this.AchievementButton = new System.Windows.Forms.Button();
            this.CashWithWorkingCapitalPanel = new System.Windows.Forms.Panel();
            this.CashWithWorkingCapitalTextBox = new System.Windows.Forms.TextBox();
            this.CashWithWorkingCapitalButton = new System.Windows.Forms.Button();
            this.CashPanel = new System.Windows.Forms.Panel();
            this.AccountSalesCashTextBox = new System.Windows.Forms.TextBox();
            this.CashButton = new System.Windows.Forms.Button();
            this.AccountSalesPanel2 = new System.Windows.Forms.Panel();
            this.MistakePanel3 = new System.Windows.Forms.Panel();
            this.MistakeTextBox3 = new System.Windows.Forms.TextBox();
            this.MistakeButton3 = new System.Windows.Forms.Button();
            this.MistakePanel2 = new System.Windows.Forms.Panel();
            this.MistakeTextBox2 = new System.Windows.Forms.TextBox();
            this.MistakeButton2 = new System.Windows.Forms.Button();
            this.MistakePanel = new System.Windows.Forms.Panel();
            this.MistakeTextBox = new System.Windows.Forms.TextBox();
            this.MistakeButton = new System.Windows.Forms.Button();
            this.WorkingCapitalPanel = new System.Windows.Forms.Panel();
            this.WorkingCapitalTextBox = new System.Windows.Forms.TextBox();
            this.WorkingCapitalButton = new System.Windows.Forms.Button();
            this.AccountSalesPanel = new System.Windows.Forms.Panel();
            this.AccountSalesDeliveryPanel = new System.Windows.Forms.Panel();
            this.AccountSalesDeliveryTextBox = new System.Windows.Forms.TextBox();
            this.AccountSalesDeliveryButton = new System.Windows.Forms.Button();
            this.AccountSalesCreditCardPanel = new System.Windows.Forms.Panel();
            this.AccountSalesCreditCardTextBox = new System.Windows.Forms.TextBox();
            this.AccountSalesCreditCardButton = new System.Windows.Forms.Button();
            this.AccountSalesNoReceiptPanel = new System.Windows.Forms.Panel();
            this.AccountSalesNoReceiptTextBox = new System.Windows.Forms.TextBox();
            this.AccountSalesNoReceiptButton = new System.Windows.Forms.Button();
            this.AccountSalesReceiptPanel = new System.Windows.Forms.Panel();
            this.AccountSalesReceiptTextBox = new System.Windows.Forms.TextBox();
            this.AccountSalesReceiptButton = new System.Windows.Forms.Button();
            this.AccountDatePanel = new System.Windows.Forms.Panel();
            this.AccuontNewTradeButton = new System.Windows.Forms.Button();
            this.AccountDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AccountTableAdapter = new CoffeeHome.CoffeeHomeDataSetTableAdapters.AccountTableAdapter();
            this.TradeTableAdapter = new CoffeeHome.CoffeeHomeDataSetTableAdapters.TradeTableAdapter();
            this.TradeItemTableAdapter = new CoffeeHome.CoffeeHomeDataSetTableAdapters.TradeItemTableAdapter();
            this.AccountDetailsTradeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDetailsTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDetailsMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDetailsPaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDetailsReceipt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDetailsItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDetailsRoastDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDetailsItemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDetailsItemSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDetailsSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountDetailsCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDetailsDataGridView)).BeginInit();
            this.AccountStatisticsPanel.SuspendLayout();
            this.AccountSalesPanel3.SuspendLayout();
            this.ReceiptWithMistakePanel.SuspendLayout();
            this.AchievementPanel.SuspendLayout();
            this.CashWithWorkingCapitalPanel.SuspendLayout();
            this.CashPanel.SuspendLayout();
            this.AccountSalesPanel2.SuspendLayout();
            this.MistakePanel3.SuspendLayout();
            this.MistakePanel2.SuspendLayout();
            this.MistakePanel.SuspendLayout();
            this.WorkingCapitalPanel.SuspendLayout();
            this.AccountSalesPanel.SuspendLayout();
            this.AccountSalesDeliveryPanel.SuspendLayout();
            this.AccountSalesCreditCardPanel.SuspendLayout();
            this.AccountSalesNoReceiptPanel.SuspendLayout();
            this.AccountSalesReceiptPanel.SuspendLayout();
            this.AccountDatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountPanel
            // 
            this.AccountPanel.Controls.Add(this.AccountDetailsDataGridView);
            this.AccountPanel.Controls.Add(this.AccountStatisticsPanel);
            this.AccountPanel.Controls.Add(this.AccountDatePanel);
            this.AccountPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountPanel.Location = new System.Drawing.Point(0, 0);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Size = new System.Drawing.Size(1024, 600);
            this.AccountPanel.TabIndex = 6;
            // 
            // AccountDetailsDataGridView
            // 
            this.AccountDetailsDataGridView.AllowUserToAddRows = false;
            this.AccountDetailsDataGridView.AllowUserToDeleteRows = false;
            this.AccountDetailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccountDetailsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.AccountDetailsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountDetailsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AccountDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountDetailsTradeID,
            this.AccountDetailsTime,
            this.AccountDetailsMemberName,
            this.AccountDetailsPaymentType,
            this.AccountDetailsReceipt,
            this.AccountDetailsItemName,
            this.AccountDetailsRoastDegree,
            this.AccountDetailsItemAmount,
            this.AccountDetailsItemSubtotal,
            this.AccountDetailsSubtotal,
            this.AccountDetailsCheck});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AccountDetailsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.AccountDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountDetailsDataGridView.GridColor = System.Drawing.Color.Silver;
            this.AccountDetailsDataGridView.Location = new System.Drawing.Point(0, 200);
            this.AccountDetailsDataGridView.Name = "AccountDetailsDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountDetailsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AccountDetailsDataGridView.RowHeadersVisible = false;
            this.AccountDetailsDataGridView.RowTemplate.Height = 48;
            this.AccountDetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AccountDetailsDataGridView.Size = new System.Drawing.Size(1024, 400);
            this.AccountDetailsDataGridView.TabIndex = 2;
            this.AccountDetailsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountDetailsDataGridView_CellDoubleClick);
            // 
            // AccountStatisticsPanel
            // 
            this.AccountStatisticsPanel.BackColor = System.Drawing.Color.White;
            this.AccountStatisticsPanel.Controls.Add(this.AccountSalesPanel3);
            this.AccountStatisticsPanel.Controls.Add(this.AccountSalesPanel2);
            this.AccountStatisticsPanel.Controls.Add(this.AccountSalesPanel);
            this.AccountStatisticsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountStatisticsPanel.Location = new System.Drawing.Point(0, 50);
            this.AccountStatisticsPanel.Name = "AccountStatisticsPanel";
            this.AccountStatisticsPanel.Size = new System.Drawing.Size(1024, 150);
            this.AccountStatisticsPanel.TabIndex = 1;
            // 
            // AccountSalesPanel3
            // 
            this.AccountSalesPanel3.Controls.Add(this.ReceiptWithMistakePanel);
            this.AccountSalesPanel3.Controls.Add(this.AchievementPanel);
            this.AccountSalesPanel3.Controls.Add(this.CashWithWorkingCapitalPanel);
            this.AccountSalesPanel3.Controls.Add(this.CashPanel);
            this.AccountSalesPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountSalesPanel3.Location = new System.Drawing.Point(0, 100);
            this.AccountSalesPanel3.Name = "AccountSalesPanel3";
            this.AccountSalesPanel3.Size = new System.Drawing.Size(1024, 50);
            this.AccountSalesPanel3.TabIndex = 2;
            // 
            // ReceiptWithMistakePanel
            // 
            this.ReceiptWithMistakePanel.Controls.Add(this.ReceiptWithMistakeTextBox);
            this.ReceiptWithMistakePanel.Controls.Add(this.ReceiptWithMistakeButton);
            this.ReceiptWithMistakePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReceiptWithMistakePanel.Location = new System.Drawing.Point(768, 0);
            this.ReceiptWithMistakePanel.Name = "ReceiptWithMistakePanel";
            this.ReceiptWithMistakePanel.Size = new System.Drawing.Size(256, 50);
            this.ReceiptWithMistakePanel.TabIndex = 7;
            // 
            // ReceiptWithMistakeTextBox
            // 
            this.ReceiptWithMistakeTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ReceiptWithMistakeTextBox.Location = new System.Drawing.Point(81, 7);
            this.ReceiptWithMistakeTextBox.Name = "ReceiptWithMistakeTextBox";
            this.ReceiptWithMistakeTextBox.ReadOnly = true;
            this.ReceiptWithMistakeTextBox.Size = new System.Drawing.Size(169, 35);
            this.ReceiptWithMistakeTextBox.TabIndex = 1;
            // 
            // ReceiptWithMistakeButton
            // 
            this.ReceiptWithMistakeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReceiptWithMistakeButton.FlatAppearance.BorderSize = 0;
            this.ReceiptWithMistakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReceiptWithMistakeButton.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ReceiptWithMistakeButton.Location = new System.Drawing.Point(0, 0);
            this.ReceiptWithMistakeButton.Name = "ReceiptWithMistakeButton";
            this.ReceiptWithMistakeButton.Size = new System.Drawing.Size(75, 50);
            this.ReceiptWithMistakeButton.TabIndex = 0;
            this.ReceiptWithMistakeButton.TabStop = false;
            this.ReceiptWithMistakeButton.Text = "發票含誤打";
            this.ReceiptWithMistakeButton.UseVisualStyleBackColor = true;
            // 
            // AchievementPanel
            // 
            this.AchievementPanel.Controls.Add(this.AchievementTextBox);
            this.AchievementPanel.Controls.Add(this.AchievementButton);
            this.AchievementPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AchievementPanel.Location = new System.Drawing.Point(512, 0);
            this.AchievementPanel.Name = "AchievementPanel";
            this.AchievementPanel.Size = new System.Drawing.Size(256, 50);
            this.AchievementPanel.TabIndex = 6;
            // 
            // AchievementTextBox
            // 
            this.AchievementTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AchievementTextBox.Location = new System.Drawing.Point(81, 7);
            this.AchievementTextBox.Name = "AchievementTextBox";
            this.AchievementTextBox.ReadOnly = true;
            this.AchievementTextBox.Size = new System.Drawing.Size(169, 35);
            this.AchievementTextBox.TabIndex = 1;
            // 
            // AchievementButton
            // 
            this.AchievementButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AchievementButton.FlatAppearance.BorderSize = 0;
            this.AchievementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AchievementButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AchievementButton.Location = new System.Drawing.Point(0, 0);
            this.AchievementButton.Name = "AchievementButton";
            this.AchievementButton.Size = new System.Drawing.Size(75, 50);
            this.AchievementButton.TabIndex = 0;
            this.AchievementButton.TabStop = false;
            this.AchievementButton.Text = "總業績";
            this.AchievementButton.UseVisualStyleBackColor = true;
            // 
            // CashWithWorkingCapitalPanel
            // 
            this.CashWithWorkingCapitalPanel.Controls.Add(this.CashWithWorkingCapitalTextBox);
            this.CashWithWorkingCapitalPanel.Controls.Add(this.CashWithWorkingCapitalButton);
            this.CashWithWorkingCapitalPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CashWithWorkingCapitalPanel.Location = new System.Drawing.Point(256, 0);
            this.CashWithWorkingCapitalPanel.Name = "CashWithWorkingCapitalPanel";
            this.CashWithWorkingCapitalPanel.Size = new System.Drawing.Size(256, 50);
            this.CashWithWorkingCapitalPanel.TabIndex = 5;
            // 
            // CashWithWorkingCapitalTextBox
            // 
            this.CashWithWorkingCapitalTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CashWithWorkingCapitalTextBox.Location = new System.Drawing.Point(81, 7);
            this.CashWithWorkingCapitalTextBox.Name = "CashWithWorkingCapitalTextBox";
            this.CashWithWorkingCapitalTextBox.ReadOnly = true;
            this.CashWithWorkingCapitalTextBox.Size = new System.Drawing.Size(169, 35);
            this.CashWithWorkingCapitalTextBox.TabIndex = 1;
            // 
            // CashWithWorkingCapitalButton
            // 
            this.CashWithWorkingCapitalButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CashWithWorkingCapitalButton.FlatAppearance.BorderSize = 0;
            this.CashWithWorkingCapitalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashWithWorkingCapitalButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CashWithWorkingCapitalButton.Location = new System.Drawing.Point(0, 0);
            this.CashWithWorkingCapitalButton.Name = "CashWithWorkingCapitalButton";
            this.CashWithWorkingCapitalButton.Size = new System.Drawing.Size(75, 50);
            this.CashWithWorkingCapitalButton.TabIndex = 0;
            this.CashWithWorkingCapitalButton.TabStop = false;
            this.CashWithWorkingCapitalButton.Text = "總現金含周轉金";
            this.CashWithWorkingCapitalButton.UseVisualStyleBackColor = true;
            // 
            // CashPanel
            // 
            this.CashPanel.Controls.Add(this.AccountSalesCashTextBox);
            this.CashPanel.Controls.Add(this.CashButton);
            this.CashPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CashPanel.Location = new System.Drawing.Point(0, 0);
            this.CashPanel.Name = "CashPanel";
            this.CashPanel.Size = new System.Drawing.Size(256, 50);
            this.CashPanel.TabIndex = 4;
            // 
            // AccountSalesCashTextBox
            // 
            this.AccountSalesCashTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountSalesCashTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountSalesCashTextBox.Name = "AccountSalesCashTextBox";
            this.AccountSalesCashTextBox.ReadOnly = true;
            this.AccountSalesCashTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountSalesCashTextBox.TabIndex = 1;
            // 
            // CashButton
            // 
            this.CashButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CashButton.FlatAppearance.BorderSize = 0;
            this.CashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CashButton.Location = new System.Drawing.Point(0, 0);
            this.CashButton.Name = "CashButton";
            this.CashButton.Size = new System.Drawing.Size(75, 50);
            this.CashButton.TabIndex = 0;
            this.CashButton.TabStop = false;
            this.CashButton.Text = "總現金";
            this.CashButton.UseVisualStyleBackColor = true;
            // 
            // AccountSalesPanel2
            // 
            this.AccountSalesPanel2.Controls.Add(this.MistakePanel3);
            this.AccountSalesPanel2.Controls.Add(this.MistakePanel2);
            this.AccountSalesPanel2.Controls.Add(this.MistakePanel);
            this.AccountSalesPanel2.Controls.Add(this.WorkingCapitalPanel);
            this.AccountSalesPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountSalesPanel2.Location = new System.Drawing.Point(0, 50);
            this.AccountSalesPanel2.Name = "AccountSalesPanel2";
            this.AccountSalesPanel2.Size = new System.Drawing.Size(1024, 50);
            this.AccountSalesPanel2.TabIndex = 1;
            // 
            // MistakePanel3
            // 
            this.MistakePanel3.Controls.Add(this.MistakeTextBox3);
            this.MistakePanel3.Controls.Add(this.MistakeButton3);
            this.MistakePanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.MistakePanel3.Location = new System.Drawing.Point(768, 0);
            this.MistakePanel3.Name = "MistakePanel3";
            this.MistakePanel3.Size = new System.Drawing.Size(256, 50);
            this.MistakePanel3.TabIndex = 4;
            // 
            // MistakeTextBox3
            // 
            this.MistakeTextBox3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MistakeTextBox3.Location = new System.Drawing.Point(81, 7);
            this.MistakeTextBox3.Name = "MistakeTextBox3";
            this.MistakeTextBox3.Size = new System.Drawing.Size(169, 35);
            this.MistakeTextBox3.TabIndex = 2;
            this.MistakeTextBox3.TextChanged += new System.EventHandler(this.MistakeTextBox3_TextChanged);
            // 
            // MistakeButton3
            // 
            this.MistakeButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.MistakeButton3.FlatAppearance.BorderSize = 0;
            this.MistakeButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MistakeButton3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MistakeButton3.Location = new System.Drawing.Point(0, 0);
            this.MistakeButton3.Name = "MistakeButton3";
            this.MistakeButton3.Size = new System.Drawing.Size(75, 50);
            this.MistakeButton3.TabIndex = 0;
            this.MistakeButton3.TabStop = false;
            this.MistakeButton3.Text = "誤打";
            this.MistakeButton3.UseVisualStyleBackColor = true;
            // 
            // MistakePanel2
            // 
            this.MistakePanel2.Controls.Add(this.MistakeTextBox2);
            this.MistakePanel2.Controls.Add(this.MistakeButton2);
            this.MistakePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.MistakePanel2.Location = new System.Drawing.Point(512, 0);
            this.MistakePanel2.Name = "MistakePanel2";
            this.MistakePanel2.Size = new System.Drawing.Size(256, 50);
            this.MistakePanel2.TabIndex = 3;
            // 
            // MistakeTextBox2
            // 
            this.MistakeTextBox2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MistakeTextBox2.Location = new System.Drawing.Point(81, 7);
            this.MistakeTextBox2.Name = "MistakeTextBox2";
            this.MistakeTextBox2.Size = new System.Drawing.Size(169, 35);
            this.MistakeTextBox2.TabIndex = 2;
            this.MistakeTextBox2.TextChanged += new System.EventHandler(this.MistakeTextBox2_TextChanged);
            // 
            // MistakeButton2
            // 
            this.MistakeButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.MistakeButton2.FlatAppearance.BorderSize = 0;
            this.MistakeButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MistakeButton2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MistakeButton2.Location = new System.Drawing.Point(0, 0);
            this.MistakeButton2.Name = "MistakeButton2";
            this.MistakeButton2.Size = new System.Drawing.Size(75, 50);
            this.MistakeButton2.TabIndex = 0;
            this.MistakeButton2.TabStop = false;
            this.MistakeButton2.Text = "誤打";
            this.MistakeButton2.UseVisualStyleBackColor = true;
            // 
            // MistakePanel
            // 
            this.MistakePanel.Controls.Add(this.MistakeTextBox);
            this.MistakePanel.Controls.Add(this.MistakeButton);
            this.MistakePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MistakePanel.Location = new System.Drawing.Point(256, 0);
            this.MistakePanel.Name = "MistakePanel";
            this.MistakePanel.Size = new System.Drawing.Size(256, 50);
            this.MistakePanel.TabIndex = 2;
            // 
            // MistakeTextBox
            // 
            this.MistakeTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MistakeTextBox.Location = new System.Drawing.Point(81, 7);
            this.MistakeTextBox.Name = "MistakeTextBox";
            this.MistakeTextBox.Size = new System.Drawing.Size(169, 35);
            this.MistakeTextBox.TabIndex = 2;
            this.MistakeTextBox.TextChanged += new System.EventHandler(this.MistakeTextBox_TextChanged);
            // 
            // MistakeButton
            // 
            this.MistakeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MistakeButton.FlatAppearance.BorderSize = 0;
            this.MistakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MistakeButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MistakeButton.Location = new System.Drawing.Point(0, 0);
            this.MistakeButton.Name = "MistakeButton";
            this.MistakeButton.Size = new System.Drawing.Size(75, 50);
            this.MistakeButton.TabIndex = 0;
            this.MistakeButton.TabStop = false;
            this.MistakeButton.Text = "誤打";
            this.MistakeButton.UseVisualStyleBackColor = true;
            // 
            // WorkingCapitalPanel
            // 
            this.WorkingCapitalPanel.Controls.Add(this.WorkingCapitalTextBox);
            this.WorkingCapitalPanel.Controls.Add(this.WorkingCapitalButton);
            this.WorkingCapitalPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.WorkingCapitalPanel.Location = new System.Drawing.Point(0, 0);
            this.WorkingCapitalPanel.Name = "WorkingCapitalPanel";
            this.WorkingCapitalPanel.Size = new System.Drawing.Size(256, 50);
            this.WorkingCapitalPanel.TabIndex = 1;
            // 
            // WorkingCapitalTextBox
            // 
            this.WorkingCapitalTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WorkingCapitalTextBox.Location = new System.Drawing.Point(81, 7);
            this.WorkingCapitalTextBox.Name = "WorkingCapitalTextBox";
            this.WorkingCapitalTextBox.Size = new System.Drawing.Size(169, 35);
            this.WorkingCapitalTextBox.TabIndex = 1;
            this.WorkingCapitalTextBox.TextChanged += new System.EventHandler(this.WorkingCapitalTextBox_TextChanged);
            // 
            // WorkingCapitalButton
            // 
            this.WorkingCapitalButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.WorkingCapitalButton.FlatAppearance.BorderSize = 0;
            this.WorkingCapitalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkingCapitalButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WorkingCapitalButton.Location = new System.Drawing.Point(0, 0);
            this.WorkingCapitalButton.Name = "WorkingCapitalButton";
            this.WorkingCapitalButton.Size = new System.Drawing.Size(75, 50);
            this.WorkingCapitalButton.TabIndex = 0;
            this.WorkingCapitalButton.TabStop = false;
            this.WorkingCapitalButton.Text = "週轉金";
            this.WorkingCapitalButton.UseVisualStyleBackColor = true;
            // 
            // AccountSalesPanel
            // 
            this.AccountSalesPanel.Controls.Add(this.AccountSalesDeliveryPanel);
            this.AccountSalesPanel.Controls.Add(this.AccountSalesCreditCardPanel);
            this.AccountSalesPanel.Controls.Add(this.AccountSalesNoReceiptPanel);
            this.AccountSalesPanel.Controls.Add(this.AccountSalesReceiptPanel);
            this.AccountSalesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountSalesPanel.Location = new System.Drawing.Point(0, 0);
            this.AccountSalesPanel.Name = "AccountSalesPanel";
            this.AccountSalesPanel.Size = new System.Drawing.Size(1024, 50);
            this.AccountSalesPanel.TabIndex = 0;
            // 
            // AccountSalesDeliveryPanel
            // 
            this.AccountSalesDeliveryPanel.Controls.Add(this.AccountSalesDeliveryTextBox);
            this.AccountSalesDeliveryPanel.Controls.Add(this.AccountSalesDeliveryButton);
            this.AccountSalesDeliveryPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountSalesDeliveryPanel.Location = new System.Drawing.Point(768, 0);
            this.AccountSalesDeliveryPanel.Name = "AccountSalesDeliveryPanel";
            this.AccountSalesDeliveryPanel.Size = new System.Drawing.Size(256, 50);
            this.AccountSalesDeliveryPanel.TabIndex = 5;
            // 
            // AccountSalesDeliveryTextBox
            // 
            this.AccountSalesDeliveryTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountSalesDeliveryTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountSalesDeliveryTextBox.Name = "AccountSalesDeliveryTextBox";
            this.AccountSalesDeliveryTextBox.ReadOnly = true;
            this.AccountSalesDeliveryTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountSalesDeliveryTextBox.TabIndex = 2;
            // 
            // AccountSalesDeliveryButton
            // 
            this.AccountSalesDeliveryButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountSalesDeliveryButton.FlatAppearance.BorderSize = 0;
            this.AccountSalesDeliveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountSalesDeliveryButton.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountSalesDeliveryButton.Location = new System.Drawing.Point(0, 0);
            this.AccountSalesDeliveryButton.Name = "AccountSalesDeliveryButton";
            this.AccountSalesDeliveryButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.AccountSalesDeliveryButton.Size = new System.Drawing.Size(75, 50);
            this.AccountSalesDeliveryButton.TabIndex = 1;
            this.AccountSalesDeliveryButton.TabStop = false;
            this.AccountSalesDeliveryButton.Text = "貨到付款";
            this.AccountSalesDeliveryButton.UseVisualStyleBackColor = true;
            // 
            // AccountSalesCreditCardPanel
            // 
            this.AccountSalesCreditCardPanel.Controls.Add(this.AccountSalesCreditCardTextBox);
            this.AccountSalesCreditCardPanel.Controls.Add(this.AccountSalesCreditCardButton);
            this.AccountSalesCreditCardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountSalesCreditCardPanel.Location = new System.Drawing.Point(512, 0);
            this.AccountSalesCreditCardPanel.Name = "AccountSalesCreditCardPanel";
            this.AccountSalesCreditCardPanel.Size = new System.Drawing.Size(256, 50);
            this.AccountSalesCreditCardPanel.TabIndex = 2;
            // 
            // AccountSalesCreditCardTextBox
            // 
            this.AccountSalesCreditCardTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountSalesCreditCardTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountSalesCreditCardTextBox.Name = "AccountSalesCreditCardTextBox";
            this.AccountSalesCreditCardTextBox.ReadOnly = true;
            this.AccountSalesCreditCardTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountSalesCreditCardTextBox.TabIndex = 2;
            // 
            // AccountSalesCreditCardButton
            // 
            this.AccountSalesCreditCardButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountSalesCreditCardButton.FlatAppearance.BorderSize = 0;
            this.AccountSalesCreditCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountSalesCreditCardButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountSalesCreditCardButton.Location = new System.Drawing.Point(0, 0);
            this.AccountSalesCreditCardButton.Name = "AccountSalesCreditCardButton";
            this.AccountSalesCreditCardButton.Size = new System.Drawing.Size(75, 50);
            this.AccountSalesCreditCardButton.TabIndex = 1;
            this.AccountSalesCreditCardButton.TabStop = false;
            this.AccountSalesCreditCardButton.Text = "信用卡";
            this.AccountSalesCreditCardButton.UseVisualStyleBackColor = true;
            // 
            // AccountSalesNoReceiptPanel
            // 
            this.AccountSalesNoReceiptPanel.Controls.Add(this.AccountSalesNoReceiptTextBox);
            this.AccountSalesNoReceiptPanel.Controls.Add(this.AccountSalesNoReceiptButton);
            this.AccountSalesNoReceiptPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountSalesNoReceiptPanel.Location = new System.Drawing.Point(256, 0);
            this.AccountSalesNoReceiptPanel.Name = "AccountSalesNoReceiptPanel";
            this.AccountSalesNoReceiptPanel.Size = new System.Drawing.Size(256, 50);
            this.AccountSalesNoReceiptPanel.TabIndex = 1;
            // 
            // AccountSalesNoReceiptTextBox
            // 
            this.AccountSalesNoReceiptTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountSalesNoReceiptTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountSalesNoReceiptTextBox.Name = "AccountSalesNoReceiptTextBox";
            this.AccountSalesNoReceiptTextBox.ReadOnly = true;
            this.AccountSalesNoReceiptTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountSalesNoReceiptTextBox.TabIndex = 2;
            // 
            // AccountSalesNoReceiptButton
            // 
            this.AccountSalesNoReceiptButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountSalesNoReceiptButton.FlatAppearance.BorderSize = 0;
            this.AccountSalesNoReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountSalesNoReceiptButton.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountSalesNoReceiptButton.Location = new System.Drawing.Point(0, 0);
            this.AccountSalesNoReceiptButton.Name = "AccountSalesNoReceiptButton";
            this.AccountSalesNoReceiptButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.AccountSalesNoReceiptButton.Size = new System.Drawing.Size(75, 50);
            this.AccountSalesNoReceiptButton.TabIndex = 1;
            this.AccountSalesNoReceiptButton.TabStop = false;
            this.AccountSalesNoReceiptButton.Text = "未開發票";
            this.AccountSalesNoReceiptButton.UseVisualStyleBackColor = true;
            // 
            // AccountSalesReceiptPanel
            // 
            this.AccountSalesReceiptPanel.Controls.Add(this.AccountSalesReceiptTextBox);
            this.AccountSalesReceiptPanel.Controls.Add(this.AccountSalesReceiptButton);
            this.AccountSalesReceiptPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountSalesReceiptPanel.Location = new System.Drawing.Point(0, 0);
            this.AccountSalesReceiptPanel.Name = "AccountSalesReceiptPanel";
            this.AccountSalesReceiptPanel.Size = new System.Drawing.Size(256, 50);
            this.AccountSalesReceiptPanel.TabIndex = 0;
            // 
            // AccountSalesReceiptTextBox
            // 
            this.AccountSalesReceiptTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountSalesReceiptTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountSalesReceiptTextBox.Name = "AccountSalesReceiptTextBox";
            this.AccountSalesReceiptTextBox.ReadOnly = true;
            this.AccountSalesReceiptTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountSalesReceiptTextBox.TabIndex = 1;
            // 
            // AccountSalesReceiptButton
            // 
            this.AccountSalesReceiptButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountSalesReceiptButton.FlatAppearance.BorderSize = 0;
            this.AccountSalesReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountSalesReceiptButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountSalesReceiptButton.Location = new System.Drawing.Point(0, 0);
            this.AccountSalesReceiptButton.Name = "AccountSalesReceiptButton";
            this.AccountSalesReceiptButton.Size = new System.Drawing.Size(75, 50);
            this.AccountSalesReceiptButton.TabIndex = 0;
            this.AccountSalesReceiptButton.TabStop = false;
            this.AccountSalesReceiptButton.Text = "發票";
            this.AccountSalesReceiptButton.UseVisualStyleBackColor = true;
            // 
            // AccountDatePanel
            // 
            this.AccountDatePanel.BackColor = System.Drawing.Color.White;
            this.AccountDatePanel.Controls.Add(this.AccuontNewTradeButton);
            this.AccountDatePanel.Controls.Add(this.AccountDateTimePicker);
            this.AccountDatePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountDatePanel.Location = new System.Drawing.Point(0, 0);
            this.AccountDatePanel.Name = "AccountDatePanel";
            this.AccountDatePanel.Size = new System.Drawing.Size(1024, 50);
            this.AccountDatePanel.TabIndex = 0;
            // 
            // AccuontNewTradeButton
            // 
            this.AccuontNewTradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccuontNewTradeButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccuontNewTradeButton.Location = new System.Drawing.Point(212, 6);
            this.AccuontNewTradeButton.Name = "AccuontNewTradeButton";
            this.AccuontNewTradeButton.Size = new System.Drawing.Size(150, 35);
            this.AccuontNewTradeButton.TabIndex = 2;
            this.AccuontNewTradeButton.Text = "新增非會員交易";
            this.AccuontNewTradeButton.UseVisualStyleBackColor = true;
            this.AccuontNewTradeButton.Click += new System.EventHandler(this.AccuontNewTradeButton_Click);
            // 
            // AccountDateTimePicker
            // 
            this.AccountDateTimePicker.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountDateTimePicker.Location = new System.Drawing.Point(6, 6);
            this.AccountDateTimePicker.Name = "AccountDateTimePicker";
            this.AccountDateTimePicker.Size = new System.Drawing.Size(200, 35);
            this.AccountDateTimePicker.TabIndex = 1;
            this.AccountDateTimePicker.Value = new System.DateTime(2017, 6, 30, 17, 16, 46, 0);
            this.AccountDateTimePicker.ValueChanged += new System.EventHandler(this.AccountDateTimePicker_ValueChanged);
            // 
            // AccountTableAdapter
            // 
            this.AccountTableAdapter.ClearBeforeFill = true;
            // 
            // TradeTableAdapter
            // 
            this.TradeTableAdapter.ClearBeforeFill = true;
            // 
            // TradeItemTableAdapter
            // 
            this.TradeItemTableAdapter.ClearBeforeFill = true;
            // 
            // AccountDetailsTradeID
            // 
            this.AccountDetailsTradeID.HeaderText = "ID";
            this.AccountDetailsTradeID.Name = "AccountDetailsTradeID";
            this.AccountDetailsTradeID.Visible = false;
            // 
            // AccountDetailsTime
            // 
            this.AccountDetailsTime.HeaderText = "時間";
            this.AccountDetailsTime.Name = "AccountDetailsTime";
            this.AccountDetailsTime.ReadOnly = true;
            // 
            // AccountDetailsMemberName
            // 
            this.AccountDetailsMemberName.HeaderText = "會員";
            this.AccountDetailsMemberName.Name = "AccountDetailsMemberName";
            this.AccountDetailsMemberName.ReadOnly = true;
            // 
            // AccountDetailsPaymentType
            // 
            this.AccountDetailsPaymentType.HeaderText = "付款方式";
            this.AccountDetailsPaymentType.Name = "AccountDetailsPaymentType";
            this.AccountDetailsPaymentType.ReadOnly = true;
            this.AccountDetailsPaymentType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AccountDetailsReceipt
            // 
            this.AccountDetailsReceipt.FillWeight = 50F;
            this.AccountDetailsReceipt.HeaderText = "發票";
            this.AccountDetailsReceipt.Name = "AccountDetailsReceipt";
            this.AccountDetailsReceipt.ReadOnly = true;
            this.AccountDetailsReceipt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AccountDetailsItemName
            // 
            this.AccountDetailsItemName.HeaderText = "商品";
            this.AccountDetailsItemName.Name = "AccountDetailsItemName";
            this.AccountDetailsItemName.ReadOnly = true;
            // 
            // AccountDetailsRoastDegree
            // 
            this.AccountDetailsRoastDegree.FillWeight = 50F;
            this.AccountDetailsRoastDegree.HeaderText = "烘焙";
            this.AccountDetailsRoastDegree.Name = "AccountDetailsRoastDegree";
            this.AccountDetailsRoastDegree.ReadOnly = true;
            // 
            // AccountDetailsItemAmount
            // 
            this.AccountDetailsItemAmount.FillWeight = 50F;
            this.AccountDetailsItemAmount.HeaderText = "數量";
            this.AccountDetailsItemAmount.Name = "AccountDetailsItemAmount";
            this.AccountDetailsItemAmount.ReadOnly = true;
            // 
            // AccountDetailsItemSubtotal
            // 
            this.AccountDetailsItemSubtotal.HeaderText = "小計";
            this.AccountDetailsItemSubtotal.Name = "AccountDetailsItemSubtotal";
            this.AccountDetailsItemSubtotal.ReadOnly = true;
            // 
            // AccountDetailsSubtotal
            // 
            this.AccountDetailsSubtotal.HeaderText = "總額";
            this.AccountDetailsSubtotal.Name = "AccountDetailsSubtotal";
            this.AccountDetailsSubtotal.ReadOnly = true;
            // 
            // AccountDetailsCheck
            // 
            this.AccountDetailsCheck.FillWeight = 50F;
            this.AccountDetailsCheck.HeaderText = "對帳";
            this.AccountDetailsCheck.Name = "AccountDetailsCheck";
            this.AccountDetailsCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountDetailsCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AccountDayUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AccountPanel);
            this.Name = "AccountDayUserControl";
            this.Size = new System.Drawing.Size(1024, 600);
            this.AccountPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountDetailsDataGridView)).EndInit();
            this.AccountStatisticsPanel.ResumeLayout(false);
            this.AccountSalesPanel3.ResumeLayout(false);
            this.ReceiptWithMistakePanel.ResumeLayout(false);
            this.ReceiptWithMistakePanel.PerformLayout();
            this.AchievementPanel.ResumeLayout(false);
            this.AchievementPanel.PerformLayout();
            this.CashWithWorkingCapitalPanel.ResumeLayout(false);
            this.CashWithWorkingCapitalPanel.PerformLayout();
            this.CashPanel.ResumeLayout(false);
            this.CashPanel.PerformLayout();
            this.AccountSalesPanel2.ResumeLayout(false);
            this.MistakePanel3.ResumeLayout(false);
            this.MistakePanel3.PerformLayout();
            this.MistakePanel2.ResumeLayout(false);
            this.MistakePanel2.PerformLayout();
            this.MistakePanel.ResumeLayout(false);
            this.MistakePanel.PerformLayout();
            this.WorkingCapitalPanel.ResumeLayout(false);
            this.WorkingCapitalPanel.PerformLayout();
            this.AccountSalesPanel.ResumeLayout(false);
            this.AccountSalesDeliveryPanel.ResumeLayout(false);
            this.AccountSalesDeliveryPanel.PerformLayout();
            this.AccountSalesCreditCardPanel.ResumeLayout(false);
            this.AccountSalesCreditCardPanel.PerformLayout();
            this.AccountSalesNoReceiptPanel.ResumeLayout(false);
            this.AccountSalesNoReceiptPanel.PerformLayout();
            this.AccountSalesReceiptPanel.ResumeLayout(false);
            this.AccountSalesReceiptPanel.PerformLayout();
            this.AccountDatePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AccountPanel;
        private System.Windows.Forms.DataGridView AccountDetailsDataGridView;
        private System.Windows.Forms.Panel AccountStatisticsPanel;
        private System.Windows.Forms.Panel AccountSalesPanel3;
        private System.Windows.Forms.Panel ReceiptWithMistakePanel;
        private System.Windows.Forms.TextBox ReceiptWithMistakeTextBox;
        private System.Windows.Forms.Button ReceiptWithMistakeButton;
        private System.Windows.Forms.Panel AchievementPanel;
        private System.Windows.Forms.TextBox AchievementTextBox;
        private System.Windows.Forms.Button AchievementButton;
        private System.Windows.Forms.Panel CashWithWorkingCapitalPanel;
        private System.Windows.Forms.TextBox CashWithWorkingCapitalTextBox;
        private System.Windows.Forms.Button CashWithWorkingCapitalButton;
        private System.Windows.Forms.Panel CashPanel;
        private System.Windows.Forms.TextBox AccountSalesCashTextBox;
        private System.Windows.Forms.Button CashButton;
        private System.Windows.Forms.Panel AccountSalesPanel2;
        private System.Windows.Forms.Panel MistakePanel3;
        private System.Windows.Forms.TextBox MistakeTextBox3;
        private System.Windows.Forms.Button MistakeButton3;
        private System.Windows.Forms.Panel MistakePanel2;
        private System.Windows.Forms.TextBox MistakeTextBox2;
        private System.Windows.Forms.Button MistakeButton2;
        private System.Windows.Forms.Panel MistakePanel;
        private System.Windows.Forms.TextBox MistakeTextBox;
        private System.Windows.Forms.Button MistakeButton;
        private System.Windows.Forms.Panel WorkingCapitalPanel;
        private System.Windows.Forms.TextBox WorkingCapitalTextBox;
        private System.Windows.Forms.Button WorkingCapitalButton;
        private System.Windows.Forms.Panel AccountSalesPanel;
        private System.Windows.Forms.Panel AccountSalesDeliveryPanel;
        private System.Windows.Forms.TextBox AccountSalesDeliveryTextBox;
        private System.Windows.Forms.Button AccountSalesDeliveryButton;
        private System.Windows.Forms.Panel AccountSalesCreditCardPanel;
        private System.Windows.Forms.TextBox AccountSalesCreditCardTextBox;
        private System.Windows.Forms.Button AccountSalesCreditCardButton;
        private System.Windows.Forms.Panel AccountSalesNoReceiptPanel;
        private System.Windows.Forms.TextBox AccountSalesNoReceiptTextBox;
        private System.Windows.Forms.Button AccountSalesNoReceiptButton;
        private System.Windows.Forms.Panel AccountSalesReceiptPanel;
        private System.Windows.Forms.TextBox AccountSalesReceiptTextBox;
        private System.Windows.Forms.Button AccountSalesReceiptButton;
        private System.Windows.Forms.Panel AccountDatePanel;
        private System.Windows.Forms.Button AccuontNewTradeButton;
        private System.Windows.Forms.DateTimePicker AccountDateTimePicker;
        private CoffeeHomeDataSetTableAdapters.AccountTableAdapter AccountTableAdapter;
        private CoffeeHomeDataSetTableAdapters.TradeTableAdapter TradeTableAdapter;
        private CoffeeHomeDataSetTableAdapters.TradeItemTableAdapter TradeItemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDetailsTradeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDetailsTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDetailsMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDetailsPaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDetailsReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDetailsItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDetailsRoastDegree;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDetailsItemAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDetailsItemSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountDetailsSubtotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AccountDetailsCheck;
    }
}
