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
    public partial class ItemDataForm : Form
    {
        ItemTypeSelectionForm m_ItemTypeSelectionForm = new ItemTypeSelectionForm();

        public string ItemName
        {
            get { return this.NameTextBox.Text; }
            set { this.NameTextBox.Text = value; }
        }

        public int TypeID
        {
            get { return this.m_ItemTypeSelectionForm.ItemTypeID; }
            set { this.m_ItemTypeSelectionForm.ItemTypeID = value; }
        }

        public int Price
        {
            get
            {
                int Value = 0;
                Int32.TryParse(this.PriceTextBox.Text, out Value);
                return Value;
            }
            set { this.PriceTextBox.Text = value.ToString(); }
        }

        public string Remarks
        {
            get { return this.RemarksTextBox.Text; }
            set { this.RemarksTextBox.Text = value; }
        }

        public ItemDataForm()
        {
            InitializeComponent();
        }

        public ItemDataForm(CoffeeHomeDataSet.ItemRow ItemRow)
        {
            InitializeComponent();
            this.Text = "編輯商品";
            this.FormOKButton.Text = "確定";
            this.ItemName = ItemRow.Name;
            this.TypeID = ItemRow.TypeID;
            this.Price = ItemRow.Price;
            this.Remarks = ItemRow.Remarks;
            this.TypeSelectButton.Text = m_ItemTypeSelectionForm.ItemTypeFullName;
        }

        private void TypeSelectButton_Click(object sender, EventArgs e)
        {
            // Show ItemType selecting dialog
            if (m_ItemTypeSelectionForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.TypeSelectButton.Text = m_ItemTypeSelectionForm.ItemTypeFullName;
            }
        }

        private void FormOKButton_Click(object sender, EventArgs e)
        {
            if (this.ItemName == string.Empty)
                return;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

    }
}
