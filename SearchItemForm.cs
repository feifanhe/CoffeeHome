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
    public partial class SearchItemForm : Form
    {
        ItemTypeSelectionForm m_ItemTypeSelectionForm = new ItemTypeSelectionForm();

        public string ItemName
        {
            get { return this.NameTextBox.Text; }
        }

        public int TypeID
        {
            get { return this.m_ItemTypeSelectionForm.ItemTypeID; }
        }

        public string Remarks
        {
            get { return this.RemarksTextBox.Text; }
        }

        public SearchItemForm()
        {
            InitializeComponent();
        }

        private void TypeSelectButton_Click(object sender, EventArgs e)
        {
            // Show ItemType selecting dialog
            if (m_ItemTypeSelectionForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.TypeSelectButton.Text = m_ItemTypeSelectionForm.ItemTypeFullName;
            }
        }

    }
}
