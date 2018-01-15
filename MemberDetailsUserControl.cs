using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeHome
{
    public partial class MemberDetailsUserControl : UserControl
    {
        private CoffeeHomeDataSet CoffeeHomeDataSet;

        public int MemberID;
        public string MemberName;

        public MemberDetailsUserControl()
        {
            InitializeComponent();
        }

        public void SetDataSet(CoffeeHomeDataSet CoffeeHomeDataSet)
        {
            this.CoffeeHomeDataSet = CoffeeHomeDataSet;
        }

        public void SetForm(int MemberID)
        {
            this.MemberID = MemberID;
            this.RefreshForm();
        }

        public void RefreshForm()
        {
            CoffeeHomeDataSet.MemberRow MemberRow = this.CoffeeHomeDataSet.Member.FindByID(this.MemberID);

            // Fill member data
            this.MemberName = MemberRow.Name;
            this.MemberNameTextBox.Text = MemberRow.Name;
            this.MemberSexTextBox.Text = this.CoffeeHomeDataSet.Sex.FindByCode(MemberRow.Sex).DisplayName;
            this.MemberPhoneNumberTextBox.Text = MemberRow.PhoneNumber;
            this.MemberZipCodeTextBox.Text = MemberRow.ZipCode;
            this.MemberAddressTextBox.Text = MemberRow.Address;
            this.MemberEmailTextBox.Text = MemberRow.Email;

            // Fill member trade details
            this.MemberDetailsDataGridView.Rows.Clear();
            DataRow[] TradeRows = this.CoffeeHomeDataSet.Trade.Select("MemberID = " + this.MemberID.ToString());
            foreach (CoffeeHomeDataSet.TradeRow TradeRow in TradeRows)
            {
                DataRow[] TradeItemRows = this.CoffeeHomeDataSet.TradeItem.Select("TradeID = " + TradeRow.ID.ToString());
                for (int i = 0; i < TradeItemRows.Length; i++)
                {
                    CoffeeHomeDataSet.TradeItemRow TradeItemRow = TradeItemRows[i] as CoffeeHomeDataSet.TradeItemRow;
                    CoffeeHomeDataSet.ItemRow ItemRow = this.CoffeeHomeDataSet.Item.FindByID(TradeItemRow.ItemID);
                    string ItemName = (ItemRow == null) ? string.Empty : ItemRow.Name;
                    string ItemType = (ItemRow == null) ? string.Empty : GetItemTypeName(ItemRow.TypeID);
                    string RoastDegree = this.CoffeeHomeDataSet.RoastDegree.FindByID(TradeItemRow.RoastDegreeID).Name;
                    if (i == 0)
                    {
                        this.MemberDetailsDataGridView.Rows.Add(
                            TradeRow.Time.ToString(),
                            ItemName,
                            ItemType,
                            TradeItemRow.Amount,
                            RoastDegree);
                    }
                    else
                    {
                        this.MemberDetailsDataGridView.Rows.Add(
                            "",
                            ItemName,
                            ItemType,
                            TradeItemRow.Amount,
                            RoastDegree);
                    }
                }
            }
        }

        private void MemberNameLabel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                CoffeeHomeDataSet.MemberRow MemberRow = this.CoffeeHomeDataSet.Member.FindByID(this.MemberID);
                MemberRemarksEditForm Form = new MemberRemarksEditForm();
                Form.Remarks = MemberRow.Remarks;
                if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MemberRow.Remarks = Form.Remarks;
                    this.MemberTableAdapter.Update(this.CoffeeHomeDataSet.Member);
                }
            }
        }

        private void MemberNameLabel_MouseEnter(object sender, EventArgs e)
        {
            this.MemberNameLabel.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void MemberNameLabel_MouseLeave(object sender, EventArgs e)
        {
            this.MemberNameLabel.BackColor = System.Drawing.Color.White;
        }

        private string GetItemTypeName(int TypeID)
        {
            string TypeName = "";
            CoffeeHomeDataSet.ItemTypeRow ItemTypeRow;
            ItemTypeRow = this.CoffeeHomeDataSet.ItemType.FindByID(TypeID);
            if (ItemTypeRow == null)
            {
                return TypeName;
            }

            TypeName = ItemTypeRow.Name;
            TypeID /= 10;

            // Parse father type
            while (TypeID > 0)
            {
                ItemTypeRow = this.CoffeeHomeDataSet.ItemType.FindByID(TypeID);
                if (ItemTypeRow == null)
                {
                    break;
                }
                TypeName = ItemTypeRow.Name + ">" + TypeName;
                TypeID /= 10;
            }
            return TypeName;
        }

    }
}
