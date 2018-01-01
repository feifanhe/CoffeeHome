namespace CoffeeHome
{
    partial class ItemTypeEditForm
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
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.FormOKButton = new System.Windows.Forms.Button();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.ItemTypeTreeView = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddChildButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.CoffeeHomeDataSet = new CoffeeHome.CoffeeHomeDataSet();
            this.ItemTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemTypeTableAdapter = new CoffeeHome.CoffeeHomeDataSetTableAdapters.ItemTypeTableAdapter();
            this.TableAdapterManager = new CoffeeHome.CoffeeHomeDataSetTableAdapters.TableAdapterManager();
            this.FooterPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.White;
            this.FooterPanel.Controls.Add(this.FormOKButton);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 391);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(464, 50);
            this.FooterPanel.TabIndex = 1;
            // 
            // FormOKButton
            // 
            this.FormOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.FormOKButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FormOKButton.FlatAppearance.BorderSize = 0;
            this.FormOKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormOKButton.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormOKButton.Location = new System.Drawing.Point(344, 0);
            this.FormOKButton.Name = "FormOKButton";
            this.FormOKButton.Size = new System.Drawing.Size(120, 50);
            this.FormOKButton.TabIndex = 1;
            this.FormOKButton.Text = "確定";
            this.FormOKButton.UseVisualStyleBackColor = true;
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.White;
            this.BodyPanel.Controls.Add(this.ItemTypeTreeView);
            this.BodyPanel.Controls.Add(this.panel1);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 30);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(464, 361);
            this.BodyPanel.TabIndex = 2;
            // 
            // ItemTypeTreeView
            // 
            this.ItemTypeTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemTypeTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemTypeTreeView.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ItemTypeTreeView.FullRowSelect = true;
            this.ItemTypeTreeView.Indent = 25;
            this.ItemTypeTreeView.LabelEdit = true;
            this.ItemTypeTreeView.Location = new System.Drawing.Point(0, 0);
            this.ItemTypeTreeView.Name = "ItemTypeTreeView";
            this.ItemTypeTreeView.PathSeparator = ">";
            this.ItemTypeTreeView.ShowLines = false;
            this.ItemTypeTreeView.ShowPlusMinus = false;
            this.ItemTypeTreeView.ShowRootLines = false;
            this.ItemTypeTreeView.Size = new System.Drawing.Size(428, 361);
            this.ItemTypeTreeView.TabIndex = 1;
            this.ItemTypeTreeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.ItemTypeTreeView_AfterLabelEdit);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.AddChildButton);
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(428, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 361);
            this.panel1.TabIndex = 2;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Image = global::CoffeeHome.Properties.Resources.Delete;
            this.DeleteButton.Location = new System.Drawing.Point(0, 108);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(36, 36);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = global::CoffeeHome.Properties.Resources.Add;
            this.AddButton.Location = new System.Drawing.Point(0, 72);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(36, 36);
            this.AddButton.TabIndex = 0;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddChildButton
            // 
            this.AddChildButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddChildButton.FlatAppearance.BorderSize = 0;
            this.AddChildButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddChildButton.Image = global::CoffeeHome.Properties.Resources.AddTree;
            this.AddChildButton.Location = new System.Drawing.Point(0, 36);
            this.AddChildButton.Name = "AddChildButton";
            this.AddChildButton.Size = new System.Drawing.Size(36, 36);
            this.AddChildButton.TabIndex = 1;
            this.AddChildButton.UseVisualStyleBackColor = true;
            this.AddChildButton.Click += new System.EventHandler(this.AddChildButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Image = global::CoffeeHome.Properties.Resources.Edit;
            this.EditButton.Location = new System.Drawing.Point(0, 0);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(36, 36);
            this.EditButton.TabIndex = 3;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
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
            // ItemTypeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ItemTypeEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "編輯分類";
            this.FooterPanel.ResumeLayout(false);
            this.BodyPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeHomeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Button FormOKButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView ItemTypeTreeView;
        private CoffeeHomeDataSet CoffeeHomeDataSet;
        private System.Windows.Forms.BindingSource ItemTypeBindingSource;
        private CoffeeHomeDataSetTableAdapters.ItemTypeTableAdapter ItemTypeTableAdapter;
        private CoffeeHomeDataSetTableAdapters.TableAdapterManager TableAdapterManager;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddChildButton;
        private System.Windows.Forms.Button EditButton;
    }
}