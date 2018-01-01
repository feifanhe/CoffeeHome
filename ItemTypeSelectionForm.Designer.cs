namespace CoffeeHome
{
    partial class ItemTypeSelectionForm
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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.ItemTypeTreeView = new System.Windows.Forms.TreeView();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.FormOKButton = new System.Windows.Forms.Button();
            this.FormCancelButton = new System.Windows.Forms.Button();
            this.CoffeeHomeDataSet = new CoffeeHome.CoffeeHomeDataSet();
            this.ItemTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemTypeTableAdapter = new CoffeeHome.CoffeeHomeDataSetTableAdapters.ItemTypeTableAdapter();
            this.TableAdapterManager = new CoffeeHome.CoffeeHomeDataSetTableAdapters.TableAdapterManager();
            this.BodyPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeHomeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTypeBindingSource)).BeginInit();
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
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.White;
            this.BodyPanel.Controls.Add(this.ItemTypeTreeView);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 30);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(464, 361);
            this.BodyPanel.TabIndex = 1;
            // 
            // ItemTypeTreeView
            // 
            this.ItemTypeTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemTypeTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemTypeTreeView.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ItemTypeTreeView.FullRowSelect = true;
            this.ItemTypeTreeView.Indent = 25;
            this.ItemTypeTreeView.Location = new System.Drawing.Point(0, 0);
            this.ItemTypeTreeView.Name = "ItemTypeTreeView";
            this.ItemTypeTreeView.PathSeparator = ">";
            this.ItemTypeTreeView.ShowLines = false;
            this.ItemTypeTreeView.ShowPlusMinus = false;
            this.ItemTypeTreeView.ShowRootLines = false;
            this.ItemTypeTreeView.Size = new System.Drawing.Size(464, 361);
            this.ItemTypeTreeView.TabIndex = 0;
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
            // CoffeeHomeDataSet
            // 
            this.CoffeeHomeDataSet.DataSetName = "CoffeeHomeDataSet";
            this.CoffeeHomeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ItemTypeBindingSource
            // 
            this.ItemTypeBindingSource.DataMember = "ItemType";
            this.ItemTypeBindingSource.DataSource = this.CoffeeHomeDataSet;
            // 
            // ItemTypeTableAdapter
            // 
            this.ItemTypeTableAdapter.ClearBeforeFill = true;
            // 
            // TableAdapterManager
            // 
            this.TableAdapterManager.AccountTableAdapter = null;
            this.TableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.TableAdapterManager.ItemShelfTableAdapter = null;
            this.TableAdapterManager.ItemTableAdapter = null;
            this.TableAdapterManager.ItemTypeTableAdapter = this.ItemTypeTableAdapter;
            this.TableAdapterManager.MemberTableAdapter = null;
            this.TableAdapterManager.PaymentTypeTableAdapter = null;
            this.TableAdapterManager.RoastDegreeTableAdapter = null;
            this.TableAdapterManager.SexTableAdapter = null;
            this.TableAdapterManager.TradeItemTableAdapter = null;
            this.TableAdapterManager.TradeTableAdapter = null;
            this.TableAdapterManager.UpdateOrder = CoffeeHome.CoffeeHomeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ItemTypeSelectionForm
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
            this.Name = "ItemTypeSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "商品分類";
            this.BodyPanel.ResumeLayout(false);
            this.FooterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeHomeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Button FormOKButton;
        private System.Windows.Forms.Button FormCancelButton;
        private System.Windows.Forms.TreeView ItemTypeTreeView;
        private CoffeeHomeDataSet CoffeeHomeDataSet;
        private System.Windows.Forms.BindingSource ItemTypeBindingSource;
        private CoffeeHomeDataSetTableAdapters.ItemTypeTableAdapter ItemTypeTableAdapter;
        private CoffeeHomeDataSetTableAdapters.TableAdapterManager TableAdapterManager;
    }
}