namespace CoffeeHome
{
    partial class SettingsForm
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
            this.WorkingCapitalPanel = new System.Windows.Forms.Panel();
            this.WorkingCapitalTextBox = new System.Windows.Forms.TextBox();
            this.WorkingCapitalButton = new System.Windows.Forms.Button();
            this.FooterPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.WorkingCapitalPanel.SuspendLayout();
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
            this.FooterPanel.TabIndex = 1;
            // 
            // FormOKButton
            // 
            this.FormOKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FormOKButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FormOKButton.FlatAppearance.BorderSize = 0;
            this.FormOKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormOKButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormOKButton.Location = new System.Drawing.Point(224, 0);
            this.FormOKButton.Name = "FormOKButton";
            this.FormOKButton.Size = new System.Drawing.Size(120, 50);
            this.FormOKButton.TabIndex = 1;
            this.FormOKButton.Text = "確定";
            this.FormOKButton.UseVisualStyleBackColor = true;
            this.FormOKButton.Click += new System.EventHandler(this.FormOKButton_Click);
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
            this.FormCancelButton.TabIndex = 0;
            this.FormCancelButton.Text = "取消";
            this.FormCancelButton.UseVisualStyleBackColor = true;
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.White;
            this.BodyPanel.Controls.Add(this.WorkingCapitalPanel);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 30);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(464, 361);
            this.BodyPanel.TabIndex = 2;
            // 
            // WorkingCapitalPanel
            // 
            this.WorkingCapitalPanel.Controls.Add(this.WorkingCapitalTextBox);
            this.WorkingCapitalPanel.Controls.Add(this.WorkingCapitalButton);
            this.WorkingCapitalPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorkingCapitalPanel.Location = new System.Drawing.Point(0, 0);
            this.WorkingCapitalPanel.Name = "WorkingCapitalPanel";
            this.WorkingCapitalPanel.Size = new System.Drawing.Size(464, 50);
            this.WorkingCapitalPanel.TabIndex = 0;
            // 
            // WorkingCapitalTextBox
            // 
            this.WorkingCapitalTextBox.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WorkingCapitalTextBox.Location = new System.Drawing.Point(126, 3);
            this.WorkingCapitalTextBox.MaxLength = 50;
            this.WorkingCapitalTextBox.Name = "WorkingCapitalTextBox";
            this.WorkingCapitalTextBox.Size = new System.Drawing.Size(326, 43);
            this.WorkingCapitalTextBox.TabIndex = 2;
            // 
            // WorkingCapitalButton
            // 
            this.WorkingCapitalButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.WorkingCapitalButton.FlatAppearance.BorderSize = 0;
            this.WorkingCapitalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkingCapitalButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WorkingCapitalButton.Location = new System.Drawing.Point(0, 0);
            this.WorkingCapitalButton.Name = "WorkingCapitalButton";
            this.WorkingCapitalButton.Size = new System.Drawing.Size(120, 50);
            this.WorkingCapitalButton.TabIndex = 1;
            this.WorkingCapitalButton.TabStop = false;
            this.WorkingCapitalButton.Text = "預設週轉金";
            this.WorkingCapitalButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
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
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "設定";
            this.FooterPanel.ResumeLayout(false);
            this.BodyPanel.ResumeLayout(false);
            this.WorkingCapitalPanel.ResumeLayout(false);
            this.WorkingCapitalPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Button FormCancelButton;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Panel WorkingCapitalPanel;
        private System.Windows.Forms.Button FormOKButton;
        private System.Windows.Forms.Button WorkingCapitalButton;
        private System.Windows.Forms.TextBox WorkingCapitalTextBox;
    }
}