using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CoffeeHome
{
    public partial class MainForm : Form
    {
        #region Main Form

        public MainForm()
        {
            InitializeComponent();
            InitializeHeaderPanelList();
            InitializeMainPanelList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'CoffeeHomeDataSet.RoastDegree' 資料表。您可以視需要進行移動或移除。
            this.RoastDegreeTableAdapter.Fill(this.CoffeeHomeDataSet.RoastDegree);
            // TODO: 這行程式碼會將資料載入 'CoffeeHomeDataSet.Account' 資料表。您可以視需要進行移動或移除。
            this.AccountTableAdapter.Fill(this.CoffeeHomeDataSet.Account);
            // TODO: 這行程式碼會將資料載入 'CoffeeHomeDataSet.TradeItem' 資料表。您可以視需要進行移動或移除。
            this.TradeItemTableAdapter.Fill(this.CoffeeHomeDataSet.TradeItem);
            // TODO: 這行程式碼會將資料載入 'CoffeeHomeDataSet.PaymentType' 資料表。您可以視需要進行移動或移除。
            this.PaymentTypeTableAdapter.Fill(this.CoffeeHomeDataSet.PaymentType);
            // TODO: 這行程式碼會將資料載入 'CoffeeHomeDataSet.Trade' 資料表。您可以視需要進行移動或移除。
            this.TradeTableAdapter.Fill(this.CoffeeHomeDataSet.Trade);
            // TODO: 這行程式碼會將資料載入 'CoffeeHomeDataSet.ItemType' 資料表。您可以視需要進行移動或移除。
            this.ItemTypeTableAdapter.Fill(this.CoffeeHomeDataSet.ItemType);
            // TODO: 這行程式碼會將資料載入 'CoffeeHomeDataSet.ItemShelf' 資料表。您可以視需要進行移動或移除。
            this.ItemShelfTableAdapter.Fill(this.CoffeeHomeDataSet.ItemShelf);
            // TODO: 這行程式碼會將資料載入 'CoffeeHomeDataSet.Item' 資料表。您可以視需要進行移動或移除。
            this.ItemTableAdapter.Fill(this.CoffeeHomeDataSet.Item);
            // TODO: 這行程式碼會將資料載入 'CoffeeHomeDataSet.Sex' 資料表。您可以視需要進行移動或移除。
            this.SexTableAdapter.Fill(this.CoffeeHomeDataSet.Sex);
            // TODO: 這行程式碼會將資料載入 'coffeeHomeDataSet.Member' 資料表。您可以視需要進行移動或移除。
            this.MemberTableAdapter.Fill(this.CoffeeHomeDataSet.Member);

            this.AccountDateTimePicker.Value = DateTime.Today;
        }

        #endregion

        #region Home

        private void NonMemberTradeButton_Click(object sender, EventArgs e)
        {
            TradeForm Form = TradeForm.NewTrade(0);
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Insert Trade
                CoffeeHomeDataSet.TradeRow TradeRow = this.CoffeeHomeDataSet.Trade.NewTradeRow();
                TradeRow.MemberID = 0;
                TradeRow.Time = DateTime.Now;
                TradeRow.PaymentTypeID = Form.PaymentTypeID;
                TradeRow.Receipt = Form.Receipt;
                TradeRow.Subtotal = Form.Subtotal;
                this.CoffeeHomeDataSet.Trade.AddTradeRow(TradeRow);
                this.TradeBindingSource.EndEdit();
                this.TradeTableAdapter.Update(this.CoffeeHomeDataSet.Trade);

                // Insert TradeItem
                int TradeID = TradeRow.ID;
                foreach (TradeItem Item in Form.TradeItems)
                {
                    CoffeeHomeDataSet.TradeItemRow TradeItemRow = this.CoffeeHomeDataSet.TradeItem.NewTradeItemRow();
                    TradeItemRow.TradeID = TradeID;
                    TradeItemRow.ItemID = Item.ItemID;
                    TradeItemRow.Amount = Item.Amount;
                    TradeItemRow.RoastDegreeID = Item.RoastDegreeID;
                    this.CoffeeHomeDataSet.TradeItem.AddTradeItemRow(TradeItemRow);
                }
                this.TradeItemBindingSource.EndEdit();
                this.TradeItemTableAdapter.Update(this.CoffeeHomeDataSet.TradeItem);
            }
        }

        private void SettingLabel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                SettingsForm Form = new SettingsForm();
                Form.ShowDialog();
            }
        }

        private void SettingLabel_MouseEnter(object sender, EventArgs e)
        {
            this.SettingLabel.BackColor = System.Drawing.Color.FromArgb(229, 217, 206);
        }

        private void SettingLabel_MouseLeave(object sender, EventArgs e)
        {
            this.SettingLabel.BackColor = System.Drawing.Color.FromArgb(255, 242, 230);
        }

        #endregion

        #region Utility

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

        private void SetIdleTimer()
        {
            IdleTimer.Interval = 1000 * 60 * 30;
            IdleTimer.Enabled = true;
        }

        private void IdleTimer_Tick(object sender, EventArgs e)
        {
            this.HideAllPanel();
            this.HomePanel.Visible = true;
            this.HomeHeaderPanel.Visible = true;
            this.IdleTimer.Enabled = false;
        }

        #endregion

        #region Side Panel Events

        private List<Control> MainPanelList = new List<Control>();
        private List<Control> HeaderPanelList = new List<Control>();

        private void HideAllPanel()
        {
            foreach (Control IControl in HeaderPanelList)
            {
                IControl.Visible = false;
            }
            foreach (Control IControl in MainPanelList)
            {
                IControl.Visible = false;
            }
        }

        private void InitializeMainPanelList()
        {
            MainPanelList.Add(this.HomePanel);
            MainPanelList.Add(this.MemberPanel);
            MainPanelList.Add(this.ItemPanel);
            MainPanelList.Add(this.AccountPanel);
            MainPanelList.Add(this.AccountMonthPanel);
            MainPanelList.Add(this.AccountYearUserControl);
        }

        private void InitializeHeaderPanelList()
        {
            HeaderPanelList.Add(this.HomeHeaderPanel);
            HeaderPanelList.Add(this.MemberHeaderPanel);
            HeaderPanelList.Add(this.ItemHeaderPanel);
            HeaderPanelList.Add(this.AccountHeaderPanel);
        }


        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.HideAllPanel();
            this.HomePanel.Visible = true;
            this.HomeHeaderPanel.Visible = true;
        }

        private void MemberButton_Click(object sender, EventArgs e)
        {
            this.HideAllPanel();
            this.MemberPanel.Visible = true;
            this.MemberHeaderPanel.Visible = true;
            this.MemberListDataGridView.DataSource = null;
            this.MemberListPanel.BringToFront();
            this.SetIdleTimer();
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            this.HideAllPanel();
            this.ItemPanel.Visible = true;
            this.ItemHeaderPanel.Visible = true;
            this.SetIdleTimer();
        }

        private void AccountLabel_MouseEnter(object sender, EventArgs e)
        {
            this.AccountLabel.BackColor = System.Drawing.Color.FromArgb(161, 206, 229);
        }

        private void AccountLabel_MouseLeave(object sender, EventArgs e)
        {
            this.AccountLabel.BackColor = System.Drawing.Color.FromArgb(179, 230, 255);
        }

        private void AccountLabel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.HideAllPanel();
                this.AccountPanel.Visible = true;
                this.AccountHeaderPanel.Visible = true;
                this.SetIdleTimer();
                this.ShowDayAccount();
            }
        }

        #endregion

        #region Member Events

        private void MemberNewButton_Click(object sender, EventArgs e)
        {
            // Show new member dialog
            MemberDataForm Form = new MemberDataForm();
            if (Form.ShowDialog() == DialogResult.OK)
            {
                CoffeeHomeDataSet.MemberRow NewMemberRow = this.CoffeeHomeDataSet.Member.NewMemberRow();
                NewMemberRow.Name = Form.MemberName;
                NewMemberRow.Sex = (byte)Form.Sex;
                NewMemberRow.PhoneNumber = Form.PhoneNumber;
                NewMemberRow.ZipCode = Form.ZipCode;
                NewMemberRow.Address = Form.Address;
                NewMemberRow.Email = Form.Email;
                NewMemberRow.Remarks = Form.Remarks;

                this.CoffeeHomeDataSet.Member.Rows.Add(NewMemberRow);
                this.MemberBindingSource.EndEdit();
                this.MemberTableAdapter.Update(this.CoffeeHomeDataSet.Member);

                this.MemberBindingSource.Filter = "ID = " + NewMemberRow.ID.ToString();
                this.MemberListDataGridView.DataSource = this.MemberBindingSource;
                this.MemberListPanel.BringToFront();
            }
        }

        private void MemberSearchButton_Click(object sender, EventArgs e)
        {
            // Show search dialog
            SearchMemberForm Form = new SearchMemberForm();
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string Query = string.Empty;
                if (Form.PhoneNumber != string.Empty)
                {
                    Query += "PhoneNumber LIKE '*" + Form.PhoneNumber + "*'";
                }
                if (Form.MemberName != string.Empty)
                {
                    if (Query != string.Empty)
                    {
                        Query += " AND ";
                    }
                    Query += "Name LIKE '*" + Form.MemberName + "*'";
                }
                if (Form.Remarks != string.Empty)
                {
                    if (Query != string.Empty)
                    {
                        Query += " AND ";
                    }
                    Query += "Remarks LIKE '*" + Form.Remarks + "*'";
                }

                this.MemberBindingSource.Filter = Query;
                this.MemberListDataGridView.DataSource = this.MemberBindingSource;
                this.MemberListPanel.BringToFront();
            }
        }

        private void MemberNewTradeButton_Click(object sender, EventArgs e)
        {
            if (this.MemberListDataGridView.SelectedRows.Count == 0)
                return;

            // Show trade dialog
            int MemberID = (int)this.MemberListDataGridView.SelectedRows[0].Cells[0].Value;
            TradeForm Form = TradeForm.NewTrade(MemberID);
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Insert Trade
                CoffeeHomeDataSet.TradeRow TradeRow = this.CoffeeHomeDataSet.Trade.NewTradeRow();
                TradeRow.MemberID = MemberID;
                TradeRow.Time = DateTime.Now;
                TradeRow.PaymentTypeID = Form.PaymentTypeID;
                TradeRow.Receipt = Form.Receipt;
                TradeRow.Subtotal = Form.Subtotal;
                this.CoffeeHomeDataSet.Trade.AddTradeRow(TradeRow);
                this.TradeBindingSource.EndEdit();
                this.TradeTableAdapter.Update(this.CoffeeHomeDataSet.Trade);

                // Insert TradeItem
                int TradeID = TradeRow.ID;
                foreach (TradeItem Item in Form.TradeItems)
                {
                    CoffeeHomeDataSet.TradeItemRow TradeItemRow = this.CoffeeHomeDataSet.TradeItem.NewTradeItemRow();
                    TradeItemRow.TradeID = TradeID;
                    TradeItemRow.ItemID = Item.ItemID;
                    TradeItemRow.Amount = Item.Amount;
                    TradeItemRow.RoastDegreeID = Item.RoastDegreeID;
                    this.CoffeeHomeDataSet.TradeItem.AddTradeItemRow(TradeItemRow);
                }
                this.TradeItemBindingSource.EndEdit();
                this.TradeItemTableAdapter.Update(this.CoffeeHomeDataSet.TradeItem);

                this.SetMemberDetailsPanel(MemberID);
            }
        }

        private void MemberDeleteButton_Click(object sender, EventArgs e)
        {
            bool Deleted = false;
            foreach (DataGridViewRow Row in this.MemberListDataGridView.SelectedRows)
            {
                int ID = (int)Row.Cells[0].Value;
                string Name = (string)Row.Cells[1].Value;
                DialogResult Result = MessageBox.Show("是否刪除會員 " + Name + " ?", "刪除會員", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    this.CoffeeHomeDataSet.Member.FindByID(ID).Delete();
                    Deleted = true;
                }
            }

            if (Deleted)
            {
                this.MemberBindingSource.EndEdit();
                this.MemberTableAdapter.Update(this.CoffeeHomeDataSet.Member);
                this.MemberListPanel.BringToFront();
            }
        }


        private void MemberEditButton_Click(object sender, EventArgs e)
        {
            if (this.MemberListDataGridView.SelectedRows.Count == 0)
                return;

            // Show trade dialog
            int MemberID = (int)this.MemberListDataGridView.SelectedRows[0].Cells[0].Value;
            CoffeeHomeDataSet.MemberRow MemberRow = this.CoffeeHomeDataSet.Member.FindByID(MemberID);
            MemberDataForm Form = new MemberDataForm(MemberRow);
            if (Form.ShowDialog() == DialogResult.OK)
            {
                MemberRow.Name = Form.MemberName;
                MemberRow.Sex = (byte)Form.Sex;
                MemberRow.PhoneNumber = Form.PhoneNumber;
                MemberRow.ZipCode = Form.ZipCode;
                MemberRow.Address = Form.Address;
                MemberRow.Email = Form.Email;
                MemberRow.Remarks = Form.Remarks;

                this.MemberBindingSource.EndEdit();
                this.MemberTableAdapter.Update(this.CoffeeHomeDataSet.Member);
            }
        }

        private void MemberNameLabel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (this.MemberListDataGridView.SelectedRows.Count == 0)
                    return;

                int MemberID = (int)this.MemberListDataGridView.SelectedRows[0].Cells[0].Value;
                CoffeeHomeDataSet.MemberRow MemberRow = this.CoffeeHomeDataSet.Member.FindByID(MemberID);
                MemberRemarksEditForm Form = new MemberRemarksEditForm();
                Form.Remarks = MemberRow.Remarks;
                if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MemberRow.Remarks = Form.Remarks;
                    this.MemberBindingSource.EndEdit();
                    this.MemberTableAdapter.Update(this.CoffeeHomeDataSet.Member);
                }
            }
        }

        private void MemberListDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int MemberID = (int)this.MemberListDataGridView[0, e.RowIndex].Value;
                this.SetMemberDetailsPanel(MemberID);
                this.MemberDetailsPanel.BringToFront();
            }
        }

        private void MemberListDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                byte SexCode = (byte)e.Value;
                e.Value = this.CoffeeHomeDataSet.Sex.FindByCode(SexCode).DisplayName;
            }
        }

        private void SetMemberDetailsPanel(int MemberID)
        {
            CoffeeHomeDataSet.MemberRow MemberRow = this.CoffeeHomeDataSet.Member.FindByID(MemberID);

            // Fill member data
            this.MemberNameTextBox.Text = MemberRow.Name;
            this.MemberSexTextBox.Text = this.CoffeeHomeDataSet.Sex.FindByCode(MemberRow.Sex).DisplayName;
            this.MemberPhoneNumberTextBox.Text = MemberRow.PhoneNumber;
            this.MemberZipCodeTextBox.Text = MemberRow.ZipCode;
            this.MemberAddressTextBox.Text = MemberRow.Address;
            this.MemberEmailTextBox.Text = MemberRow.Email;

            // Fill member trade details
            this.MemberDetailsDataGridView.Rows.Clear();
            DataRow[] TradeRows = this.CoffeeHomeDataSet.Trade.Select("MemberID = " + MemberID.ToString());
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

        private void MemberNameLabel_MouseEnter(object sender, EventArgs e)
        {
            this.MemberNameLabel.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void MemberNameLabel_MouseLeave(object sender, EventArgs e)
        {
            this.MemberNameLabel.BackColor = System.Drawing.Color.White;
        }

        #endregion

        #region Item Events

        private void ItemListButton_Click(object sender, EventArgs e)
        {
            this.ItemTableAdapter.Fill(this.CoffeeHomeDataSet.Item);
            this.ItemDataGridView.DataSource = this.CoffeeHomeDataSet.Item;
        }

        private void ItemSearchButton_Click(object sender, EventArgs e)
        {
            SearchItemForm Form = new SearchItemForm();
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string Query = string.Empty;
                if (Form.ItemName != string.Empty)
                {
                    Query += "Name LIKE '*" + Form.ItemName + "*'";
                }
                if (Form.Remarks != string.Empty)
                {
                    if (Query != string.Empty)
                    {
                        Query += " AND ";
                    }
                    Query += "Remarks LIKE '*" + Form.Remarks + "*'";
                }
                if (Form.TypeID != 0)
                {
                    if (Query != string.Empty)
                    {
                        Query += " AND ";
                    }
                    Query += "CONVERT(TypeID, 'System.String') LIKE '" + Form.TypeID.ToString() + "*'";
                }

                this.ItemBindingSource.Filter = Query;
                this.ItemDataGridView.DataSource = this.ItemBindingSource;
            }
        }

        private void ItemNewButton_Click(object sender, EventArgs e)
        {
            // Show new item dialog
            ItemDataForm Form = new ItemDataForm();
            if (Form.ShowDialog() == DialogResult.OK)
            {
                CoffeeHomeDataSet.ItemRow NewItemRow = this.CoffeeHomeDataSet.Item.NewItemRow();
                NewItemRow.Name = Form.ItemName;
                NewItemRow.TypeID = Form.TypeID;
                NewItemRow.Price = Form.Price;
                NewItemRow.Remarks = Form.Remarks;
                this.CoffeeHomeDataSet.Item.Rows.Add(NewItemRow);

                CoffeeHomeDataSet.ItemShelfRow ItemShelfRowToAdd = this.CoffeeHomeDataSet.ItemShelf.NewItemShelfRow();
                ItemShelfRowToAdd.ItemID = NewItemRow.ID;
                this.CoffeeHomeDataSet.ItemShelf.Rows.Add(ItemShelfRowToAdd);

                this.ItemBindingSource.EndEdit();
                this.ItemTableAdapter.Update(this.CoffeeHomeDataSet.Item);
                this.ItemShelfBindingSource.EndEdit();
                this.ItemShelfTableAdapter.Update(this.CoffeeHomeDataSet.ItemShelf);
                this.ItemDataGridView.DataSource = this.CoffeeHomeDataSet.Item;
            }
        }

        private void ItemEditTypeButton_Click(object sender, EventArgs e)
        {
            ItemTypeEditForm Form = new ItemTypeEditForm();
            Form.ShowDialog();
        }

        private void ItemAddToShelfButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in this.ItemDataGridView.SelectedRows)
            {
                CoffeeHomeDataSet.ItemShelfRow ItemShelfRowToAdd = this.CoffeeHomeDataSet.ItemShelf.NewItemShelfRow();
                ItemShelfRowToAdd.ItemID = (int)Row.Cells[0].Value;
                this.CoffeeHomeDataSet.ItemShelf.Rows.Add(ItemShelfRowToAdd);
            }

            this.ItemShelfBindingSource.EndEdit();
            this.ItemShelfTableAdapter.Update(this.CoffeeHomeDataSet.ItemShelf);
            this.ItemTableAdapter.Fill(this.CoffeeHomeDataSet.Item);
            this.ItemDataGridView.DataSource = this.CoffeeHomeDataSet.Item;
        }

        private void ItemRemoveFromShelfButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in this.ItemDataGridView.SelectedRows)
            {
                int ItemID = (int)Row.Cells[0].Value;
                CoffeeHomeDataSet.ItemShelfRow ItemShelfRowToDelete = this.CoffeeHomeDataSet.ItemShelf.FindByItemID(ItemID);
                if (ItemShelfRowToDelete != null)
                {
                    ItemShelfRowToDelete.Delete();
                }
            }

            this.ItemShelfBindingSource.EndEdit();
            this.ItemShelfTableAdapter.Update(this.CoffeeHomeDataSet.ItemShelf);
            this.ItemTableAdapter.Fill(this.CoffeeHomeDataSet.Item);
            this.ItemDataGridView.DataSource = this.CoffeeHomeDataSet.Item;
        }

        private void ItemDeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in this.ItemDataGridView.SelectedRows)
            {
                int ItemID = (int)Row.Cells[0].Value;
                string Name = (string)Row.Cells[1].Value;
                DialogResult Result = MessageBox.Show("是否刪除商品 " + Name + " ?", "刪除商品", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    this.CoffeeHomeDataSet.Item.FindByID(ItemID).Delete();
                    this.CoffeeHomeDataSet.ItemShelf.FindByItemID(ItemID).Delete();
                }
            }

            this.ItemBindingSource.EndEdit();
            this.ItemTableAdapter.Update(this.CoffeeHomeDataSet.Item);
            this.ItemShelfBindingSource.EndEdit();
            this.ItemShelfTableAdapter.Update(this.CoffeeHomeDataSet.ItemShelf);
            this.ItemDataGridView.DataSource = this.CoffeeHomeDataSet.Item;
        }

        private void ItemDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int ItemID = (int)this.ItemDataGridView[0, e.RowIndex].Value;
                CoffeeHomeDataSet.ItemRow ItemRow = this.CoffeeHomeDataSet.Item.FindByID(ItemID);
                ItemDataForm Form = new ItemDataForm(ItemRow);
                if (Form.ShowDialog() == DialogResult.OK)
                {
                    ItemRow.Name = Form.ItemName;
                    ItemRow.TypeID = Form.TypeID;
                    ItemRow.Price = Form.Price;
                    ItemRow.Remarks = Form.Remarks;

                    this.ItemBindingSource.EndEdit();
                    this.ItemTableAdapter.Update(this.CoffeeHomeDataSet.Item);
                }
            }
        }

        private void ItemDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int TypeID = (int)e.Value;
                CoffeeHomeDataSet.ItemTypeRow ItemTypeRow = this.CoffeeHomeDataSet.ItemType.FindByID(TypeID);
                if (ItemTypeRow != null)
                {
                    e.Value = GetItemTypeName(TypeID);
                }
            }
            if (e.ColumnIndex == 4)
            {
                int ItemID = (int)this.ItemDataGridView[0, e.RowIndex].Value;
                if (this.CoffeeHomeDataSet.ItemShelf.FindByItemID(ItemID) != null)
                {
                    e.Value = "上架";
                }
                else
                {
                    e.Value = "下架";
                }
            }
        }

        #endregion

        #region Account Events

        #region Year Account Events

        private void AccountYearButton_Click(object sender, EventArgs e)
        {
            this.HideAllPanel();
            this.AccountYearUserControl.Visible = true;
            this.AccountHeaderPanel.Visible = true;
            this.AccountYearUserControl.SetDataSet(this.CoffeeHomeDataSet);
            this.AccountYearUserControl.SetForm();
            this.AccountYearUserControl.ShowForm();
        }

        #endregion

        #region Month Account Functions

        private void AccountMonthButton_Click(object sender, EventArgs e)
        {
            this.HideAllPanel();
            this.AccountMonthPanel.Visible = true;
            this.AccountHeaderPanel.Visible = true;

            // Find the earliest year
            DataRow[] TradeRows = this.CoffeeHomeDataSet.Trade.Select("Time = Min(Time)");
            CoffeeHomeDataSet.TradeRow EarliestRow = TradeRows[0] as CoffeeHomeDataSet.TradeRow;
            DateTime EarliestDateTime = EarliestRow.Time;

            int RecentYear = DateTime.Today.Year;
            int EarliestYear = EarliestDateTime.Year;
            int RecentMonth = DateTime.Today.Month;

            this.AccountMonthYearComboBox.Items.Clear();
            for (int year = RecentYear; year >= EarliestYear; year--)
            {
                this.AccountMonthYearComboBox.Items.Add(year.ToString() + " 年");
            }
            this.AccountMonthYearComboBox.SelectedIndex = 0;

            this.AccountMonthMonthComboBox.Items.Clear();
            for (int month = 1; month <= 12; month++)
            {
                this.AccountMonthMonthComboBox.Items.Add(month.ToString() + " 月");
            }
            this.AccountMonthMonthComboBox.SelectedIndex = RecentMonth - 1;

            ShowMonthAccount();
        }

        private void AccountMonthYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowMonthAccount();
        }

        private void AccountMonthMonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowMonthAccount();
        }

        private void ShowMonthAccount()
        {
            if (this.AccountMonthYearComboBox.SelectedIndex == -1 || this.AccountMonthMonthComboBox.SelectedIndex == -1)
            {
                return;
            }
            int RecentYear = DateTime.Today.Year;
            int RecentMonth = DateTime.Today.Month;
            int SelectedYear = RecentYear - this.AccountMonthYearComboBox.SelectedIndex;
            int SelectedMonth = this.AccountMonthMonthComboBox.SelectedIndex + 1;
            DateTime FirstDayOfMonth = new DateTime(SelectedYear, SelectedMonth, 1);
            DateTime FirstDayOfNextMonth = FirstDayOfMonth.AddMonths(1);

            string TimeQuery = "Time >= #" + FirstDayOfMonth.ToShortDateString() + "# AND Time < #" + FirstDayOfNextMonth.ToShortDateString() + "#";
            string ReceiptQuery = "Receipt = 1";
            string NoReceiptQuery = "Receipt = 0";
            string CreditCardQuery = "PaymentTypeID = 2";
            string DeliveryQuery = "PaymentTypeID = 3";
            string CashQuery = "PaymentTypeID = 1";

            // Get data rows
            DataRow[] AccountRows = this.CoffeeHomeDataSet.Account.Select(TimeQuery);
            DataRow[] ReceiptRows = this.CoffeeHomeDataSet.Trade.Select(TimeQuery + " AND " + ReceiptQuery);
            DataRow[] NoReceiptRows = this.CoffeeHomeDataSet.Trade.Select(TimeQuery + " AND " + NoReceiptQuery);
            DataRow[] CredirCardtRows = this.CoffeeHomeDataSet.Trade.Select(TimeQuery + " AND " + CreditCardQuery);
            DataRow[] DeliveryRows = this.CoffeeHomeDataSet.Trade.Select(TimeQuery + " AND " + DeliveryQuery);
            DataRow[] CashRows = this.CoffeeHomeDataSet.Trade.Select(TimeQuery + " AND " + CashQuery);

            // Count subtotals
            int ReceiptSubtotal = this.CountSubtotal(ReceiptRows);
            int NoReceiptSubtotal = this.CountSubtotal(NoReceiptRows);
            int CreditCardSubtotal = this.CountSubtotal(CredirCardtRows);
            int DeliverySubtotal = this.CountSubtotal(DeliveryRows);
            int CashSubtotal = this.CountSubtotal(CashRows);

            // Show subtotals on TextBoxes
            this.AccountMonthReceiptTextBox.Text = ReceiptSubtotal.ToString();
            this.AccountMonthNoReceiptTextBox.Text = NoReceiptSubtotal.ToString();
            this.AccountMonthCreditCardTextBox.Text = CreditCardSubtotal.ToString();
            this.AccountMonthDeliveryTextBox.Text = DeliverySubtotal.ToString();
            this.AccountMonthCashTextBox.Text = CashSubtotal.ToString();

            // Count mistake
            int Mistake = CountMistake(AccountRows);
            this.AccountMonthMistakeTextBox.Text = Mistake.ToString();

            // Count achievement
            int Achievement = ReceiptSubtotal + NoReceiptSubtotal;
            this.AccountMonthAchievementTextBox.Text = Achievement.ToString();
        }

        #endregion

        #region Day Account Functions

        private DateTime Day;
        private DateTime NextDay;
        private CoffeeHomeDataSet.AccountRow AccountRow;

        private void AccountDayButton_Click(object sender, EventArgs e)
        {
            this.ShowDayAccount();
            this.HideAllPanel();
            this.AccountPanel.Visible = true;
            this.AccountHeaderPanel.Visible = true;
        }

        private void ShowDayAccount()
        {
            this.Day = this.AccountDateTimePicker.Value;
            this.NextDay = Day.AddDays(1);
            string TimeQuery = "Time >= #" + this.Day.ToShortDateString() + "# AND Time < #" + this.NextDay.ToShortDateString() + "#";

            // Load account row
            DataRow[] AccountRows = this.CoffeeHomeDataSet.Account.Select(TimeQuery);
            if (AccountRows.Length == 0)
            {
                this.AccountRow = this.CoffeeHomeDataSet.Account.NewAccountRow();
                this.AccountRow.Time = Day;
                this.AccountRow.WorkingCapital = int.Parse(ConfigurationManager.AppSettings["WorkingCapital"]);
                this.CoffeeHomeDataSet.Account.AddAccountRow(this.AccountRow);
                this.AccountBindingSource.EndEdit();
                this.AccountTableAdapter.Update(this.CoffeeHomeDataSet.Account);
            }
            else
            {
                this.AccountRow = this.CoffeeHomeDataSet.Account.FindByID((int)AccountRows[0][0]);
            }

            this.AccountDetailsDataGridView.Rows.Clear();
            this.LoadDayAccount();
            this.ShowAccountDetails();
        }

        private void LoadDayAccount()
        {
            int WorkingCapital = this.AccountRow.WorkingCapital;
            int Mistake = this.AccountRow.Mistake;
            int Mistake2 = this.AccountRow.Mistake2;
            int Mistake3 = this.AccountRow.Mistake3;

            this.WorkingCapitalTextBox.Text = WorkingCapital.ToString();
            this.MistakeTextBox.Text = Mistake.ToString();
            this.MistakeTextBox2.Text = Mistake2.ToString();
            this.MistakeTextBox3.Text = Mistake3.ToString();

            string TimeQuery = "Time >= #" + this.Day.ToShortDateString() + "# AND Time < #" + this.NextDay.ToShortDateString() + "#";
            string ReceiptQuery = "Receipt = 1";
            string NoReceiptQuery = "Receipt = 0";
            string CreditCardQuery = "PaymentTypeID = 2";
            string DeliveryQuery = "PaymentTypeID = 3";
            string CashQuery = "PaymentTypeID = 1";

            // Get data rows
            DataRow[] ReceiptRows = this.CoffeeHomeDataSet.Trade.Select(TimeQuery + " AND " + ReceiptQuery);
            DataRow[] NoReceiptRows = this.CoffeeHomeDataSet.Trade.Select(TimeQuery + " AND " + NoReceiptQuery);
            DataRow[] CredirCardtRows = this.CoffeeHomeDataSet.Trade.Select(TimeQuery + " AND " + CreditCardQuery);
            DataRow[] DeliveryRows = this.CoffeeHomeDataSet.Trade.Select(TimeQuery + " AND " + DeliveryQuery);
            DataRow[] CashRows = this.CoffeeHomeDataSet.Trade.Select(TimeQuery + " AND " + CashQuery);

            // Count subtotals
            int ReceiptSubtotal = this.CountSubtotal(ReceiptRows);
            int NoReceiptSubtotal = this.CountSubtotal(NoReceiptRows);
            int CreditCardSubtotal = this.CountSubtotal(CredirCardtRows);
            int DeliverySubtotal = this.CountSubtotal(DeliveryRows);
            int CashSubtotal = this.CountSubtotal(CashRows);

            // Show subtotals on TextBoxes
            this.AccountSalesReceiptTextBox.Text = ReceiptSubtotal.ToString();
            this.AccountSalesNoReceiptTextBox.Text = NoReceiptSubtotal.ToString();
            this.AccountSalesCreditCardTextBox.Text = CreditCardSubtotal.ToString();
            this.AccountSalesDeliveryTextBox.Text = DeliverySubtotal.ToString();
            this.AccountSalesCashTextBox.Text = CashSubtotal.ToString();

            // Count achievement
            int Achievement = ReceiptSubtotal + NoReceiptSubtotal;
            this.AchievementTextBox.Text = Achievement.ToString();

            int ReceiptWithMistake = ReceiptSubtotal + Mistake + Mistake2 + Mistake3;
            this.ReceiptWithMistakeTextBox.Text = ReceiptWithMistake.ToString();

            // Count and show Cash
            int CashWithWorkingCapital = CashSubtotal + WorkingCapital;
            this.CashWithWorkingCapitalTextBox.Text = CashWithWorkingCapital.ToString();
        }

        private int CountSubtotal(DataRow[] TradeRows)
        {
            int Subtotal = 0;
            foreach (CoffeeHomeDataSet.TradeRow TradeRow in TradeRows)
            {
                Subtotal += TradeRow.Subtotal;
            }
            return Subtotal;
        }

        private int CountMistake(DataRow[] AccountRows)
        {
            int Mistake = 0;
            foreach (CoffeeHomeDataSet.AccountRow AccountRow in AccountRows)
            {
                Mistake += AccountRow.Mistake + AccountRow.Mistake2 + AccountRow.Mistake3;
            }
            return Mistake;
        }

        private void ShowAccountDetails()
        {
            this.AccountDetailsDataGridView.Rows.Clear();
            string TimeQuery = "Time >= #" + this.Day.ToShortDateString() + "# AND Time < #" + this.NextDay.ToShortDateString() + "#";
            DataRow[] TradeRows = this.CoffeeHomeDataSet.Trade.Select(TimeQuery);
            foreach (CoffeeHomeDataSet.TradeRow TradeRow in TradeRows)
            {
                int MemberID = TradeRow.MemberID;
                CoffeeHomeDataSet.MemberRow MemberRow = this.CoffeeHomeDataSet.Member.FindByID(MemberID);
                string MemberName = (MemberRow != null) ? MemberRow.Name : "";
                string PaymentType = this.CoffeeHomeDataSet.PaymentType.FindByID(TradeRow.PaymentTypeID).Name;
                string Receipt = (TradeRow.Receipt) ? "O" : "X";
                this.AccountDetailsDataGridView.Rows.Add(
                    TradeRow.ID,
                    TradeRow.Time.ToShortTimeString(),
                    MemberName,
                    PaymentType,
                    Receipt,
                    "",
                    "",
                    "",
                    "",
                    TradeRow.Subtotal);

                DataRow[] TradeItemRows = this.CoffeeHomeDataSet.TradeItem.Select("TradeID = " + TradeRow.ID.ToString());
                foreach (CoffeeHomeDataSet.TradeItemRow TradeItemRow in TradeItemRows)
                {
                    int ItemID = TradeItemRow.ItemID;
                    CoffeeHomeDataSet.ItemRow ItemRow = this.CoffeeHomeDataSet.Item.FindByID(ItemID);
                    string RoastDegree = this.CoffeeHomeDataSet.RoastDegree.FindByID(TradeItemRow.RoastDegreeID).Name;
                    this.AccountDetailsDataGridView.Rows.Add(
                        TradeItemRow.TradeID,
                        "",
                        "",
                        "",
                        "",
                        ItemRow.Name,
                        RoastDegree,
                        TradeItemRow.Amount,
                        TradeItemRow.Amount * ItemRow.Price,
                        "");
                }
            }
        }

        private void AccountDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.ShowDayAccount();
        }

        private void WorkingCapitalTextBox_TextChanged(object sender, EventArgs e)
        {
            int WorkingCapital = 0;
            Int32.TryParse(this.WorkingCapitalTextBox.Text, out WorkingCapital);
            this.AccountRow.WorkingCapital = WorkingCapital;
        }

        private void MistakeTextBox_TextChanged(object sender, EventArgs e)
        {
            int Mistake = 0;
            Int32.TryParse(this.MistakeTextBox.Text, out Mistake);
            this.AccountRow.Mistake = Mistake;
            LoadDayAccount();
        }

        private void MistakeTextBox2_TextChanged(object sender, EventArgs e)
        {
            int Mistake2 = 0;
            Int32.TryParse(this.MistakeTextBox2.Text, out Mistake2);
            this.AccountRow.Mistake2 = Mistake2;
            LoadDayAccount();
        }

        private void MistakeTextBox3_TextChanged(object sender, EventArgs e)
        {
            int Mistake3 = 0;
            Int32.TryParse(this.MistakeTextBox3.Text, out Mistake3);
            this.AccountRow.Mistake3 = Mistake3;
            LoadDayAccount();
        }

        private void AccountDetailsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int TradeID = (int)this.AccountDetailsDataGridView[0, e.RowIndex].Value;
            TradeForm Form = TradeForm.EditTrade(TradeID);
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Find Trade Row
                CoffeeHomeDataSet.TradeRow TradeRow = this.CoffeeHomeDataSet.Trade.FindByID(TradeID);
                TradeRow.PaymentTypeID = Form.PaymentTypeID;
                TradeRow.Receipt = Form.Receipt;
                TradeRow.Subtotal = Form.Subtotal;
                this.TradeBindingSource.EndEdit();
                this.TradeTableAdapter.Update(this.CoffeeHomeDataSet.Trade);

                DataRow[] TradeItemRows = this.CoffeeHomeDataSet.TradeItem.Select("TradeID = " + TradeID.ToString());
                foreach (CoffeeHomeDataSet.TradeItemRow TradeItemRow in TradeItemRows)
                {
                    TradeItemRow.Delete();
                }
                foreach (TradeItem Item in Form.TradeItems)
                {
                    CoffeeHomeDataSet.TradeItemRow TradeItemRow = this.CoffeeHomeDataSet.TradeItem.NewTradeItemRow();
                    TradeItemRow.TradeID = TradeID;
                    TradeItemRow.ItemID = Item.ItemID;
                    TradeItemRow.Amount = Item.Amount;
                    TradeItemRow.RoastDegreeID = Item.RoastDegreeID;
                    this.CoffeeHomeDataSet.TradeItem.AddTradeItemRow(TradeItemRow);
                }
                this.TradeItemBindingSource.EndEdit();
                this.TradeItemTableAdapter.Update(this.CoffeeHomeDataSet.TradeItem);
                this.ShowAccountDetails();
            }
        }

        private void AccuontNewTradeButton_Click(object sender, EventArgs e)
        {
            TradeForm Form = TradeForm.NewTrade(0);
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Insert Trade
                CoffeeHomeDataSet.TradeRow TradeRow = this.CoffeeHomeDataSet.Trade.NewTradeRow();
                TradeRow.MemberID = 0;
                TradeRow.Time = DateTime.Now;
                TradeRow.PaymentTypeID = Form.PaymentTypeID;
                TradeRow.Receipt = Form.Receipt;
                TradeRow.Subtotal = Form.Subtotal;
                this.CoffeeHomeDataSet.Trade.AddTradeRow(TradeRow);
                this.TradeBindingSource.EndEdit();
                this.TradeTableAdapter.Update(this.CoffeeHomeDataSet.Trade);

                string PaymentType = this.CoffeeHomeDataSet.PaymentType.FindByID(TradeRow.PaymentTypeID).Name;
                string Receipt = (TradeRow.Receipt) ? "O" : "X";
                this.AccountDetailsDataGridView.Rows.Add(
                    TradeRow.ID,
                    TradeRow.Time.ToShortTimeString(),
                    "",
                    PaymentType,
                    Receipt,
                    "",
                    "",
                    "",
                    "",
                    TradeRow.Subtotal);

                // Insert TradeItem
                int TradeID = TradeRow.ID;
                foreach (TradeItem Item in Form.TradeItems)
                {
                    CoffeeHomeDataSet.TradeItemRow TradeItemRow = this.CoffeeHomeDataSet.TradeItem.NewTradeItemRow();
                    TradeItemRow.TradeID = TradeID;
                    TradeItemRow.ItemID = Item.ItemID;
                    TradeItemRow.Amount = Item.Amount;
                    TradeItemRow.RoastDegreeID = Item.RoastDegreeID;
                    this.CoffeeHomeDataSet.TradeItem.AddTradeItemRow(TradeItemRow);

                    CoffeeHomeDataSet.ItemRow ItemRow = this.CoffeeHomeDataSet.Item.FindByID(TradeItemRow.ItemID);
                    string RoastDegree = this.CoffeeHomeDataSet.RoastDegree.FindByID(TradeItemRow.RoastDegreeID).Name;
                    this.AccountDetailsDataGridView.Rows.Add(
                        TradeItemRow.TradeID,
                        "",
                        "",
                        "",
                        "",
                        ItemRow.Name,
                        RoastDegree,
                        TradeItemRow.Amount,
                        TradeItemRow.Amount * ItemRow.Price,
                        "");
                }
                this.TradeItemBindingSource.EndEdit();
                this.TradeItemTableAdapter.Update(this.CoffeeHomeDataSet.TradeItem);

                this.LoadDayAccount();
            }
        }

        #endregion

        private void AccountMonthPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

    }
}
