namespace CoffeeHome
{
    partial class MainForm
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.ItemButton = new System.Windows.Forms.Button();
            this.MemberButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.MemberHeaderPanel = new System.Windows.Forms.Panel();
            this.MemberNewButton = new System.Windows.Forms.Button();
            this.MemberSearchButton = new System.Windows.Forms.Button();
            this.MemberBackButton = new System.Windows.Forms.Button();
            this.MemberNewTradeButton = new System.Windows.Forms.Button();
            this.MemberEditButton = new System.Windows.Forms.Button();
            this.MemberDeleteButton = new System.Windows.Forms.Button();
            this.HomeHeaderPanel = new System.Windows.Forms.Panel();
            this.SettingLabel = new System.Windows.Forms.Label();
            this.NonMemberTradeButton = new System.Windows.Forms.Button();
            this.AccountHeaderPanel = new System.Windows.Forms.Panel();
            this.AccountYearButton = new System.Windows.Forms.Button();
            this.AccountMonthButton = new System.Windows.Forms.Button();
            this.AccountDayButton = new System.Windows.Forms.Button();
            this.ItemHeaderPanel = new System.Windows.Forms.Panel();
            this.ItemEditTypeButton = new System.Windows.Forms.Button();
            this.ItemAddToShelfButton = new System.Windows.Forms.Button();
            this.ItemRemoveFromShelfButton = new System.Windows.Forms.Button();
            this.ItemDeleteButton = new System.Windows.Forms.Button();
            this.ItemNewButton = new System.Windows.Forms.Button();
            this.ItemSearchButton = new System.Windows.Forms.Button();
            this.ItemListButton = new System.Windows.Forms.Button();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.HomeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MemberDetailsPanel = new System.Windows.Forms.Panel();
            this.MemberListPanel = new System.Windows.Forms.Panel();
            this.MemberListDataGridView = new System.Windows.Forms.DataGridView();
            this.MemberIDDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberNameDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberSexDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberZipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MamberAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CoffeeHomeDataSet = new CoffeeHome.CoffeeHomeDataSet();
            this.SexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemPanel = new System.Windows.Forms.Panel();
            this.ItemDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemIDDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNameDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemTypeIDDataGridViewTextBox = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ItemPriceDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemRemarksDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemShelfDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemShelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MemberTableAdapter = new CoffeeHome.CoffeeHomeDataSetTableAdapters.MemberTableAdapter();
            this.TableAdapterManager = new CoffeeHome.CoffeeHomeDataSetTableAdapters.TableAdapterManager();
            this.ItemShelfTableAdapter = new CoffeeHome.CoffeeHomeDataSetTableAdapters.ItemShelfTableAdapter();
            this.ItemTableAdapter = new CoffeeHome.CoffeeHomeDataSetTableAdapters.ItemTableAdapter();
            this.ItemTypeTableAdapter = new CoffeeHome.CoffeeHomeDataSetTableAdapters.ItemTypeTableAdapter();
            this.PaymentTypeTableAdapter = new CoffeeHome.CoffeeHomeDataSetTableAdapters.PaymentTypeTableAdapter();
            this.SexTableAdapter = new CoffeeHome.CoffeeHomeDataSetTableAdapters.SexTableAdapter();
            this.TradeItemTableAdapter = new CoffeeHome.CoffeeHomeDataSetTableAdapters.TradeItemTableAdapter();
            this.TradeTableAdapter = new CoffeeHome.CoffeeHomeDataSetTableAdapters.TradeTableAdapter();
            this.ItemTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TradeItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccountTableAdapter = new CoffeeHome.CoffeeHomeDataSetTableAdapters.AccountTableAdapter();
            this.RoastDegreeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RoastDegreeTableAdapter = new CoffeeHome.CoffeeHomeDataSetTableAdapters.RoastDegreeTableAdapter();
            this.IdleTimer = new System.Windows.Forms.Timer(this.components);
            this.AccountDayUserControl = new CoffeeHome.AccountDayUserControl();
            this.AccountMonthUserControl = new CoffeeHome.AccountMonthUserControl();
            this.AccountYearUserControl = new CoffeeHome.AccountYearUserControl();
            this.SidePanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.MemberHeaderPanel.SuspendLayout();
            this.HomeHeaderPanel.SuspendLayout();
            this.AccountHeaderPanel.SuspendLayout();
            this.ItemHeaderPanel.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.MemberListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeHomeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexBindingSource)).BeginInit();
            this.ItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemShelfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoastDegreeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.SidePanel.Controls.Add(this.AccountLabel);
            this.SidePanel.Controls.Add(this.ItemButton);
            this.SidePanel.Controls.Add(this.MemberButton);
            this.SidePanel.Controls.Add(this.HomeButton);
            this.SidePanel.Controls.Add(this.LogoPanel);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(240, 681);
            this.SidePanel.TabIndex = 0;
            // 
            // AccountLabel
            // 
            this.AccountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.AccountLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountLabel.Location = new System.Drawing.Point(0, 255);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(240, 53);
            this.AccountLabel.TabIndex = 11;
            this.AccountLabel.Text = "銷售統計";
            this.AccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AccountLabel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AccountLabel_MouseDoubleClick);
            this.AccountLabel.MouseEnter += new System.EventHandler(this.AccountLabel_MouseEnter);
            this.AccountLabel.MouseLeave += new System.EventHandler(this.AccountLabel_MouseLeave);
            // 
            // ItemButton
            // 
            this.ItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ItemButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemButton.FlatAppearance.BorderSize = 0;
            this.ItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ItemButton.Location = new System.Drawing.Point(0, 202);
            this.ItemButton.Name = "ItemButton";
            this.ItemButton.Size = new System.Drawing.Size(240, 53);
            this.ItemButton.TabIndex = 3;
            this.ItemButton.Text = "商品";
            this.ItemButton.UseVisualStyleBackColor = false;
            this.ItemButton.Click += new System.EventHandler(this.ItemButton_Click);
            // 
            // MemberButton
            // 
            this.MemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.MemberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MemberButton.FlatAppearance.BorderSize = 0;
            this.MemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberButton.Location = new System.Drawing.Point(0, 149);
            this.MemberButton.Name = "MemberButton";
            this.MemberButton.Size = new System.Drawing.Size(240, 53);
            this.MemberButton.TabIndex = 2;
            this.MemberButton.Text = "會員";
            this.MemberButton.UseVisualStyleBackColor = false;
            this.MemberButton.Click += new System.EventHandler(this.MemberButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.White;
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HomeButton.Location = new System.Drawing.Point(0, 96);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(240, 53);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "主頁";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.LogoPicture);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(240, 96);
            this.LogoPanel.TabIndex = 0;
            // 
            // LogoPicture
            // 
            this.LogoPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicture.Image")));
            this.LogoPicture.Location = new System.Drawing.Point(0, 0);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(240, 96);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicture.TabIndex = 0;
            this.LogoPicture.TabStop = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.HeaderPanel.Controls.Add(this.MemberHeaderPanel);
            this.HeaderPanel.Controls.Add(this.HomeHeaderPanel);
            this.HeaderPanel.Controls.Add(this.AccountHeaderPanel);
            this.HeaderPanel.Controls.Add(this.ItemHeaderPanel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(240, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1024, 80);
            this.HeaderPanel.TabIndex = 1;
            // 
            // MemberHeaderPanel
            // 
            this.MemberHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
            this.MemberHeaderPanel.Controls.Add(this.MemberNewButton);
            this.MemberHeaderPanel.Controls.Add(this.MemberSearchButton);
            this.MemberHeaderPanel.Controls.Add(this.MemberBackButton);
            this.MemberHeaderPanel.Controls.Add(this.MemberNewTradeButton);
            this.MemberHeaderPanel.Controls.Add(this.MemberEditButton);
            this.MemberHeaderPanel.Controls.Add(this.MemberDeleteButton);
            this.MemberHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.MemberHeaderPanel.Name = "MemberHeaderPanel";
            this.MemberHeaderPanel.Size = new System.Drawing.Size(1024, 80);
            this.MemberHeaderPanel.TabIndex = 1;
            this.MemberHeaderPanel.Visible = false;
            // 
            // MemberNewButton
            // 
            this.MemberNewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.MemberNewButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MemberNewButton.FlatAppearance.BorderSize = 0;
            this.MemberNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberNewButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberNewButton.Location = new System.Drawing.Point(120, 0);
            this.MemberNewButton.Name = "MemberNewButton";
            this.MemberNewButton.Size = new System.Drawing.Size(96, 80);
            this.MemberNewButton.TabIndex = 5;
            this.MemberNewButton.Text = "新增會員";
            this.MemberNewButton.UseVisualStyleBackColor = false;
            this.MemberNewButton.Click += new System.EventHandler(this.MemberNewButton_Click);
            // 
            // MemberSearchButton
            // 
            this.MemberSearchButton.BackColor = System.Drawing.Color.White;
            this.MemberSearchButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MemberSearchButton.FlatAppearance.BorderSize = 0;
            this.MemberSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberSearchButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberSearchButton.Location = new System.Drawing.Point(24, 0);
            this.MemberSearchButton.Name = "MemberSearchButton";
            this.MemberSearchButton.Size = new System.Drawing.Size(96, 80);
            this.MemberSearchButton.TabIndex = 1;
            this.MemberSearchButton.Text = "搜尋會員";
            this.MemberSearchButton.UseVisualStyleBackColor = false;
            this.MemberSearchButton.Click += new System.EventHandler(this.MemberSearchButton_Click);
            // 
            // MemberBackButton
            // 
            this.MemberBackButton.BackColor = System.Drawing.Color.White;
            this.MemberBackButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MemberBackButton.FlatAppearance.BorderSize = 0;
            this.MemberBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberBackButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberBackButton.Location = new System.Drawing.Point(0, 0);
            this.MemberBackButton.Name = "MemberBackButton";
            this.MemberBackButton.Size = new System.Drawing.Size(24, 80);
            this.MemberBackButton.TabIndex = 7;
            this.MemberBackButton.Text = "＜";
            this.MemberBackButton.UseVisualStyleBackColor = false;
            this.MemberBackButton.Click += new System.EventHandler(this.MemberBackButton_Click);
            // 
            // MemberNewTradeButton
            // 
            this.MemberNewTradeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(179)))));
            this.MemberNewTradeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MemberNewTradeButton.FlatAppearance.BorderSize = 0;
            this.MemberNewTradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberNewTradeButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberNewTradeButton.Location = new System.Drawing.Point(736, 0);
            this.MemberNewTradeButton.Name = "MemberNewTradeButton";
            this.MemberNewTradeButton.Size = new System.Drawing.Size(96, 80);
            this.MemberNewTradeButton.TabIndex = 2;
            this.MemberNewTradeButton.Text = "新增交易";
            this.MemberNewTradeButton.UseVisualStyleBackColor = false;
            this.MemberNewTradeButton.Click += new System.EventHandler(this.MemberNewTradeButton_Click);
            // 
            // MemberEditButton
            // 
            this.MemberEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.MemberEditButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MemberEditButton.FlatAppearance.BorderSize = 0;
            this.MemberEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberEditButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberEditButton.Location = new System.Drawing.Point(832, 0);
            this.MemberEditButton.Name = "MemberEditButton";
            this.MemberEditButton.Size = new System.Drawing.Size(96, 80);
            this.MemberEditButton.TabIndex = 3;
            this.MemberEditButton.Text = "編輯會員";
            this.MemberEditButton.UseVisualStyleBackColor = false;
            this.MemberEditButton.Click += new System.EventHandler(this.MemberEditButton_Click);
            // 
            // MemberDeleteButton
            // 
            this.MemberDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(128)))));
            this.MemberDeleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MemberDeleteButton.FlatAppearance.BorderSize = 0;
            this.MemberDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberDeleteButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberDeleteButton.Location = new System.Drawing.Point(928, 0);
            this.MemberDeleteButton.Name = "MemberDeleteButton";
            this.MemberDeleteButton.Size = new System.Drawing.Size(96, 80);
            this.MemberDeleteButton.TabIndex = 6;
            this.MemberDeleteButton.Text = "刪除會員";
            this.MemberDeleteButton.UseVisualStyleBackColor = false;
            this.MemberDeleteButton.Click += new System.EventHandler(this.MemberDeleteButton_Click);
            // 
            // HomeHeaderPanel
            // 
            this.HomeHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
            this.HomeHeaderPanel.Controls.Add(this.SettingLabel);
            this.HomeHeaderPanel.Controls.Add(this.NonMemberTradeButton);
            this.HomeHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HomeHeaderPanel.Name = "HomeHeaderPanel";
            this.HomeHeaderPanel.Size = new System.Drawing.Size(1024, 80);
            this.HomeHeaderPanel.TabIndex = 0;
            // 
            // SettingLabel
            // 
            this.SettingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.SettingLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SettingLabel.Location = new System.Drawing.Point(114, 0);
            this.SettingLabel.Name = "SettingLabel";
            this.SettingLabel.Size = new System.Drawing.Size(100, 80);
            this.SettingLabel.TabIndex = 10;
            this.SettingLabel.Text = "設定";
            this.SettingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingLabel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SettingLabel_MouseDoubleClick);
            this.SettingLabel.MouseEnter += new System.EventHandler(this.SettingLabel_MouseEnter);
            this.SettingLabel.MouseLeave += new System.EventHandler(this.SettingLabel_MouseLeave);
            // 
            // NonMemberTradeButton
            // 
            this.NonMemberTradeButton.BackColor = System.Drawing.Color.White;
            this.NonMemberTradeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.NonMemberTradeButton.FlatAppearance.BorderSize = 0;
            this.NonMemberTradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NonMemberTradeButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NonMemberTradeButton.Location = new System.Drawing.Point(0, 0);
            this.NonMemberTradeButton.Name = "NonMemberTradeButton";
            this.NonMemberTradeButton.Size = new System.Drawing.Size(114, 80);
            this.NonMemberTradeButton.TabIndex = 1;
            this.NonMemberTradeButton.Text = "新增非會員交易";
            this.NonMemberTradeButton.UseVisualStyleBackColor = false;
            this.NonMemberTradeButton.Click += new System.EventHandler(this.NonMemberTradeButton_Click);
            // 
            // AccountHeaderPanel
            // 
            this.AccountHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(179)))));
            this.AccountHeaderPanel.Controls.Add(this.AccountYearButton);
            this.AccountHeaderPanel.Controls.Add(this.AccountMonthButton);
            this.AccountHeaderPanel.Controls.Add(this.AccountDayButton);
            this.AccountHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.AccountHeaderPanel.Name = "AccountHeaderPanel";
            this.AccountHeaderPanel.Size = new System.Drawing.Size(1024, 80);
            this.AccountHeaderPanel.TabIndex = 1;
            this.AccountHeaderPanel.Visible = false;
            // 
            // AccountYearButton
            // 
            this.AccountYearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
            this.AccountYearButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountYearButton.FlatAppearance.BorderSize = 0;
            this.AccountYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountYearButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountYearButton.Location = new System.Drawing.Point(192, 0);
            this.AccountYearButton.Name = "AccountYearButton";
            this.AccountYearButton.Size = new System.Drawing.Size(96, 80);
            this.AccountYearButton.TabIndex = 2;
            this.AccountYearButton.Text = "年統計";
            this.AccountYearButton.UseVisualStyleBackColor = false;
            this.AccountYearButton.Click += new System.EventHandler(this.AccountYearButton_Click);
            // 
            // AccountMonthButton
            // 
            this.AccountMonthButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.AccountMonthButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountMonthButton.FlatAppearance.BorderSize = 0;
            this.AccountMonthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountMonthButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountMonthButton.Location = new System.Drawing.Point(96, 0);
            this.AccountMonthButton.Name = "AccountMonthButton";
            this.AccountMonthButton.Size = new System.Drawing.Size(96, 80);
            this.AccountMonthButton.TabIndex = 1;
            this.AccountMonthButton.Text = "月統計";
            this.AccountMonthButton.UseVisualStyleBackColor = false;
            this.AccountMonthButton.Click += new System.EventHandler(this.AccountMonthButton_Click);
            // 
            // AccountDayButton
            // 
            this.AccountDayButton.BackColor = System.Drawing.Color.White;
            this.AccountDayButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountDayButton.FlatAppearance.BorderSize = 0;
            this.AccountDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountDayButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountDayButton.Location = new System.Drawing.Point(0, 0);
            this.AccountDayButton.Name = "AccountDayButton";
            this.AccountDayButton.Size = new System.Drawing.Size(96, 80);
            this.AccountDayButton.TabIndex = 0;
            this.AccountDayButton.Text = "日統計";
            this.AccountDayButton.UseVisualStyleBackColor = false;
            this.AccountDayButton.Click += new System.EventHandler(this.AccountDayButton_Click);
            // 
            // ItemHeaderPanel
            // 
            this.ItemHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.ItemHeaderPanel.Controls.Add(this.ItemEditTypeButton);
            this.ItemHeaderPanel.Controls.Add(this.ItemAddToShelfButton);
            this.ItemHeaderPanel.Controls.Add(this.ItemRemoveFromShelfButton);
            this.ItemHeaderPanel.Controls.Add(this.ItemDeleteButton);
            this.ItemHeaderPanel.Controls.Add(this.ItemNewButton);
            this.ItemHeaderPanel.Controls.Add(this.ItemSearchButton);
            this.ItemHeaderPanel.Controls.Add(this.ItemListButton);
            this.ItemHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemHeaderPanel.Name = "ItemHeaderPanel";
            this.ItemHeaderPanel.Size = new System.Drawing.Size(1024, 80);
            this.ItemHeaderPanel.TabIndex = 1;
            this.ItemHeaderPanel.Visible = false;
            // 
            // ItemEditTypeButton
            // 
            this.ItemEditTypeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(179)))));
            this.ItemEditTypeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ItemEditTypeButton.FlatAppearance.BorderSize = 0;
            this.ItemEditTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemEditTypeButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ItemEditTypeButton.Location = new System.Drawing.Point(288, 0);
            this.ItemEditTypeButton.Name = "ItemEditTypeButton";
            this.ItemEditTypeButton.Size = new System.Drawing.Size(96, 80);
            this.ItemEditTypeButton.TabIndex = 16;
            this.ItemEditTypeButton.Text = "編輯分類";
            this.ItemEditTypeButton.UseVisualStyleBackColor = false;
            this.ItemEditTypeButton.Click += new System.EventHandler(this.ItemEditTypeButton_Click);
            // 
            // ItemAddToShelfButton
            // 
            this.ItemAddToShelfButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(128)))));
            this.ItemAddToShelfButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ItemAddToShelfButton.FlatAppearance.BorderSize = 0;
            this.ItemAddToShelfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemAddToShelfButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ItemAddToShelfButton.Location = new System.Drawing.Point(736, 0);
            this.ItemAddToShelfButton.Name = "ItemAddToShelfButton";
            this.ItemAddToShelfButton.Size = new System.Drawing.Size(96, 80);
            this.ItemAddToShelfButton.TabIndex = 15;
            this.ItemAddToShelfButton.Text = "上架";
            this.ItemAddToShelfButton.UseVisualStyleBackColor = false;
            this.ItemAddToShelfButton.Click += new System.EventHandler(this.ItemAddToShelfButton_Click);
            // 
            // ItemRemoveFromShelfButton
            // 
            this.ItemRemoveFromShelfButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(102)))));
            this.ItemRemoveFromShelfButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ItemRemoveFromShelfButton.FlatAppearance.BorderSize = 0;
            this.ItemRemoveFromShelfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemRemoveFromShelfButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ItemRemoveFromShelfButton.Location = new System.Drawing.Point(832, 0);
            this.ItemRemoveFromShelfButton.Name = "ItemRemoveFromShelfButton";
            this.ItemRemoveFromShelfButton.Size = new System.Drawing.Size(96, 80);
            this.ItemRemoveFromShelfButton.TabIndex = 14;
            this.ItemRemoveFromShelfButton.Text = "下架";
            this.ItemRemoveFromShelfButton.UseVisualStyleBackColor = false;
            this.ItemRemoveFromShelfButton.Click += new System.EventHandler(this.ItemRemoveFromShelfButton_Click);
            // 
            // ItemDeleteButton
            // 
            this.ItemDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(77)))));
            this.ItemDeleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ItemDeleteButton.FlatAppearance.BorderSize = 0;
            this.ItemDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemDeleteButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ItemDeleteButton.Location = new System.Drawing.Point(928, 0);
            this.ItemDeleteButton.Name = "ItemDeleteButton";
            this.ItemDeleteButton.Size = new System.Drawing.Size(96, 80);
            this.ItemDeleteButton.TabIndex = 12;
            this.ItemDeleteButton.Text = "刪除商品";
            this.ItemDeleteButton.UseVisualStyleBackColor = false;
            this.ItemDeleteButton.Click += new System.EventHandler(this.ItemDeleteButton_Click);
            // 
            // ItemNewButton
            // 
            this.ItemNewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
            this.ItemNewButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ItemNewButton.FlatAppearance.BorderSize = 0;
            this.ItemNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemNewButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ItemNewButton.Location = new System.Drawing.Point(192, 0);
            this.ItemNewButton.Name = "ItemNewButton";
            this.ItemNewButton.Size = new System.Drawing.Size(96, 80);
            this.ItemNewButton.TabIndex = 11;
            this.ItemNewButton.Text = "新增商品";
            this.ItemNewButton.UseVisualStyleBackColor = false;
            this.ItemNewButton.Click += new System.EventHandler(this.ItemNewButton_Click);
            // 
            // ItemSearchButton
            // 
            this.ItemSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.ItemSearchButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ItemSearchButton.FlatAppearance.BorderSize = 0;
            this.ItemSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemSearchButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ItemSearchButton.Location = new System.Drawing.Point(96, 0);
            this.ItemSearchButton.Name = "ItemSearchButton";
            this.ItemSearchButton.Size = new System.Drawing.Size(96, 80);
            this.ItemSearchButton.TabIndex = 10;
            this.ItemSearchButton.Text = "搜尋商品";
            this.ItemSearchButton.UseVisualStyleBackColor = false;
            this.ItemSearchButton.Click += new System.EventHandler(this.ItemSearchButton_Click);
            // 
            // ItemListButton
            // 
            this.ItemListButton.BackColor = System.Drawing.Color.White;
            this.ItemListButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ItemListButton.FlatAppearance.BorderSize = 0;
            this.ItemListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemListButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ItemListButton.Location = new System.Drawing.Point(0, 0);
            this.ItemListButton.Name = "ItemListButton";
            this.ItemListButton.Size = new System.Drawing.Size(96, 80);
            this.ItemListButton.TabIndex = 9;
            this.ItemListButton.Text = "商品列表";
            this.ItemListButton.UseVisualStyleBackColor = false;
            this.ItemListButton.Click += new System.EventHandler(this.ItemListButton_Click);
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.Color.White;
            this.HomePanel.Controls.Add(this.HomeRichTextBox);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(240, 80);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1024, 601);
            this.HomePanel.TabIndex = 2;
            // 
            // HomeRichTextBox
            // 
            this.HomeRichTextBox.BackColor = System.Drawing.Color.White;
            this.HomeRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HomeRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeRichTextBox.Enabled = false;
            this.HomeRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.HomeRichTextBox.Name = "HomeRichTextBox";
            this.HomeRichTextBox.ReadOnly = true;
            this.HomeRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.HomeRichTextBox.Size = new System.Drawing.Size(1024, 601);
            this.HomeRichTextBox.TabIndex = 0;
            this.HomeRichTextBox.Text = "";
            // 
            // MemberDetailsPanel
            // 
            this.MemberDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberDetailsPanel.Location = new System.Drawing.Point(240, 80);
            this.MemberDetailsPanel.Name = "MemberDetailsPanel";
            this.MemberDetailsPanel.Size = new System.Drawing.Size(1024, 601);
            this.MemberDetailsPanel.TabIndex = 0;
            this.MemberDetailsPanel.Visible = false;
            // 
            // MemberListPanel
            // 
            this.MemberListPanel.BackColor = System.Drawing.Color.White;
            this.MemberListPanel.Controls.Add(this.MemberListDataGridView);
            this.MemberListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberListPanel.Location = new System.Drawing.Point(240, 80);
            this.MemberListPanel.Name = "MemberListPanel";
            this.MemberListPanel.Size = new System.Drawing.Size(1024, 601);
            this.MemberListPanel.TabIndex = 0;
            this.MemberListPanel.Visible = false;
            // 
            // MemberListDataGridView
            // 
            this.MemberListDataGridView.AllowUserToAddRows = false;
            this.MemberListDataGridView.AllowUserToDeleteRows = false;
            this.MemberListDataGridView.AutoGenerateColumns = false;
            this.MemberListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MemberListDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.MemberListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MemberListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MemberListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberIDDataGridViewTextBox,
            this.MemberNameDataGridViewTextBox,
            this.MemberSexDataGridViewTextBox,
            this.MemberPhoneNumberDataGridViewTextBoxColumn,
            this.MemberZipCodeDataGridViewTextBoxColumn,
            this.MamberAddressDataGridViewTextBoxColumn,
            this.MemberEmailDataGridViewTextBoxColumn});
            this.MemberListDataGridView.DataSource = this.MemberBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MemberListDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.MemberListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberListDataGridView.Location = new System.Drawing.Point(0, 0);
            this.MemberListDataGridView.Name = "MemberListDataGridView";
            this.MemberListDataGridView.ReadOnly = true;
            this.MemberListDataGridView.RowHeadersVisible = false;
            this.MemberListDataGridView.RowTemplate.Height = 48;
            this.MemberListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MemberListDataGridView.Size = new System.Drawing.Size(1024, 601);
            this.MemberListDataGridView.TabIndex = 0;
            this.MemberListDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberListDataGridView_CellDoubleClick);
            this.MemberListDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.MemberListDataGridView_CellFormatting);
            // 
            // MemberIDDataGridViewTextBox
            // 
            this.MemberIDDataGridViewTextBox.DataPropertyName = "ID";
            this.MemberIDDataGridViewTextBox.FillWeight = 50F;
            this.MemberIDDataGridViewTextBox.HeaderText = "ID";
            this.MemberIDDataGridViewTextBox.Name = "MemberIDDataGridViewTextBox";
            this.MemberIDDataGridViewTextBox.ReadOnly = true;
            // 
            // MemberNameDataGridViewTextBox
            // 
            this.MemberNameDataGridViewTextBox.DataPropertyName = "Name";
            this.MemberNameDataGridViewTextBox.HeaderText = "姓名";
            this.MemberNameDataGridViewTextBox.Name = "MemberNameDataGridViewTextBox";
            this.MemberNameDataGridViewTextBox.ReadOnly = true;
            // 
            // MemberSexDataGridViewTextBox
            // 
            this.MemberSexDataGridViewTextBox.DataPropertyName = "Sex";
            this.MemberSexDataGridViewTextBox.FillWeight = 50F;
            this.MemberSexDataGridViewTextBox.HeaderText = "性別";
            this.MemberSexDataGridViewTextBox.Name = "MemberSexDataGridViewTextBox";
            this.MemberSexDataGridViewTextBox.ReadOnly = true;
            // 
            // MemberPhoneNumberDataGridViewTextBoxColumn
            // 
            this.MemberPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.MemberPhoneNumberDataGridViewTextBoxColumn.HeaderText = "電話";
            this.MemberPhoneNumberDataGridViewTextBoxColumn.Name = "MemberPhoneNumberDataGridViewTextBoxColumn";
            this.MemberPhoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MemberZipCodeDataGridViewTextBoxColumn
            // 
            this.MemberZipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            this.MemberZipCodeDataGridViewTextBoxColumn.HeaderText = "郵遞區號";
            this.MemberZipCodeDataGridViewTextBoxColumn.Name = "MemberZipCodeDataGridViewTextBoxColumn";
            this.MemberZipCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MamberAddressDataGridViewTextBoxColumn
            // 
            this.MamberAddressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.MamberAddressDataGridViewTextBoxColumn.FillWeight = 200F;
            this.MamberAddressDataGridViewTextBoxColumn.HeaderText = "地址";
            this.MamberAddressDataGridViewTextBoxColumn.Name = "MamberAddressDataGridViewTextBoxColumn";
            this.MamberAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MemberEmailDataGridViewTextBoxColumn
            // 
            this.MemberEmailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.MemberEmailDataGridViewTextBoxColumn.FillWeight = 150F;
            this.MemberEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.MemberEmailDataGridViewTextBoxColumn.Name = "MemberEmailDataGridViewTextBoxColumn";
            this.MemberEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MemberBindingSource
            // 
            this.MemberBindingSource.DataMember = "Member";
            this.MemberBindingSource.DataSource = this.CoffeeHomeDataSet;
            // 
            // CoffeeHomeDataSet
            // 
            this.CoffeeHomeDataSet.DataSetName = "CoffeeHomeDataSet";
            this.CoffeeHomeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SexBindingSource
            // 
            this.SexBindingSource.DataMember = "Sex";
            this.SexBindingSource.DataSource = this.CoffeeHomeDataSet;
            // 
            // ItemPanel
            // 
            this.ItemPanel.Controls.Add(this.ItemDataGridView);
            this.ItemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemPanel.Location = new System.Drawing.Point(240, 80);
            this.ItemPanel.Name = "ItemPanel";
            this.ItemPanel.Size = new System.Drawing.Size(1024, 601);
            this.ItemPanel.TabIndex = 3;
            this.ItemPanel.Visible = false;
            // 
            // ItemDataGridView
            // 
            this.ItemDataGridView.AllowUserToAddRows = false;
            this.ItemDataGridView.AllowUserToDeleteRows = false;
            this.ItemDataGridView.AutoGenerateColumns = false;
            this.ItemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ItemDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemIDDataGridViewTextBox,
            this.ItemNameDataGridViewTextBox,
            this.ItemTypeIDDataGridViewTextBox,
            this.ItemPriceDataGridViewTextBox,
            this.ItemRemarksDataGridViewTextBox,
            this.ItemShelfDataGridViewTextBox});
            this.ItemDataGridView.DataSource = this.ItemBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.ItemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemDataGridView.GridColor = System.Drawing.Color.Silver;
            this.ItemDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ItemDataGridView.Name = "ItemDataGridView";
            this.ItemDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ItemDataGridView.RowHeadersVisible = false;
            this.ItemDataGridView.RowTemplate.Height = 48;
            this.ItemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemDataGridView.Size = new System.Drawing.Size(1024, 601);
            this.ItemDataGridView.TabIndex = 0;
            this.ItemDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemDataGridView_CellDoubleClick);
            this.ItemDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ItemDataGridView_CellFormatting);
            // 
            // ItemIDDataGridViewTextBox
            // 
            this.ItemIDDataGridViewTextBox.DataPropertyName = "ID";
            this.ItemIDDataGridViewTextBox.FillWeight = 5F;
            this.ItemIDDataGridViewTextBox.HeaderText = "ID";
            this.ItemIDDataGridViewTextBox.Name = "ItemIDDataGridViewTextBox";
            this.ItemIDDataGridViewTextBox.ReadOnly = true;
            // 
            // ItemNameDataGridViewTextBox
            // 
            this.ItemNameDataGridViewTextBox.DataPropertyName = "Name";
            this.ItemNameDataGridViewTextBox.FillWeight = 20F;
            this.ItemNameDataGridViewTextBox.HeaderText = "名稱";
            this.ItemNameDataGridViewTextBox.Name = "ItemNameDataGridViewTextBox";
            this.ItemNameDataGridViewTextBox.ReadOnly = true;
            // 
            // ItemTypeIDDataGridViewTextBox
            // 
            this.ItemTypeIDDataGridViewTextBox.DataPropertyName = "TypeID";
            this.ItemTypeIDDataGridViewTextBox.FillWeight = 30F;
            this.ItemTypeIDDataGridViewTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemTypeIDDataGridViewTextBox.HeaderText = "分類";
            this.ItemTypeIDDataGridViewTextBox.Name = "ItemTypeIDDataGridViewTextBox";
            this.ItemTypeIDDataGridViewTextBox.ReadOnly = true;
            this.ItemTypeIDDataGridViewTextBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemTypeIDDataGridViewTextBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ItemPriceDataGridViewTextBox
            // 
            this.ItemPriceDataGridViewTextBox.DataPropertyName = "Price";
            this.ItemPriceDataGridViewTextBox.FillWeight = 10F;
            this.ItemPriceDataGridViewTextBox.HeaderText = "單價";
            this.ItemPriceDataGridViewTextBox.Name = "ItemPriceDataGridViewTextBox";
            this.ItemPriceDataGridViewTextBox.ReadOnly = true;
            // 
            // ItemRemarksDataGridViewTextBox
            // 
            this.ItemRemarksDataGridViewTextBox.DataPropertyName = "Remarks";
            this.ItemRemarksDataGridViewTextBox.FillWeight = 30F;
            this.ItemRemarksDataGridViewTextBox.HeaderText = "備註";
            this.ItemRemarksDataGridViewTextBox.Name = "ItemRemarksDataGridViewTextBox";
            this.ItemRemarksDataGridViewTextBox.ReadOnly = true;
            // 
            // ItemShelfDataGridViewTextBox
            // 
            this.ItemShelfDataGridViewTextBox.FillWeight = 10F;
            this.ItemShelfDataGridViewTextBox.HeaderText = "狀態";
            this.ItemShelfDataGridViewTextBox.Name = "ItemShelfDataGridViewTextBox";
            this.ItemShelfDataGridViewTextBox.ReadOnly = true;
            // 
            // ItemBindingSource
            // 
            this.ItemBindingSource.DataMember = "Item";
            this.ItemBindingSource.DataSource = this.CoffeeHomeDataSet;
            // 
            // ItemShelfBindingSource
            // 
            this.ItemShelfBindingSource.DataMember = "ItemShelf";
            this.ItemShelfBindingSource.DataSource = this.CoffeeHomeDataSet;
            // 
            // PaymentTypeBindingSource
            // 
            this.PaymentTypeBindingSource.DataMember = "PaymentType";
            this.PaymentTypeBindingSource.DataSource = this.CoffeeHomeDataSet;
            // 
            // TradeBindingSource
            // 
            this.TradeBindingSource.DataSource = this.CoffeeHomeDataSet;
            this.TradeBindingSource.Position = 0;
            // 
            // MemberTableAdapter
            // 
            this.MemberTableAdapter.ClearBeforeFill = true;
            // 
            // TableAdapterManager
            // 
            this.TableAdapterManager.AccountTableAdapter = null;
            this.TableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.TableAdapterManager.ItemShelfTableAdapter = this.ItemShelfTableAdapter;
            this.TableAdapterManager.ItemTableAdapter = this.ItemTableAdapter;
            this.TableAdapterManager.ItemTypeTableAdapter = this.ItemTypeTableAdapter;
            this.TableAdapterManager.MemberTableAdapter = this.MemberTableAdapter;
            this.TableAdapterManager.PaymentTypeTableAdapter = this.PaymentTypeTableAdapter;
            this.TableAdapterManager.RoastDegreeTableAdapter = null;
            this.TableAdapterManager.SexTableAdapter = this.SexTableAdapter;
            this.TableAdapterManager.TradeItemTableAdapter = this.TradeItemTableAdapter;
            this.TableAdapterManager.TradeTableAdapter = this.TradeTableAdapter;
            this.TableAdapterManager.UpdateOrder = CoffeeHome.CoffeeHomeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ItemShelfTableAdapter
            // 
            this.ItemShelfTableAdapter.ClearBeforeFill = true;
            // 
            // ItemTableAdapter
            // 
            this.ItemTableAdapter.ClearBeforeFill = true;
            // 
            // ItemTypeTableAdapter
            // 
            this.ItemTypeTableAdapter.ClearBeforeFill = true;
            // 
            // PaymentTypeTableAdapter
            // 
            this.PaymentTypeTableAdapter.ClearBeforeFill = true;
            // 
            // SexTableAdapter
            // 
            this.SexTableAdapter.ClearBeforeFill = true;
            // 
            // TradeItemTableAdapter
            // 
            this.TradeItemTableAdapter.ClearBeforeFill = true;
            // 
            // TradeTableAdapter
            // 
            this.TradeTableAdapter.ClearBeforeFill = true;
            // 
            // ItemTypeBindingSource
            // 
            this.ItemTypeBindingSource.DataMember = "ItemType";
            this.ItemTypeBindingSource.DataSource = this.CoffeeHomeDataSet;
            // 
            // TradeItemBindingSource
            // 
            this.TradeItemBindingSource.DataMember = "TradeItem";
            this.TradeItemBindingSource.DataSource = this.CoffeeHomeDataSet;
            // 
            // AccountBindingSource
            // 
            this.AccountBindingSource.DataMember = "Account";
            this.AccountBindingSource.DataSource = this.CoffeeHomeDataSet;
            // 
            // AccountTableAdapter
            // 
            this.AccountTableAdapter.ClearBeforeFill = true;
            // 
            // RoastDegreeBindingSource
            // 
            this.RoastDegreeBindingSource.DataMember = "RoastDegree";
            this.RoastDegreeBindingSource.DataSource = this.CoffeeHomeDataSet;
            // 
            // RoastDegreeTableAdapter
            // 
            this.RoastDegreeTableAdapter.ClearBeforeFill = true;
            // 
            // IdleTimer
            // 
            this.IdleTimer.Tick += new System.EventHandler(this.IdleTimer_Tick);
            // 
            // AccountDayUserControl
            // 
            this.AccountDayUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountDayUserControl.Location = new System.Drawing.Point(240, 80);
            this.AccountDayUserControl.Name = "AccountDayUserControl";
            this.AccountDayUserControl.Size = new System.Drawing.Size(1024, 601);
            this.AccountDayUserControl.TabIndex = 11;
            this.AccountDayUserControl.Visible = false;
            // 
            // AccountMonthUserControl
            // 
            this.AccountMonthUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountMonthUserControl.Location = new System.Drawing.Point(240, 80);
            this.AccountMonthUserControl.Name = "AccountMonthUserControl";
            this.AccountMonthUserControl.Size = new System.Drawing.Size(1024, 601);
            this.AccountMonthUserControl.TabIndex = 10;
            this.AccountMonthUserControl.Visible = false;
            // 
            // AccountYearUserControl
            // 
            this.AccountYearUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountYearUserControl.Location = new System.Drawing.Point(240, 80);
            this.AccountYearUserControl.Name = "AccountYearUserControl";
            this.AccountYearUserControl.Size = new System.Drawing.Size(1024, 601);
            this.AccountYearUserControl.TabIndex = 9;
            this.AccountYearUserControl.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.AccountDayUserControl);
            this.Controls.Add(this.AccountMonthUserControl);
            this.Controls.Add(this.AccountYearUserControl);
            this.Controls.Add(this.ItemPanel);
            this.Controls.Add(this.MemberDetailsPanel);
            this.Controls.Add(this.MemberListPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.SidePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "咖啡的家營業管理系統";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SidePanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.MemberHeaderPanel.ResumeLayout(false);
            this.HomeHeaderPanel.ResumeLayout(false);
            this.AccountHeaderPanel.ResumeLayout(false);
            this.ItemHeaderPanel.ResumeLayout(false);
            this.HomePanel.ResumeLayout(false);
            this.MemberListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MemberListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeHomeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexBindingSource)).EndInit();
            this.ItemPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemShelfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoastDegreeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button ItemButton;
        private System.Windows.Forms.Button MemberButton;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Panel MemberDetailsPanel;
        private System.Windows.Forms.Panel ItemPanel;
        private System.Windows.Forms.Panel AccountHeaderPanel;
        private System.Windows.Forms.Panel ItemHeaderPanel;
        private System.Windows.Forms.Panel MemberHeaderPanel;
        private System.Windows.Forms.Panel HomeHeaderPanel;
        private System.Windows.Forms.Button MemberNewButton;
        private System.Windows.Forms.Button MemberEditButton;
        private System.Windows.Forms.Button MemberNewTradeButton;
        private System.Windows.Forms.Button MemberSearchButton;
        private System.Windows.Forms.Button MemberDeleteButton;
        private System.Windows.Forms.Button NonMemberTradeButton;
        private System.Windows.Forms.Button AccountYearButton;
        private System.Windows.Forms.Button AccountMonthButton;
        private System.Windows.Forms.Button AccountDayButton;
        private System.Windows.Forms.Button ItemAddToShelfButton;
        private System.Windows.Forms.Button ItemRemoveFromShelfButton;
        private System.Windows.Forms.Button ItemDeleteButton;
        private System.Windows.Forms.Button ItemNewButton;
        private System.Windows.Forms.Button ItemSearchButton;
        private System.Windows.Forms.Button ItemListButton;
        private CoffeeHomeDataSet CoffeeHomeDataSet;
        private System.Windows.Forms.BindingSource MemberBindingSource;
        private CoffeeHomeDataSetTableAdapters.MemberTableAdapter MemberTableAdapter;
        private CoffeeHomeDataSetTableAdapters.TableAdapterManager TableAdapterManager;
        private System.Windows.Forms.BindingSource SexBindingSource;
        private CoffeeHomeDataSetTableAdapters.SexTableAdapter SexTableAdapter;
        private System.Windows.Forms.BindingSource ItemBindingSource;
        private CoffeeHomeDataSetTableAdapters.ItemTableAdapter ItemTableAdapter;
        private System.Windows.Forms.DataGridView ItemDataGridView;
        private System.Windows.Forms.BindingSource ItemShelfBindingSource;
        private CoffeeHomeDataSetTableAdapters.ItemShelfTableAdapter ItemShelfTableAdapter;
        private System.Windows.Forms.BindingSource ItemTypeBindingSource;
        private CoffeeHomeDataSetTableAdapters.ItemTypeTableAdapter ItemTypeTableAdapter;
        private System.Windows.Forms.BindingSource TradeBindingSource;
        private CoffeeHomeDataSetTableAdapters.TradeTableAdapter TradeTableAdapter;
        private System.Windows.Forms.BindingSource PaymentTypeBindingSource;
        private CoffeeHomeDataSetTableAdapters.PaymentTypeTableAdapter PaymentTypeTableAdapter;
        private System.Windows.Forms.BindingSource TradeItemBindingSource;
        private CoffeeHomeDataSetTableAdapters.TradeItemTableAdapter TradeItemTableAdapter;
        private System.Windows.Forms.BindingSource AccountBindingSource;
        private CoffeeHomeDataSetTableAdapters.AccountTableAdapter AccountTableAdapter;
        private System.Windows.Forms.BindingSource RoastDegreeBindingSource;
        private CoffeeHomeDataSetTableAdapters.RoastDegreeTableAdapter RoastDegreeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemIDDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNameDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewButtonColumn ItemTypeIDDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPriceDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemShelfDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemRemarksDataGridViewTextBox;
        private System.Windows.Forms.Timer IdleTimer;
        private System.Windows.Forms.Button ItemEditTypeButton;
        private System.Windows.Forms.Panel MemberListPanel;
        private System.Windows.Forms.DataGridView MemberListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberIDDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberNameDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberSexDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberZipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MamberAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label SettingLabel;
        private System.Windows.Forms.Label AccountLabel;
        private AccountYearUserControl AccountYearUserControl;
        private AccountMonthUserControl AccountMonthUserControl;
        private AccountDayUserControl AccountDayUserControl;
        private System.Windows.Forms.Button MemberBackButton;
        private System.Windows.Forms.RichTextBox HomeRichTextBox;
    }
}

