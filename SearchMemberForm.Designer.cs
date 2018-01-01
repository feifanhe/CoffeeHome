namespace CoffeeHome
{
    partial class SearchMemberForm
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
            this.NamePanel = new System.Windows.Forms.Panel();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameButton = new System.Windows.Forms.Button();
            this.PhoneNumberPanel = new System.Windows.Forms.Panel();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberButton = new System.Windows.Forms.Button();
            this.FooterPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.RemarksPanel.SuspendLayout();
            this.NamePanel.SuspendLayout();
            this.PhoneNumberPanel.SuspendLayout();
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
            this.FooterPanel.Location = new System.Drawing.Point(0, 391);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(464, 50);
            this.FooterPanel.TabIndex = 2;
            // 
            // FormOKButton
            // 
            this.FormOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.FormOKButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FormOKButton.FlatAppearance.BorderSize = 0;
            this.FormOKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormOKButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormOKButton.Location = new System.Drawing.Point(224, 0);
            this.FormOKButton.Name = "FormOKButton";
            this.FormOKButton.Size = new System.Drawing.Size(120, 50);
            this.FormOKButton.TabIndex = 0;
            this.FormOKButton.Text = "確定";
            this.FormOKButton.UseVisualStyleBackColor = true;
            // 
            // FormCancelButton
            // 
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
            this.FormCancelButton.UseVisualStyleBackColor = true;
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.White;
            this.BodyPanel.Controls.Add(this.RemarksPanel);
            this.BodyPanel.Controls.Add(this.NamePanel);
            this.BodyPanel.Controls.Add(this.PhoneNumberPanel);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 30);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(464, 361);
            this.BodyPanel.TabIndex = 1;
            // 
            // RemarksPanel
            // 
            this.RemarksPanel.Controls.Add(this.RemarksTextBox);
            this.RemarksPanel.Controls.Add(this.RemarksButton);
            this.RemarksPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemarksPanel.Location = new System.Drawing.Point(0, 100);
            this.RemarksPanel.Name = "RemarksPanel";
            this.RemarksPanel.Size = new System.Drawing.Size(464, 100);
            this.RemarksPanel.TabIndex = 2;
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
            // NamePanel
            // 
            this.NamePanel.Controls.Add(this.NameTextBox);
            this.NamePanel.Controls.Add(this.NameButton);
            this.NamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NamePanel.Location = new System.Drawing.Point(0, 50);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(464, 50);
            this.NamePanel.TabIndex = 1;
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
            // PhoneNumberPanel
            // 
            this.PhoneNumberPanel.Controls.Add(this.PhoneNumberTextBox);
            this.PhoneNumberPanel.Controls.Add(this.PhoneNumberButton);
            this.PhoneNumberPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PhoneNumberPanel.Location = new System.Drawing.Point(0, 0);
            this.PhoneNumberPanel.Name = "PhoneNumberPanel";
            this.PhoneNumberPanel.Size = new System.Drawing.Size(464, 50);
            this.PhoneNumberPanel.TabIndex = 0;
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
            // SearchMemberForm
            // 
            this.AcceptButton = this.FormOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.FormCancelButton;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SearchMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "搜尋會員";
            this.FooterPanel.ResumeLayout(false);
            this.BodyPanel.ResumeLayout(false);
            this.RemarksPanel.ResumeLayout(false);
            this.RemarksPanel.PerformLayout();
            this.NamePanel.ResumeLayout(false);
            this.NamePanel.PerformLayout();
            this.PhoneNumberPanel.ResumeLayout(false);
            this.PhoneNumberPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Button FormOKButton;
        private System.Windows.Forms.Button FormCancelButton;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Panel RemarksPanel;
        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Panel PhoneNumberPanel;
        private System.Windows.Forms.Button PhoneNumberButton;
        private System.Windows.Forms.Button NameButton;
        private System.Windows.Forms.Button RemarksButton;
        private System.Windows.Forms.TextBox RemarksTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
    }
}