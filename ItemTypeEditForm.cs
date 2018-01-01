using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeHome
{
    public partial class ItemTypeEditForm : Form
    {
        private Dictionary<int, TreeNode> ItemTypeNodeMap = new Dictionary<int, TreeNode>();

        public ItemTypeEditForm()
        {
            InitializeComponent();
            this.ItemTypeTableAdapter.Fill(this.CoffeeHomeDataSet.ItemType);
            InitializeItemTypeNodeTree();
        }

        private void InitializeItemTypeNodeTree()
        {
            foreach (CoffeeHomeDataSet.ItemTypeRow Row in this.CoffeeHomeDataSet.ItemType)
            {
                TreeNode Node = new TreeNode(Row.Name);
                Node.Tag = Row.ID;
                this.ItemTypeNodeMap[Row.ID] = Node;

                if (Row.FatherID == 0)
                {
                    this.ItemTypeTreeView.Nodes.Add(Node);
                }
                else
                {
                    this.ItemTypeNodeMap[Row.FatherID].Nodes.Add(Node);
                }
            }
        }

        private int GetNewTypeID(int FatherID)
        {
            TreeNodeCollection Nodes;
            if (FatherID == 0)
            {
                Nodes = this.ItemTypeTreeView.Nodes;
            }
            else
            {
                Nodes = this.ItemTypeNodeMap[FatherID].Nodes;
            }

            int MaxID = FatherID * 10;
            foreach (TreeNode Node in Nodes)
            {
                if ((int)Node.Tag > MaxID)
                    MaxID = (int)Node.Tag;
            }
            return MaxID + 1;
        }

        private void AddChildButton_Click(object sender, EventArgs e)
        {
            TreeNode FatherNode = this.ItemTypeTreeView.SelectedNode;
            if (FatherNode != null)
            {
                int FatherID = (int)FatherNode.Tag;
                int ID = GetNewTypeID(FatherID);

                TreeNode NewNode = FatherNode.Nodes.Add("新分類");
                FatherNode.Expand();
                this.ItemTypeNodeMap[ID] = NewNode;
                NewNode.Tag = ID;
                
                CoffeeHomeDataSet.ItemTypeRow ItemTypeRow = this.CoffeeHomeDataSet.ItemType.NewItemTypeRow();
                ItemTypeRow.ID = ID;
                ItemTypeRow.FatherID = FatherID;
                ItemTypeRow.Name = "新分類";
                this.CoffeeHomeDataSet.ItemType.AddItemTypeRow(ItemTypeRow);
                this.ItemTypeBindingSource.EndEdit();
                this.ItemTypeTableAdapter.Update(this.CoffeeHomeDataSet.ItemType);

                NewNode.BeginEdit();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            TreeNode Node = this.ItemTypeTreeView.SelectedNode;
            if (Node != null)
            {
                Node.BeginEdit();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int ID = GetNewTypeID(0);

            TreeNode NewNode = this.ItemTypeTreeView.Nodes.Add("新分類");
            this.ItemTypeNodeMap[ID] = NewNode;
            NewNode.Tag = ID;

            CoffeeHomeDataSet.ItemTypeRow ItemTypeRow = this.CoffeeHomeDataSet.ItemType.NewItemTypeRow();
            ItemTypeRow.ID = ID;
            ItemTypeRow.FatherID = 0;
            ItemTypeRow.Name = "新分類";
            this.CoffeeHomeDataSet.ItemType.AddItemTypeRow(ItemTypeRow);
            this.ItemTypeBindingSource.EndEdit();
            this.ItemTypeTableAdapter.Update(this.CoffeeHomeDataSet.ItemType);

            NewNode.BeginEdit();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            TreeNode Node = this.ItemTypeTreeView.SelectedNode;
            int ID = (int)Node.Tag;
            DialogResult Result = MessageBox.Show("是否刪除 " + Node.Text + " ?", "刪除分類", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                this.ItemTypeNodeMap.Remove(ID);
                Node.Remove();

                this.CoffeeHomeDataSet.ItemType.FindByID(ID).Delete();
                this.ItemTypeBindingSource.EndEdit();
                this.ItemTypeTableAdapter.Update(this.CoffeeHomeDataSet.ItemType);
            }
        }

        private void ItemTypeTreeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label == null)
                return;
            
            int ID = (int)e.Node.Tag;
            
            CoffeeHomeDataSet.ItemTypeRow ItemTypeRow = this.CoffeeHomeDataSet.ItemType.FindByID(ID);
            ItemTypeRow.Name = e.Label;
            this.ItemTypeBindingSource.EndEdit();
            this.ItemTypeTableAdapter.Update(this.CoffeeHomeDataSet.ItemType);
        }
    }
}
