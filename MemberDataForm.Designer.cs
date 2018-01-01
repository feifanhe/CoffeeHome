namespace CoffeeHome
{
    partial class MemberDataForm
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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.FormOKButton = new System.Windows.Forms.Button();
            this.FormCancelButton = new System.Windows.Forms.Button();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.RemarksPanel = new System.Windows.Forms.Panel();
            this.RemarksTextBox = new System.Windows.Forms.TextBox();
            this.RemarksButton = new System.Windows.Forms.Button();
            this.EmailPanel = new System.Windows.Forms.Panel();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailButton = new System.Windows.Forms.Button();
            this.AddressPanel = new System.Windows.Forms.Panel();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressButton = new System.Windows.Forms.Button();
            this.ZipCodePanel = new System.Windows.Forms.Panel();
            this.ZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.ZipCodeButton = new System.Windows.Forms.Button();
            this.PhoneNumberPanel = new System.Windows.Forms.Panel();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberButton = new System.Windows.Forms.Button();
            this.SexPanel = new System.Windows.Forms.Panel();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.SexButton = new System.Windows.Forms.Button();
            this.NamePanel = new System.Windows.Forms.Panel();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameButton = new System.Windows.Forms.Button();
            this.FooterPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.RemarksPanel.SuspendLayout();
            this.EmailPanel.SuspendLayout();
            this.AddressPanel.SuspendLayout();
            this.ZipCodePanel.SuspendLayout();
            this.PhoneNumberPanel.SuspendLayout();
            this.SexPanel.SuspendLayout();
            this.NamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(464, 30);
            this.HeaderPanel.TabIndex = 0;
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.White;
            this.FooterPanel.Controls.Add(this.FormOKButton);
            this.FooterPanel.Controls.Add(this.FormCancelButton);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 551);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(464, 50);
            this.FooterPanel.TabIndex = 2;
            // 
            // FormOKButton
            // 
            this.FormOKButton.BackColor = System.Drawing.Color.White;
            this.FormOKButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FormOKButton.FlatAppearance.BorderSize = 0;
            this.FormOKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormOKButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormOKButton.Location = new System.Drawing.Point(224, 0);
            this.FormOKButton.Name = "FormOKButton";
            this.FormOKButton.Size = new System.Drawing.Size(120, 50);
            this.FormOKButton.TabIndex = 0;
            this.FormOKButton.Text = "新增";
            this.FormOKButton.UseVisualStyleBackColor = false;
            this.FormOKButton.Click += new System.EventHandler(this.FormOKButton_Click);
            // 
            // FormCancelButton
            // 
            this.FormCancelButton.BackColor = System.Drawing.Color.White;
            this.FormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FormCancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FormCancelButton.FlatAppearance.BorderSize = 0;
            this.FormCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormCancelButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormCancelButton.Location = new System.Drawing.Point(344, 0);
            this.FormCancelButton.Name = "FormCancelButton";
            this.FormCancelButton.Size = new System.Drawing.Size(120, 50);
            this.FormCancelButton.TabIndex = 1;
            this.FormCancelButton.Text = "取消";
            this.FormCancelButton.UseVisualStyleBackColor = false;
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.White;
            this.BodyPanel.Controls.Add(this.RemarksPanel);
            this.BodyPanel.Controls.Add(this.EmailPanel);
            this.BodyPanel.Controls.Add(this.AddressPanel);
            this.BodyPanel.Controls.Add(this.ZipCodePanel);
            this.BodyPanel.Controls.Add(this.PhoneNumberPanel);
            this.BodyPanel.Controls.Add(this.SexPanel);
            this.BodyPanel.Controls.Add(this.NamePanel);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 30);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(464, 521);
            this.BodyPanel.TabIndex = 1;
            // 
            // RemarksPanel
            // 
            this.RemarksPanel.BackColor = System.Drawing.Color.White;
            this.RemarksPanel.Controls.Add(this.RemarksTextBox);
            this.RemarksPanel.Controls.Add(this.RemarksButton);
            this.RemarksPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemarksPanel.Location = new System.Drawing.Point(0, 350);
            this.RemarksPanel.Name = "RemarksPanel";
            this.RemarksPanel.Size = new System.Drawing.Size(464, 100);
            this.RemarksPanel.TabIndex = 6;
            // 
            // RemarksTextBox
            // 
            this.RemarksTextBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RemarksTextBox.Location = new System.Drawing.Point(126, 3);
            this.RemarksTextBox.MaxLength = 256;
            this.RemarksTextBox.Multiline = true;
            this.RemarksTextBox.Name = "RemarksTextBox";
            this.RemarksTextBox.Size = new System.Drawing.Size(326, 94);
            this.RemarksTextBox.TabIndex = 1;
            // 
            // RemarksButton
            // 
            this.RemarksButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.RemarksButton.FlatAppearance.BorderSize = 0;
            this.RemarksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemarksButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RemarksButton.Location = new System.Drawing.Point(0, 0);
            this.RemarksButton.Name = "RemarksButton";
            this.RemarksButton.Size = new System.Drawing.Size(120, 100);
            this.RemarksButton.TabIndex = 0;
            this.RemarksButton.TabStop = false;
            this.RemarksButton.Text = "備註";
            this.RemarksButton.UseVisualStyleBackColor = true;
            // 
            // EmailPanel
            // 
            this.EmailPanel.BackColor = System.Drawing.Color.White;
            this.EmailPanel.Controls.Add(this.EmailTextBox);
            this.EmailPanel.Controls.Add(this.EmailButton);
            this.EmailPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmailPanel.Location = new System.Drawing.Point(0, 300);
            this.EmailPanel.Name = "EmailPanel";
            this.EmailPanel.Size = new System.Drawing.Size(464, 50);
            this.EmailPanel.TabIndex = 5;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EmailTextBox.Location = new System.Drawing.Point(126, 3);
            this.EmailTextBox.MaxLength = 50;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(326, 43);
            this.EmailTextBox.TabIndex = 1;
            // 
            // EmailButton
            // 
            this.EmailButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.EmailButton.FlatAppearance.BorderSize = 0;
            this.EmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmailButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EmailButton.Location = new System.Drawing.Point(0, 0);
            this.EmailButton.Name = "EmailButton";
            this.EmailButton.Size = new System.Drawing.Size(120, 50);
            this.EmailButton.TabIndex = 0;
            this.EmailButton.TabStop = false;
            this.EmailButton.Text = "Email";
            this.EmailButton.UseVisualStyleBackColor = true;
            // 
            // AddressPanel
            // 
            this.AddressPanel.BackColor = System.Drawing.Color.White;
            this.AddressPanel.Controls.Add(this.AddressTextBox);
            this.AddressPanel.Controls.Add(this.AddressButton);
            this.AddressPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddressPanel.Location = new System.Drawing.Point(0, 200);
            this.AddressPanel.Name = "AddressPanel";
            this.AddressPanel.Size = new System.Drawing.Size(464, 100);
            this.AddressPanel.TabIndex = 4;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AddressTextBox.Location = new System.Drawing.Point(126, 3);
            this.AddressTextBox.MaxLength = 100;
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(326, 94);
            this.AddressTextBox.TabIndex = 1;
            // 
            // AddressButton
            // 
            this.AddressButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddressButton.FlatAppearance.BorderSize = 0;
            this.AddressButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddressButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AddressButton.Location = new System.Drawing.Point(0, 0);
            this.AddressButton.Name = "AddressButton";
            this.AddressButton.Size = new System.Drawing.Size(120, 100);
            this.AddressButton.TabIndex = 0;
            this.AddressButton.TabStop = false;
            this.AddressButton.Text = "地址";
            this.AddressButton.UseVisualStyleBackColor = true;
            // 
            // ZipCodePanel
            // 
            this.ZipCodePanel.BackColor = System.Drawing.Color.White;
            this.ZipCodePanel.Controls.Add(this.ZipCodeTextBox);
            this.ZipCodePanel.Controls.Add(this.ZipCodeButton);
            this.ZipCodePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ZipCodePanel.Location = new System.Drawing.Point(0, 150);
            this.ZipCodePanel.Name = "ZipCodePanel";
            this.ZipCodePanel.Size = new System.Drawing.Size(464, 50);
            this.ZipCodePanel.TabIndex = 3;
            // 
            // ZipCodeTextBox
            // 
            this.ZipCodeTextBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ZipCodeTextBox.Location = new System.Drawing.Point(126, 3);
            this.ZipCodeTextBox.MaxLength = 10;
            this.ZipCodeTextBox.Name = "ZipCodeTextBox";
            this.ZipCodeTextBox.Size = new System.Drawing.Size(326, 43);
            this.ZipCodeTextBox.TabIndex = 1;
            // 
            // ZipCodeButton
            // 
            this.ZipCodeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ZipCodeButton.FlatAppearance.BorderSize = 0;
            this.ZipCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZipCodeButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ZipCodeButton.Location = new System.Drawing.Point(0, 0);
            this.ZipCodeButton.Name = "ZipCodeButton";
            this.ZipCodeButton.Size = new System.Drawing.Size(120, 50);
            this.ZipCodeButton.TabIndex = 0;
            this.ZipCodeButton.TabStop = false;
            this.ZipCodeButton.Text = "郵遞區號";
            this.ZipCodeButton.UseVisualStyleBackColor = true;
            // 
            // PhoneNumberPanel
            // 
            this.PhoneNumberPanel.BackColor = System.Drawing.Color.White;
            this.PhoneNumberPanel.Controls.Add(this.PhoneNumberTextBox);
            this.PhoneNumberPanel.Controls.Add(this.PhoneNumberButton);
            this.PhoneNumberPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PhoneNumberPanel.Location = new System.Drawing.Point(0, 100);
            this.PhoneNumberPanel.Name = "PhoneNumberPanel";
            this.PhoneNumberPanel.Size = new System.Drawing.Size(464, 50);
            this.PhoneNumberPanel.TabIndex = 2;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(126, 3);
            this.PhoneNumberTextBox.MaxLength = 50;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(326, 43);
            this.PhoneNumberTextBox.TabIndex = 1;
            // 
            // PhoneNumberButton
            // 
            this.PhoneNumberButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PhoneNumberButton.FlatAppearance.BorderSize = 0;
            this.PhoneNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PhoneNumberButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PhoneNumberButton.Location = new System.Drawing.Point(0, 0);
            this.PhoneNumberButton.Name = "PhoneNumberButton";
            this.PhoneNumberButton.Size = new System.Drawing.Size(120, 50);
            this.PhoneNumberButton.TabIndex = 0;
            this.PhoneNumberButton.TabStop = false;
            this.PhoneNumberButton.Text = "電話";
            this.PhoneNumberButton.UseVisualStyleBackColor = true;
            // 
            // SexPanel
            // 
            this.SexPanel.BackColor = System.Drawing.Color.White;
            this.SexPanel.Controls.Add(this.SexComboBox);
            this.SexPanel.Controls.Add(this.SexButton);
            this.SexPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SexPanel.Location = new System.Drawing.Point(0, 50);
            this.SexPanel.Name = "SexPanel";
            this.SexPanel.Size = new System.Drawing.Size(464, 50);
            this.SexPanel.TabIndex = 1;
            // 
            // SexComboBox
            // 
            this.SexComboBox.BackColor = System.Drawing.Color.White;
            this.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexComboBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.SexComboBox.Location = new System.Drawing.Point(126, 3);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(326, 42);
            this.SexComboBox.TabIndex = 1;
            // 
            // SexButton
            // 
            this.SexButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SexButton.FlatAppearance.BorderSize = 0;
            this.SexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SexButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SexButton.Location = new System.Drawing.Point(0, 0);
            this.SexButton.Name = "SexButton";
            this.SexButton.Size = new System.Drawing.Size(120, 50);
            this.SexButton.TabIndex = 0;
            this.SexButton.TabStop = false;
            this.SexButton.Text = "性別";
            this.SexButton.UseVisualStyleBackColor = true;
            // 
            // NamePanel
            // 
            this.NamePanel.BackColor = System.Drawing.Color.White;
            this.NamePanel.Controls.Add(this.NameTextBox);
            this.NamePanel.Controls.Add(this.NameButton);
            this.NamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NamePanel.Location = new System.Drawing.Point(0, 0);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(464, 50);
            this.NamePanel.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameTextBox.Location = new System.Drawing.Point(126, 3);
            this.NameTextBox.MaxLength = 50;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(326, 43);
            this.NameTextBox.TabIndex = 1;
            // 
            // NameButton
            // 
            this.NameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NameButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.NameButton.FlatAppearance.BorderSize = 0;
            this.NameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameButton.Location = new System.Drawing.Point(0, 0);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(120, 50);
            this.NameButton.TabIndex = 0;
            this.NameButton.TabStop = false;
            this.NameButton.Text = "姓名";
            this.NameButton.UseVisualStyleBackColor = false;
            // 
            // MemberDataForm
            // 
            this.AcceptButton = this.FormOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.FormCancelButton;
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MemberDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增會員";
            this.FooterPanel.ResumeLayout(false);
            this.BodyPanel.ResumeLayout(false);
            this.RemarksPanel.ResumeLayout(false);
            this.RemarksPanel.PerformLayout();
            this.EmailPanel.ResumeLayout(false);
            this.EmailPanel.PerformLayout();
            this.AddressPanel.ResumeLayout(false);
            this.AddressPanel.PerformLayout();
            this.ZipCodePanel.ResumeLayout(false);
            this.ZipCodePanel.PerformLayout();
            this.PhoneNumberPanel.ResumeLayout(false);
            this.PhoneNumberPanel.PerformLayout();
            this.SexPanel.ResumeLayout(false);
            this.NamePanel.ResumeLayout(false);
            this.NamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Button FormCancelButton;
        private System.Windows.Forms.Button FormOKButton;
        private System.Windows.Forms.Panel SexPanel;
        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Panel AddressPanel;
        private System.Windows.Forms.Panel ZipCodePanel;
        private System.Windows.Forms.Panel PhoneNumberPanel;
        private System.Windows.Forms.Panel RemarksPanel;
        private System.Windows.Forms.Panel EmailPanel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button NameButton;
        private System.Windows.Forms.Button RemarksButton;
        private System.Windows.Forms.Button EmailButton;
        private System.Windows.Forms.Button AddressButton;
        private System.Windows.Forms.Button ZipCodeButton;
        private System.Windows.Forms.Button PhoneNumberButton;
        private System.Windows.Forms.Button SexButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox ZipCodeTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox RemarksTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.ComboBox SexComboBox;
    }
}