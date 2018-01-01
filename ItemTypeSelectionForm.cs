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
    public partial class ItemTypeSelectionForm : Form
    {
        private Dictionary<int, TreeNode> ItemTypeNodeMap = new Dictionary<int, TreeNode>();

        public int ItemTypeID
        {
            get { return (int)this.ItemTypeTreeView.SelectedNode.Tag; }
            set { this.ItemTypeTreeView.SelectedNode = this.ItemTypeNodeMap[value]; }
        }

        public string ItemTypeFullName
        {
            get { return this.ItemTypeTreeView.SelectedNode.FullPath; }
        }

        public ItemTypeSelectionForm()
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

    }
}
