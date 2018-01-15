namespace CoffeeHome
{
    partial class MemberDetailsUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MemberDetailsPanel = new System.Windows.Forms.Panel();
            this.MemberDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.MemberDetailsDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberDetailsItemDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberDetailsItemTypeDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberDetailsItemAmountDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberDetailsRoastDegreeDataGridViewTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberDetailsDataPanel = new System.Windows.Forms.Panel();
            this.MemberDetailsDataPanel2 = new System.Windows.Forms.Panel();
            this.MemberDetailsDataAddressPanel = new System.Windows.Forms.Panel();
            this.MemberAddressTextBox = new System.Windows.Forms.TextBox();
            this.MemberAddressButton = new System.Windows.Forms.Button();
            this.MemberDetailsDataZipCodePanel = new System.Windows.Forms.Panel();
            this.MemberZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.MemberZipCodeButton = new System.Windows.Forms.Button();
            this.MemberDetailsDataPhoneNumberPanel = new System.Windows.Forms.Panel();
            this.MemberPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.MemberPhoneNumberButton = new System.Windows.Forms.Button();
            this.MemberDetailsDataPanel1 = new System.Windows.Forms.Panel();
            this.MemberDetailsDataEmailPanel = new System.Windows.Forms.Panel();
            this.MemberEmailTextBox = new System.Windows.Forms.TextBox();
            this.MemberEmailButton = new System.Windows.Forms.Button();
            this.MemberDetailsDataSexPanel = new System.Windows.Forms.Panel();
            this.MemberSexTextBox = new System.Windows.Forms.TextBox();
            this.MemberSexButton = new System.Windows.Forms.Button();
            this.MemberDetailsDataNamePanel = new System.Windows.Forms.Panel();
            this.MemberNameTextBox = new System.Windows.Forms.TextBox();
            this.MemberNameLabel = new System.Windows.Forms.Label();
            this.MemberTableAdapter = new CoffeeHome.CoffeeHomeDataSetTableAdapters.MemberTableAdapter();
            this.MemberDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberDetailsDataGridView)).BeginInit();
            this.MemberDetailsDataPanel.SuspendLayout();
            this.MemberDetailsDataPanel2.SuspendLayout();
            this.MemberDetailsDataAddressPanel.SuspendLayout();
            this.MemberDetailsDataZipCodePanel.SuspendLayout();
            this.MemberDetailsDataPhoneNumberPanel.SuspendLayout();
            this.MemberDetailsDataPanel1.SuspendLayout();
            this.MemberDetailsDataEmailPanel.SuspendLayout();
            this.MemberDetailsDataSexPanel.SuspendLayout();
            this.MemberDetailsDataNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MemberDetailsPanel
            // 
            this.MemberDetailsPanel.BackColor = System.Drawing.Color.White;
            this.MemberDetailsPanel.Controls.Add(this.MemberDetailsDataGridView);
            this.MemberDetailsPanel.Controls.Add(this.MemberDetailsDataPanel);
            this.MemberDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.MemberDetailsPanel.Name = "MemberDetailsPanel";
            this.MemberDetailsPanel.Size = new System.Drawing.Size(1024, 600);
            this.MemberDetailsPanel.TabIndex = 2;
            // 
            // MemberDetailsDataGridView
            // 
            this.MemberDetailsDataGridView.AllowUserToAddRows = false;
            this.MemberDetailsDataGridView.AllowUserToDeleteRows = false;
            this.MemberDetailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MemberDetailsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.MemberDetailsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MemberDetailsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MemberDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberDetailsDataGridViewTextBox,
            this.MemberDetailsItemDataGridViewTextBox,
            this.MemberDetailsItemTypeDataGridViewTextBox,
            this.MemberDetailsItemAmountDataGridViewTextBox,
            this.MemberDetailsRoastDegreeDataGridViewTextBox});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MemberDetailsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.MemberDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberDetailsDataGridView.Location = new System.Drawing.Point(0, 100);
            this.MemberDetailsDataGridView.Name = "MemberDetailsDataGridView";
            this.MemberDetailsDataGridView.RowHeadersVisible = false;
            this.MemberDetailsDataGridView.RowTemplate.Height = 48;
            this.MemberDetailsDataGridView.Size = new System.Drawing.Size(1024, 500);
            this.MemberDetailsDataGridView.TabIndex = 1;
            // 
            // MemberDetailsDataGridViewTextBox
            // 
            this.MemberDetailsDataGridViewTextBox.HeaderText = "時間";
            this.MemberDetailsDataGridViewTextBox.Name = "MemberDetailsDataGridViewTextBox";
            // 
            // MemberDetailsItemDataGridViewTextBox
            // 
            this.MemberDetailsItemDataGridViewTextBox.FillWeight = 200F;
            this.MemberDetailsItemDataGridViewTextBox.HeaderText = "商品";
            this.MemberDetailsItemDataGridViewTextBox.Name = "MemberDetailsItemDataGridViewTextBox";
            // 
            // MemberDetailsItemTypeDataGridViewTextBox
            // 
            this.MemberDetailsItemTypeDataGridViewTextBox.HeaderText = "分類";
            this.MemberDetailsItemTypeDataGridViewTextBox.Name = "MemberDetailsItemTypeDataGridViewTextBox";
            // 
            // MemberDetailsItemAmountDataGridViewTextBox
            // 
            this.MemberDetailsItemAmountDataGridViewTextBox.FillWeight = 50F;
            this.MemberDetailsItemAmountDataGridViewTextBox.HeaderText = "數量";
            this.MemberDetailsItemAmountDataGridViewTextBox.Name = "MemberDetailsItemAmountDataGridViewTextBox";
            // 
            // MemberDetailsRoastDegreeDataGridViewTextBox
            // 
            this.MemberDetailsRoastDegreeDataGridViewTextBox.FillWeight = 50F;
            this.MemberDetailsRoastDegreeDataGridViewTextBox.HeaderText = "烘焙";
            this.MemberDetailsRoastDegreeDataGridViewTextBox.Name = "MemberDetailsRoastDegreeDataGridViewTextBox";
            // 
            // MemberDetailsDataPanel
            // 
            this.MemberDetailsDataPanel.Controls.Add(this.MemberDetailsDataPanel2);
            this.MemberDetailsDataPanel.Controls.Add(this.MemberDetailsDataPanel1);
            this.MemberDetailsDataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MemberDetailsDataPanel.Location = new System.Drawing.Point(0, 0);
            this.MemberDetailsDataPanel.Name = "MemberDetailsDataPanel";
            this.MemberDetailsDataPanel.Size = new System.Drawing.Size(1024, 100);
            this.MemberDetailsDataPanel.TabIndex = 0;
            // 
            // MemberDetailsDataPanel2
            // 
            this.MemberDetailsDataPanel2.Controls.Add(this.MemberDetailsDataAddressPanel);
            this.MemberDetailsDataPanel2.Controls.Add(this.MemberDetailsDataZipCodePanel);
            this.MemberDetailsDataPanel2.Controls.Add(this.MemberDetailsDataPhoneNumberPanel);
            this.MemberDetailsDataPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.MemberDetailsDataPanel2.Location = new System.Drawing.Point(0, 50);
            this.MemberDetailsDataPanel2.Name = "MemberDetailsDataPanel2";
            this.MemberDetailsDataPanel2.Size = new System.Drawing.Size(1024, 50);
            this.MemberDetailsDataPanel2.TabIndex = 1;
            // 
            // MemberDetailsDataAddressPanel
            // 
            this.MemberDetailsDataAddressPanel.Controls.Add(this.MemberAddressTextBox);
            this.MemberDetailsDataAddressPanel.Controls.Add(this.MemberAddressButton);
            this.MemberDetailsDataAddressPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MemberDetailsDataAddressPanel.Location = new System.Drawing.Point(512, 0);
            this.MemberDetailsDataAddressPanel.Name = "MemberDetailsDataAddressPanel";
            this.MemberDetailsDataAddressPanel.Size = new System.Drawing.Size(512, 50);
            this.MemberDetailsDataAddressPanel.TabIndex = 1;
            // 
            // MemberAddressTextBox
            // 
            this.MemberAddressTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberAddressTextBox.Location = new System.Drawing.Point(81, 5);
            this.MemberAddressTextBox.Name = "MemberAddressTextBox";
            this.MemberAddressTextBox.ReadOnly = true;
            this.MemberAddressTextBox.Size = new System.Drawing.Size(425, 39);
            this.MemberAddressTextBox.TabIndex = 1;
            // 
            // MemberAddressButton
            // 
            this.MemberAddressButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MemberAddressButton.FlatAppearance.BorderSize = 0;
            this.MemberAddressButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberAddressButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberAddressButton.Location = new System.Drawing.Point(0, 0);
            this.MemberAddressButton.Name = "MemberAddressButton";
            this.MemberAddressButton.Size = new System.Drawing.Size(75, 50);
            this.MemberAddressButton.TabIndex = 0;
            this.MemberAddressButton.Text = "地址";
            this.MemberAddressButton.UseVisualStyleBackColor = true;
            // 
            // MemberDetailsDataZipCodePanel
            // 
            this.MemberDetailsDataZipCodePanel.Controls.Add(this.MemberZipCodeTextBox);
            this.MemberDetailsDataZipCodePanel.Controls.Add(this.MemberZipCodeButton);
            this.MemberDetailsDataZipCodePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MemberDetailsDataZipCodePanel.Location = new System.Drawing.Point(256, 0);
            this.MemberDetailsDataZipCodePanel.Name = "MemberDetailsDataZipCodePanel";
            this.MemberDetailsDataZipCodePanel.Size = new System.Drawing.Size(256, 50);
            this.MemberDetailsDataZipCodePanel.TabIndex = 0;
            // 
            // MemberZipCodeTextBox
            // 
            this.MemberZipCodeTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberZipCodeTextBox.Location = new System.Drawing.Point(81, 5);
            this.MemberZipCodeTextBox.Name = "MemberZipCodeTextBox";
            this.MemberZipCodeTextBox.ReadOnly = true;
            this.MemberZipCodeTextBox.Size = new System.Drawing.Size(172, 39);
            this.MemberZipCodeTextBox.TabIndex = 1;
            // 
            // MemberZipCodeButton
            // 
            this.MemberZipCodeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MemberZipCodeButton.FlatAppearance.BorderSize = 0;
            this.MemberZipCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberZipCodeButton.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberZipCodeButton.Location = new System.Drawing.Point(0, 0);
            this.MemberZipCodeButton.Name = "MemberZipCodeButton";
            this.MemberZipCodeButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.MemberZipCodeButton.Size = new System.Drawing.Size(75, 50);
            this.MemberZipCodeButton.TabIndex = 0;
            this.MemberZipCodeButton.Text = "郵遞區號";
            this.MemberZipCodeButton.UseVisualStyleBackColor = true;
            // 
            // MemberDetailsDataPhoneNumberPanel
            // 
            this.MemberDetailsDataPhoneNumberPanel.Controls.Add(this.MemberPhoneNumberTextBox);
            this.MemberDetailsDataPhoneNumberPanel.Controls.Add(this.MemberPhoneNumberButton);
            this.MemberDetailsDataPhoneNumberPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MemberDetailsDataPhoneNumberPanel.Location = new System.Drawing.Point(0, 0);
            this.MemberDetailsDataPhoneNumberPanel.Name = "MemberDetailsDataPhoneNumberPanel";
            this.MemberDetailsDataPhoneNumberPanel.Size = new System.Drawing.Size(256, 50);
            this.MemberDetailsDataPhoneNumberPanel.TabIndex = 2;
            // 
            // MemberPhoneNumberTextBox
            // 
            this.MemberPhoneNumberTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberPhoneNumberTextBox.Location = new System.Drawing.Point(81, 5);
            this.MemberPhoneNumberTextBox.Name = "MemberPhoneNumberTextBox";
            this.MemberPhoneNumberTextBox.ReadOnly = true;
            this.MemberPhoneNumberTextBox.Size = new System.Drawing.Size(172, 39);
            this.MemberPhoneNumberTextBox.TabIndex = 1;
            // 
            // MemberPhoneNumberButton
            // 
            this.MemberPhoneNumberButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MemberPhoneNumberButton.FlatAppearance.BorderSize = 0;
            this.MemberPhoneNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberPhoneNumberButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberPhoneNumberButton.Location = new System.Drawing.Point(0, 0);
            this.MemberPhoneNumberButton.Name = "MemberPhoneNumberButton";
            this.MemberPhoneNumberButton.Size = new System.Drawing.Size(75, 50);
            this.MemberPhoneNumberButton.TabIndex = 0;
            this.MemberPhoneNumberButton.Text = "電話";
            this.MemberPhoneNumberButton.UseVisualStyleBackColor = true;
            // 
            // MemberDetailsDataPanel1
            // 
            this.MemberDetailsDataPanel1.Controls.Add(this.MemberDetailsDataEmailPanel);
            this.MemberDetailsDataPanel1.Controls.Add(this.MemberDetailsDataSexPanel);
            this.MemberDetailsDataPanel1.Controls.Add(this.MemberDetailsDataNamePanel);
            this.MemberDetailsDataPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.MemberDetailsDataPanel1.Location = new System.Drawing.Point(0, 0);
            this.MemberDetailsDataPanel1.Name = "MemberDetailsDataPanel1";
            this.MemberDetailsDataPanel1.Size = new System.Drawing.Size(1024, 50);
            this.MemberDetailsDataPanel1.TabIndex = 0;
            // 
            // MemberDetailsDataEmailPanel
            // 
            this.MemberDetailsDataEmailPanel.Controls.Add(this.MemberEmailTextBox);
            this.MemberDetailsDataEmailPanel.Controls.Add(this.MemberEmailButton);
            this.MemberDetailsDataEmailPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MemberDetailsDataEmailPanel.Location = new System.Drawing.Point(512, 0);
            this.MemberDetailsDataEmailPanel.Name = "MemberDetailsDataEmailPanel";
            this.MemberDetailsDataEmailPanel.Size = new System.Drawing.Size(512, 50);
            this.MemberDetailsDataEmailPanel.TabIndex = 2;
            // 
            // MemberEmailTextBox
            // 
            this.MemberEmailTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberEmailTextBox.Location = new System.Drawing.Point(81, 5);
            this.MemberEmailTextBox.Name = "MemberEmailTextBox";
            this.MemberEmailTextBox.ReadOnly = true;
            this.MemberEmailTextBox.Size = new System.Drawing.Size(425, 39);
            this.MemberEmailTextBox.TabIndex = 1;
            // 
            // MemberEmailButton
            // 
            this.MemberEmailButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MemberEmailButton.FlatAppearance.BorderSize = 0;
            this.MemberEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberEmailButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberEmailButton.Location = new System.Drawing.Point(0, 0);
            this.MemberEmailButton.Name = "MemberEmailButton";
            this.MemberEmailButton.Size = new System.Drawing.Size(75, 50);
            this.MemberEmailButton.TabIndex = 0;
            this.MemberEmailButton.Text = "Email";
            this.MemberEmailButton.UseVisualStyleBackColor = true;
            // 
            // MemberDetailsDataSexPanel
            // 
            this.MemberDetailsDataSexPanel.Controls.Add(this.MemberSexTextBox);
            this.MemberDetailsDataSexPanel.Controls.Add(this.MemberSexButton);
            this.MemberDetailsDataSexPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MemberDetailsDataSexPanel.Location = new System.Drawing.Point(256, 0);
            this.MemberDetailsDataSexPanel.Name = "MemberDetailsDataSexPanel";
            this.MemberDetailsDataSexPanel.Size = new System.Drawing.Size(256, 50);
            this.MemberDetailsDataSexPanel.TabIndex = 1;
            // 
            // MemberSexTextBox
            // 
            this.MemberSexTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberSexTextBox.Location = new System.Drawing.Point(81, 5);
            this.MemberSexTextBox.Name = "MemberSexTextBox";
            this.MemberSexTextBox.ReadOnly = true;
            this.MemberSexTextBox.Size = new System.Drawing.Size(172, 39);
            this.MemberSexTextBox.TabIndex = 1;
            // 
            // MemberSexButton
            // 
            this.MemberSexButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MemberSexButton.FlatAppearance.BorderSize = 0;
            this.MemberSexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberSexButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberSexButton.Location = new System.Drawing.Point(0, 0);
            this.MemberSexButton.Name = "MemberSexButton";
            this.MemberSexButton.Size = new System.Drawing.Size(75, 50);
            this.MemberSexButton.TabIndex = 0;
            this.MemberSexButton.Text = "性別";
            this.MemberSexButton.UseVisualStyleBackColor = true;
            // 
            // MemberDetailsDataNamePanel
            // 
            this.MemberDetailsDataNamePanel.Controls.Add(this.MemberNameTextBox);
            this.MemberDetailsDataNamePanel.Controls.Add(this.MemberNameLabel);
            this.MemberDetailsDataNamePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MemberDetailsDataNamePanel.Location = new System.Drawing.Point(0, 0);
            this.MemberDetailsDataNamePanel.Name = "MemberDetailsDataNamePanel";
            this.MemberDetailsDataNamePanel.Size = new System.Drawing.Size(256, 50);
            this.MemberDetailsDataNamePanel.TabIndex = 0;
            // 
            // MemberNameTextBox
            // 
            this.MemberNameTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberNameTextBox.Location = new System.Drawing.Point(81, 5);
            this.MemberNameTextBox.Name = "MemberNameTextBox";
            this.MemberNameTextBox.ReadOnly = true;
            this.MemberNameTextBox.Size = new System.Drawing.Size(172, 39);
            this.MemberNameTextBox.TabIndex = 1;
            // 
            // MemberNameLabel
            // 
            this.MemberNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MemberNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberNameLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberNameLabel.Location = new System.Drawing.Point(0, 0);
            this.MemberNameLabel.Name = "MemberNameLabel";
            this.MemberNameLabel.Size = new System.Drawing.Size(75, 50);
            this.MemberNameLabel.TabIndex = 0;
            this.MemberNameLabel.Text = "姓名";
            this.MemberNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MemberNameLabel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MemberNameLabel_MouseDoubleClick);
            this.MemberNameLabel.MouseEnter += new System.EventHandler(this.MemberNameLabel_MouseEnter);
            this.MemberNameLabel.MouseLeave += new System.EventHandler(this.MemberNameLabel_MouseLeave);
            // 
            // MemberTableAdapter
            // 
            this.MemberTableAdapter.ClearBeforeFill = true;
            // 
            // MemberDetailsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MemberDetailsPanel);
            this.Name = "MemberDetailsUserControl";
            this.Size = new System.Drawing.Size(1024, 600);
            this.MemberDetailsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MemberDetailsDataGridView)).EndInit();
            this.MemberDetailsDataPanel.ResumeLayout(false);
            this.MemberDetailsDataPanel2.ResumeLayout(false);
            this.MemberDetailsDataAddressPanel.ResumeLayout(false);
            this.MemberDetailsDataAddressPanel.PerformLayout();
            this.MemberDetailsDataZipCodePanel.ResumeLayout(false);
            this.MemberDetailsDataZipCodePanel.PerformLayout();
            this.MemberDetailsDataPhoneNumberPanel.ResumeLayout(false);
            this.MemberDetailsDataPhoneNumberPanel.PerformLayout();
            this.MemberDetailsDataPanel1.ResumeLayout(false);
            this.MemberDetailsDataEmailPanel.ResumeLayout(false);
            this.MemberDetailsDataEmailPanel.PerformLayout();
            this.MemberDetailsDataSexPanel.ResumeLayout(false);
            this.MemberDetailsDataSexPanel.PerformLayout();
            this.MemberDetailsDataNamePanel.ResumeLayout(false);
            this.MemberDetailsDataNamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MemberDetailsPanel;
        private System.Windows.Forms.DataGridView MemberDetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberDetailsDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberDetailsItemDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberDetailsItemTypeDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberDetailsItemAmountDataGridViewTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberDetailsRoastDegreeDataGridViewTextBox;
        private System.Windows.Forms.Panel MemberDetailsDataPanel;
        private System.Windows.Forms.Panel MemberDetailsDataPanel2;
        private System.Windows.Forms.Panel MemberDetailsDataAddressPanel;
        private System.Windows.Forms.TextBox MemberAddressTextBox;
        private System.Windows.Forms.Button MemberAddressButton;
        private System.Windows.Forms.Panel MemberDetailsDataZipCodePanel;
        private System.Windows.Forms.TextBox MemberZipCodeTextBox;
        private System.Windows.Forms.Button MemberZipCodeButton;
        private System.Windows.Forms.Panel MemberDetailsDataPhoneNumberPanel;
        private System.Windows.Forms.TextBox MemberPhoneNumberTextBox;
        private System.Windows.Forms.Button MemberPhoneNumberButton;
        private System.Windows.Forms.Panel MemberDetailsDataPanel1;
        private System.Windows.Forms.Panel MemberDetailsDataEmailPanel;
        private System.Windows.Forms.TextBox MemberEmailTextBox;
        private System.Windows.Forms.Button MemberEmailButton;
        private System.Windows.Forms.Panel MemberDetailsDataSexPanel;
        private System.Windows.Forms.TextBox MemberSexTextBox;
        private System.Windows.Forms.Button MemberSexButton;
        private System.Windows.Forms.Panel MemberDetailsDataNamePanel;
        private System.Windows.Forms.TextBox MemberNameTextBox;
        private System.Windows.Forms.Label MemberNameLabel;
        private CoffeeHomeDataSetTableAdapters.MemberTableAdapter MemberTableAdapter;
    }
}
