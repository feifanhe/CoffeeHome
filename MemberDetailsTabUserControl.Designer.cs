namespace CoffeeHome
{
    partial class MemberDetailsTabUserControl
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
            this.MemberNameButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MemberNameButton
            // 
            this.MemberNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(204)))));
            this.MemberNameButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MemberNameButton.FlatAppearance.BorderSize = 0;
            this.MemberNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberNameButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberNameButton.Location = new System.Drawing.Point(0, 0);
            this.MemberNameButton.Name = "MemberNameButton";
            this.MemberNameButton.Size = new System.Drawing.Size(96, 80);
            this.MemberNameButton.TabIndex = 6;
            this.MemberNameButton.Text = "會員名稱";
            this.MemberNameButton.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CloseButton.Location = new System.Drawing.Point(96, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(24, 80);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "╳";
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // MemberDetailsTabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MemberNameButton);
            this.Name = "MemberDetailsTabUserControl";
            this.Size = new System.Drawing.Size(120, 80);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MemberNameButton;
        private System.Windows.Forms.Button CloseButton;
    }
}
