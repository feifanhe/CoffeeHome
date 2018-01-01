namespace CoffeeHome
{
    partial class AccountMonthUserControl
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
            this.AccountMonthPanel = new System.Windows.Forms.Panel();
            this.AccountMonthStatisticsPanel = new System.Windows.Forms.Panel();
            this.AccountMonthSalesPanel2 = new System.Windows.Forms.Panel();
            this.AccountMonthAchievementPanel = new System.Windows.Forms.Panel();
            this.AccountMonthAchievementTextBox = new System.Windows.Forms.TextBox();
            this.AccountMonthAchievementButton = new System.Windows.Forms.Button();
            this.AccountMonthMistakePanel = new System.Windows.Forms.Panel();
            this.AccountMonthMistakeTextBox = new System.Windows.Forms.TextBox();
            this.AccountMonthMistakeButton = new System.Windows.Forms.Button();
            this.AccountMonthCashPanel = new System.Windows.Forms.Panel();
            this.AccountMonthCashTextBox = new System.Windows.Forms.TextBox();
            this.AccountMonthCashButton = new System.Windows.Forms.Button();
            this.AccountMonthSalesPanel = new System.Windows.Forms.Panel();
            this.AccountMonthDeliveryPanel = new System.Windows.Forms.Panel();
            this.AccountMonthDeliveryTextBox = new System.Windows.Forms.TextBox();
            this.AccountMonthDeliveryButton = new System.Windows.Forms.Button();
            this.AccountMonthCreditCardPanel = new System.Windows.Forms.Panel();
            this.AccountMonthCreditCardTextBox = new System.Windows.Forms.TextBox();
            this.AccountMonthCreditCardButton = new System.Windows.Forms.Button();
            this.AccountMonthNoReceiptPanel = new System.Windows.Forms.Panel();
            this.AccountMonthNoReceiptTextBox = new System.Windows.Forms.TextBox();
            this.AccountMonthNoReceiptButton = new System.Windows.Forms.Button();
            this.AccountMonthReceiptPanel = new System.Windows.Forms.Panel();
            this.AccountMonthReceiptTextBox = new System.Windows.Forms.TextBox();
            this.AccountMonthReceiptButton = new System.Windows.Forms.Button();
            this.AccountMonthSelectPanel = new System.Windows.Forms.Panel();
            this.AccountMonthMonthComboBox = new System.Windows.Forms.ComboBox();
            this.AccountMonthYearComboBox = new System.Windows.Forms.ComboBox();
            this.AccountMonthPanel.SuspendLayout();
            this.AccountMonthStatisticsPanel.SuspendLayout();
            this.AccountMonthSalesPanel2.SuspendLayout();
            this.AccountMonthAchievementPanel.SuspendLayout();
            this.AccountMonthMistakePanel.SuspendLayout();
            this.AccountMonthCashPanel.SuspendLayout();
            this.AccountMonthSalesPanel.SuspendLayout();
            this.AccountMonthDeliveryPanel.SuspendLayout();
            this.AccountMonthCreditCardPanel.SuspendLayout();
            this.AccountMonthNoReceiptPanel.SuspendLayout();
            this.AccountMonthReceiptPanel.SuspendLayout();
            this.AccountMonthSelectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountMonthPanel
            // 
            this.AccountMonthPanel.Controls.Add(this.AccountMonthStatisticsPanel);
            this.AccountMonthPanel.Controls.Add(this.AccountMonthSelectPanel);
            this.AccountMonthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountMonthPanel.Location = new System.Drawing.Point(0, 0);
            this.AccountMonthPanel.Name = "AccountMonthPanel";
            this.AccountMonthPanel.Size = new System.Drawing.Size(1024, 600);
            this.AccountMonthPanel.TabIndex = 7;
            // 
            // AccountMonthStatisticsPanel
            // 
            this.AccountMonthStatisticsPanel.BackColor = System.Drawing.Color.White;
            this.AccountMonthStatisticsPanel.Controls.Add(this.AccountMonthSalesPanel2);
            this.AccountMonthStatisticsPanel.Controls.Add(this.AccountMonthSalesPanel);
            this.AccountMonthStatisticsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountMonthStatisticsPanel.Location = new System.Drawing.Point(0, 50);
            this.AccountMonthStatisticsPanel.Name = "AccountMonthStatisticsPanel";
            this.AccountMonthStatisticsPanel.Size = new System.Drawing.Size(1024, 100);
            this.AccountMonthStatisticsPanel.TabIndex = 1;
            // 
            // AccountMonthSalesPanel2
            // 
            this.AccountMonthSalesPanel2.Controls.Add(this.AccountMonthAchievementPanel);
            this.AccountMonthSalesPanel2.Controls.Add(this.AccountMonthMistakePanel);
            this.AccountMonthSalesPanel2.Controls.Add(this.AccountMonthCashPanel);
            this.AccountMonthSalesPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountMonthSalesPanel2.Location = new System.Drawing.Point(0, 50);
            this.AccountMonthSalesPanel2.Name = "AccountMonthSalesPanel2";
            this.AccountMonthSalesPanel2.Size = new System.Drawing.Size(1024, 50);
            this.AccountMonthSalesPanel2.TabIndex = 2;
            // 
            // AccountMonthAchievementPanel
            // 
            this.AccountMonthAchievementPanel.Controls.Add(this.AccountMonthAchievementTextBox);
            this.AccountMonthAchievementPanel.Controls.Add(this.AccountMonthAchievementButton);
            this.AccountMonthAchievementPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountMonthAchievementPanel.Location = new System.Drawing.Point(512, 0);
            this.AccountMonthAchievementPanel.Name = "AccountMonthAchievementPanel";
            this.AccountMonthAchievementPanel.Size = new System.Drawing.Size(256, 50);
            this.AccountMonthAchievementPanel.TabIndex = 6;
            // 
            // AccountMonthAchievementTextBox
            // 
            this.AccountMonthAchievementTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountMonthAchievementTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountMonthAchievementTextBox.Name = "AccountMonthAchievementTextBox";
            this.AccountMonthAchievementTextBox.ReadOnly = true;
            this.AccountMonthAchievementTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountMonthAchievementTextBox.TabIndex = 1;
            // 
            // AccountMonthAchievementButton
            // 
            this.AccountMonthAchievementButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountMonthAchievementButton.FlatAppearance.BorderSize = 0;
            this.AccountMonthAchievementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountMonthAchievementButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountMonthAchievementButton.Location = new System.Drawing.Point(0, 0);
            this.AccountMonthAchievementButton.Name = "AccountMonthAchievementButton";
            this.AccountMonthAchievementButton.Size = new System.Drawing.Size(75, 50);
            this.AccountMonthAchievementButton.TabIndex = 0;
            this.AccountMonthAchievementButton.TabStop = false;
            this.AccountMonthAchievementButton.Text = "總業績";
            this.AccountMonthAchievementButton.UseVisualStyleBackColor = true;
            // 
            // AccountMonthMistakePanel
            // 
            this.AccountMonthMistakePanel.Controls.Add(this.AccountMonthMistakeTextBox);
            this.AccountMonthMistakePanel.Controls.Add(this.AccountMonthMistakeButton);
            this.AccountMonthMistakePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountMonthMistakePanel.Location = new System.Drawing.Point(256, 0);
            this.AccountMonthMistakePanel.Name = "AccountMonthMistakePanel";
            this.AccountMonthMistakePanel.Size = new System.Drawing.Size(256, 50);
            this.AccountMonthMistakePanel.TabIndex = 7;
            // 
            // AccountMonthMistakeTextBox
            // 
            this.AccountMonthMistakeTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountMonthMistakeTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountMonthMistakeTextBox.Name = "AccountMonthMistakeTextBox";
            this.AccountMonthMistakeTextBox.ReadOnly = true;
            this.AccountMonthMistakeTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountMonthMistakeTextBox.TabIndex = 1;
            // 
            // AccountMonthMistakeButton
            // 
            this.AccountMonthMistakeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountMonthMistakeButton.FlatAppearance.BorderSize = 0;
            this.AccountMonthMistakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountMonthMistakeButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountMonthMistakeButton.Location = new System.Drawing.Point(0, 0);
            this.AccountMonthMistakeButton.Name = "AccountMonthMistakeButton";
            this.AccountMonthMistakeButton.Size = new System.Drawing.Size(75, 50);
            this.AccountMonthMistakeButton.TabIndex = 0;
            this.AccountMonthMistakeButton.TabStop = false;
            this.AccountMonthMistakeButton.Text = "總誤打";
            this.AccountMonthMistakeButton.UseVisualStyleBackColor = true;
            // 
            // AccountMonthCashPanel
            // 
            this.AccountMonthCashPanel.Controls.Add(this.AccountMonthCashTextBox);
            this.AccountMonthCashPanel.Controls.Add(this.AccountMonthCashButton);
            this.AccountMonthCashPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountMonthCashPanel.Location = new System.Drawing.Point(0, 0);
            this.AccountMonthCashPanel.Name = "AccountMonthCashPanel";
            this.AccountMonthCashPanel.Size = new System.Drawing.Size(256, 50);
            this.AccountMonthCashPanel.TabIndex = 8;
            // 
            // AccountMonthCashTextBox
            // 
            this.AccountMonthCashTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountMonthCashTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountMonthCashTextBox.Name = "AccountMonthCashTextBox";
            this.AccountMonthCashTextBox.ReadOnly = true;
            this.AccountMonthCashTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountMonthCashTextBox.TabIndex = 1;
            // 
            // AccountMonthCashButton
            // 
            this.AccountMonthCashButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountMonthCashButton.FlatAppearance.BorderSize = 0;
            this.AccountMonthCashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountMonthCashButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountMonthCashButton.Location = new System.Drawing.Point(0, 0);
            this.AccountMonthCashButton.Name = "AccountMonthCashButton";
            this.AccountMonthCashButton.Size = new System.Drawing.Size(75, 50);
            this.AccountMonthCashButton.TabIndex = 0;
            this.AccountMonthCashButton.TabStop = false;
            this.AccountMonthCashButton.Text = "總現金";
            this.AccountMonthCashButton.UseVisualStyleBackColor = true;
            // 
            // AccountMonthSalesPanel
            // 
            this.AccountMonthSalesPanel.Controls.Add(this.AccountMonthDeliveryPanel);
            this.AccountMonthSalesPanel.Controls.Add(this.AccountMonthCreditCardPanel);
            this.AccountMonthSalesPanel.Controls.Add(this.AccountMonthNoReceiptPanel);
            this.AccountMonthSalesPanel.Controls.Add(this.AccountMonthReceiptPanel);
            this.AccountMonthSalesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountMonthSalesPanel.Location = new System.Drawing.Point(0, 0);
            this.AccountMonthSalesPanel.Name = "AccountMonthSalesPanel";
            this.AccountMonthSalesPanel.Size = new System.Drawing.Size(1024, 50);
            this.AccountMonthSalesPanel.TabIndex = 0;
            // 
            // AccountMonthDeliveryPanel
            // 
            this.AccountMonthDeliveryPanel.Controls.Add(this.AccountMonthDeliveryTextBox);
            this.AccountMonthDeliveryPanel.Controls.Add(this.AccountMonthDeliveryButton);
            this.AccountMonthDeliveryPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountMonthDeliveryPanel.Location = new System.Drawing.Point(768, 0);
            this.AccountMonthDeliveryPanel.Name = "AccountMonthDeliveryPanel";
            this.AccountMonthDeliveryPanel.Size = new System.Drawing.Size(256, 50);
            this.AccountMonthDeliveryPanel.TabIndex = 5;
            // 
            // AccountMonthDeliveryTextBox
            // 
            this.AccountMonthDeliveryTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountMonthDeliveryTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountMonthDeliveryTextBox.Name = "AccountMonthDeliveryTextBox";
            this.AccountMonthDeliveryTextBox.ReadOnly = true;
            this.AccountMonthDeliveryTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountMonthDeliveryTextBox.TabIndex = 2;
            // 
            // AccountMonthDeliveryButton
            // 
            this.AccountMonthDeliveryButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountMonthDeliveryButton.FlatAppearance.BorderSize = 0;
            this.AccountMonthDeliveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountMonthDeliveryButton.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountMonthDeliveryButton.Location = new System.Drawing.Point(0, 0);
            this.AccountMonthDeliveryButton.Name = "AccountMonthDeliveryButton";
            this.AccountMonthDeliveryButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.AccountMonthDeliveryButton.Size = new System.Drawing.Size(75, 50);
            this.AccountMonthDeliveryButton.TabIndex = 1;
            this.AccountMonthDeliveryButton.TabStop = false;
            this.AccountMonthDeliveryButton.Text = "貨到付款";
            this.AccountMonthDeliveryButton.UseVisualStyleBackColor = true;
            // 
            // AccountMonthCreditCardPanel
            // 
            this.AccountMonthCreditCardPanel.Controls.Add(this.AccountMonthCreditCardTextBox);
            this.AccountMonthCreditCardPanel.Controls.Add(this.AccountMonthCreditCardButton);
            this.AccountMonthCreditCardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountMonthCreditCardPanel.Location = new System.Drawing.Point(512, 0);
            this.AccountMonthCreditCardPanel.Name = "AccountMonthCreditCardPanel";
            this.AccountMonthCreditCardPanel.Size = new System.Drawing.Size(256, 50);
            this.AccountMonthCreditCardPanel.TabIndex = 2;
            // 
            // AccountMonthCreditCardTextBox
            // 
            this.AccountMonthCreditCardTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountMonthCreditCardTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountMonthCreditCardTextBox.Name = "AccountMonthCreditCardTextBox";
            this.AccountMonthCreditCardTextBox.ReadOnly = true;
            this.AccountMonthCreditCardTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountMonthCreditCardTextBox.TabIndex = 2;
            // 
            // AccountMonthCreditCardButton
            // 
            this.AccountMonthCreditCardButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountMonthCreditCardButton.FlatAppearance.BorderSize = 0;
            this.AccountMonthCreditCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountMonthCreditCardButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountMonthCreditCardButton.Location = new System.Drawing.Point(0, 0);
            this.AccountMonthCreditCardButton.Name = "AccountMonthCreditCardButton";
            this.AccountMonthCreditCardButton.Size = new System.Drawing.Size(75, 50);
            this.AccountMonthCreditCardButton.TabIndex = 1;
            this.AccountMonthCreditCardButton.TabStop = false;
            this.AccountMonthCreditCardButton.Text = "信用卡";
            this.AccountMonthCreditCardButton.UseVisualStyleBackColor = true;
            // 
            // AccountMonthNoReceiptPanel
            // 
            this.AccountMonthNoReceiptPanel.Controls.Add(this.AccountMonthNoReceiptTextBox);
            this.AccountMonthNoReceiptPanel.Controls.Add(this.AccountMonthNoReceiptButton);
            this.AccountMonthNoReceiptPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountMonthNoReceiptPanel.Location = new System.Drawing.Point(256, 0);
            this.AccountMonthNoReceiptPanel.Name = "AccountMonthNoReceiptPanel";
            this.AccountMonthNoReceiptPanel.Size = new System.Drawing.Size(256, 50);
            this.AccountMonthNoReceiptPanel.TabIndex = 1;
            // 
            // AccountMonthNoReceiptTextBox
            // 
            this.AccountMonthNoReceiptTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountMonthNoReceiptTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountMonthNoReceiptTextBox.Name = "AccountMonthNoReceiptTextBox";
            this.AccountMonthNoReceiptTextBox.ReadOnly = true;
            this.AccountMonthNoReceiptTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountMonthNoReceiptTextBox.TabIndex = 2;
            // 
            // AccountMonthNoReceiptButton
            // 
            this.AccountMonthNoReceiptButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountMonthNoReceiptButton.FlatAppearance.BorderSize = 0;
            this.AccountMonthNoReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountMonthNoReceiptButton.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountMonthNoReceiptButton.Location = new System.Drawing.Point(0, 0);
            this.AccountMonthNoReceiptButton.Name = "AccountMonthNoReceiptButton";
            this.AccountMonthNoReceiptButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.AccountMonthNoReceiptButton.Size = new System.Drawing.Size(75, 50);
            this.AccountMonthNoReceiptButton.TabIndex = 1;
            this.AccountMonthNoReceiptButton.TabStop = false;
            this.AccountMonthNoReceiptButton.Text = "未開發票";
            this.AccountMonthNoReceiptButton.UseVisualStyleBackColor = true;
            // 
            // AccountMonthReceiptPanel
            // 
            this.AccountMonthReceiptPanel.Controls.Add(this.AccountMonthReceiptTextBox);
            this.AccountMonthReceiptPanel.Controls.Add(this.AccountMonthReceiptButton);
            this.AccountMonthReceiptPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountMonthReceiptPanel.Location = new System.Drawing.Point(0, 0);
            this.AccountMonthReceiptPanel.Name = "AccountMonthReceiptPanel";
            this.AccountMonthReceiptPanel.Size = new System.Drawing.Size(256, 50);
            this.AccountMonthReceiptPanel.TabIndex = 0;
            // 
            // AccountMonthReceiptTextBox
            // 
            this.AccountMonthReceiptTextBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountMonthReceiptTextBox.Location = new System.Drawing.Point(81, 7);
            this.AccountMonthReceiptTextBox.Name = "AccountMonthReceiptTextBox";
            this.AccountMonthReceiptTextBox.ReadOnly = true;
            this.AccountMonthReceiptTextBox.Size = new System.Drawing.Size(169, 35);
            this.AccountMonthReceiptTextBox.TabIndex = 1;
            // 
            // AccountMonthReceiptButton
            // 
            this.AccountMonthReceiptButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AccountMonthReceiptButton.FlatAppearance.BorderSize = 0;
            this.AccountMonthReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountMonthReceiptButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountMonthReceiptButton.Location = new System.Drawing.Point(0, 0);
            this.AccountMonthReceiptButton.Name = "AccountMonthReceiptButton";
            this.AccountMonthReceiptButton.Size = new System.Drawing.Size(75, 50);
            this.AccountMonthReceiptButton.TabIndex = 0;
            this.AccountMonthReceiptButton.TabStop = false;
            this.AccountMonthReceiptButton.Text = "發票";
            this.AccountMonthReceiptButton.UseVisualStyleBackColor = true;
            // 
            // AccountMonthSelectPanel
            // 
            this.AccountMonthSelectPanel.BackColor = System.Drawing.Color.White;
            this.AccountMonthSelectPanel.Controls.Add(this.AccountMonthMonthComboBox);
            this.AccountMonthSelectPanel.Controls.Add(this.AccountMonthYearComboBox);
            this.AccountMonthSelectPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountMonthSelectPanel.Location = new System.Drawing.Point(0, 0);
            this.AccountMonthSelectPanel.Name = "AccountMonthSelectPanel";
            this.AccountMonthSelectPanel.Size = new System.Drawing.Size(1024, 50);
            this.AccountMonthSelectPanel.TabIndex = 0;
            // 
            // AccountMonthMonthComboBox
            // 
            this.AccountMonthMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountMonthMonthComboBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountMonthMonthComboBox.FormattingEnabled = true;
            this.AccountMonthMonthComboBox.Location = new System.Drawing.Point(133, 6);
            this.AccountMonthMonthComboBox.Name = "AccountMonthMonthComboBox";
            this.AccountMonthMonthComboBox.Size = new System.Drawing.Size(121, 35);
            this.AccountMonthMonthComboBox.TabIndex = 1;
            // 
            // AccountMonthYearComboBox
            // 
            this.AccountMonthYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountMonthYearComboBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountMonthYearComboBox.FormattingEnabled = true;
            this.AccountMonthYearComboBox.Location = new System.Drawing.Point(6, 6);
            this.AccountMonthYearComboBox.Name = "AccountMonthYearComboBox";
            this.AccountMonthYearComboBox.Size = new System.Drawing.Size(121, 35);
            this.AccountMonthYearComboBox.TabIndex = 0;
            // 
            // AccountMonthUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AccountMonthPanel);
            this.Name = "AccountMonthUserControl";
            this.Size = new System.Drawing.Size(1024, 600);
            this.AccountMonthPanel.ResumeLayout(false);
            this.AccountMonthStatisticsPanel.ResumeLayout(false);
            this.AccountMonthSalesPanel2.ResumeLayout(false);
            this.AccountMonthAchievementPanel.ResumeLayout(false);
            this.AccountMonthAchievementPanel.PerformLayout();
            this.AccountMonthMistakePanel.ResumeLayout(false);
            this.AccountMonthMistakePanel.PerformLayout();
            this.AccountMonthCashPanel.ResumeLayout(false);
            this.AccountMonthCashPanel.PerformLayout();
            this.AccountMonthSalesPanel.ResumeLayout(false);
            this.AccountMonthDeliveryPanel.ResumeLayout(false);
            this.AccountMonthDeliveryPanel.PerformLayout();
            this.AccountMonthCreditCardPanel.ResumeLayout(false);
            this.AccountMonthCreditCardPanel.PerformLayout();
            this.AccountMonthNoReceiptPanel.ResumeLayout(false);
            this.AccountMonthNoReceiptPanel.PerformLayout();
            this.AccountMonthReceiptPanel.ResumeLayout(false);
            this.AccountMonthReceiptPanel.PerformLayout();
            this.AccountMonthSelectPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AccountMonthPanel;
        private System.Windows.Forms.Panel AccountMonthStatisticsPanel;
        private System.Windows.Forms.Panel AccountMonthSalesPanel2;
        private System.Windows.Forms.Panel AccountMonthAchievementPanel;
        private System.Windows.Forms.TextBox AccountMonthAchievementTextBox;
        private System.Windows.Forms.Button AccountMonthAchievementButton;
        private System.Windows.Forms.Panel AccountMonthMistakePanel;
        private System.Windows.Forms.TextBox AccountMonthMistakeTextBox;
        private System.Windows.Forms.Button AccountMonthMistakeButton;
        private System.Windows.Forms.Panel AccountMonthCashPanel;
        private System.Windows.Forms.TextBox AccountMonthCashTextBox;
        private System.Windows.Forms.Button AccountMonthCashButton;
        private System.Windows.Forms.Panel AccountMonthSalesPanel;
        private System.Windows.Forms.Panel AccountMonthDeliveryPanel;
        private System.Windows.Forms.TextBox AccountMonthDeliveryTextBox;
        private System.Windows.Forms.Button AccountMonthDeliveryButton;
        private System.Windows.Forms.Panel AccountMonthCreditCardPanel;
        private System.Windows.Forms.TextBox AccountMonthCreditCardTextBox;
        private System.Windows.Forms.Button AccountMonthCreditCardButton;
        private System.Windows.Forms.Panel AccountMonthNoReceiptPanel;
        private System.Windows.Forms.TextBox AccountMonthNoReceiptTextBox;
        private System.Windows.Forms.Button AccountMonthNoReceiptButton;
        private System.Windows.Forms.Panel AccountMonthReceiptPanel;
        private System.Windows.Forms.TextBox AccountMonthReceiptTextBox;
        private System.Windows.Forms.Button AccountMonthReceiptButton;
        private System.Windows.Forms.Panel AccountMonthSelectPanel;
        private System.Windows.Forms.ComboBox AccountMonthMonthComboBox;
        private System.Windows.Forms.ComboBox AccountMonthYearComboBox;
    }
}
