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

            try
            {
                this.HomeRichTextBox.LoadFile("CoffeeHome.rtf");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
            MainPanelList.Add(this.MemberListPanel);
            MainPanelList.Add(this.MemberDetailsPanel);
            MainPanelList.Add(this.ItemPanel);
            MainPanelList.Add(this.AccountDayUserControl);
            MainPanelList.Add(this.AccountMonthUserControl);
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
            this.MemberListPanel.Visible = true;
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
                this.SetIdleTimer();

                this.HideAllPanel();
                this.AccountDayUserControl.Visible = true;
                this.AccountHeaderPanel.Visible = true;
                this.AccountDayUserControl.SetDataSet(this.CoffeeHomeDataSet);
                this.AccountDayUserControl.SetForm();
                this.AccountDayUserControl.ShowForm();
            }
        }

        #endregion

        #region Home Events

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

        #region Member Events

        Dictionary<int, MemberDetailsUserControl> MemberDetailsMap = new Dictionary<int, MemberDetailsUserControl>();
        Dictionary<int, MemberDetailsTabUserControl> MemberDetailsTabMap = new Dictionary<int, MemberDetailsTabUserControl>();

        private MemberDetailsUserControl GetCurrentFocusMemberDetails()
        {
            if (this.MemberDetailsPanel.Controls.Count > 0)
            {
                return this.MemberDetailsPanel.Controls[0] as MemberDetailsUserControl;
            }
            return null;
        }

        private void MemberBackButton_Click(object sender, EventArgs e)
        {
            HideAllPanel();
            this.MemberHeaderPanel.Visible = true;
            this.MemberListPanel.Visible = true;
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

                HideAllPanel();
                this.MemberHeaderPanel.Visible = true;
                this.MemberListPanel.Visible = true;
            }
        }

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

                HideAllPanel();
                this.MemberHeaderPanel.Visible = true;
                this.MemberListPanel.Visible = true;
            }
        }

        private void MemberNewTradeButton_Click(object sender, EventArgs e)
        {
            MemberDetailsUserControl MemberDetails = GetCurrentFocusMemberDetails();
            if (MemberDetails == null) return;

            int MemberID = MemberDetails.MemberID;
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

                MemberDetails.RefreshForm();
            }
        }

        private void MemberEditButton_Click(object sender, EventArgs e)
        {
            MemberDetailsUserControl MemberDetails = GetCurrentFocusMemberDetails();
            if (MemberDetails == null) return;

            int MemberID = MemberDetails.MemberID;
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
                this.MemberTableAdapter.Update(this.CoffeeHomeDataSet.Member);

                MemberDetails.RefreshForm();
            }
        }

        private void MemberDeleteButton_Click(object sender, EventArgs e)
        {
            MemberDetailsUserControl MemberDetails = GetCurrentFocusMemberDetails();
            if (MemberDetails == null) return;

            int MemberID = MemberDetails.MemberID;
            string MemberName = MemberDetails.MemberName;
            DialogResult Result = MessageBox.Show("是否刪除會員 " + MemberName + " ?", "刪除會員", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                this.CoffeeHomeDataSet.Member.FindByID(MemberID).Delete();
                this.MemberTableAdapter.Update(this.CoffeeHomeDataSet.Member);
                this.CloseMember(MemberID);
            }
        }

        private void MemberListDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int MemberID = (int)this.MemberListDataGridView[0, e.RowIndex].Value;
                string MemberName = (string)this.MemberListDataGridView[1, e.RowIndex].Value;
                this.NewMemberDetails(MemberID);
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

        private void NewMemberDetails(int MemberID)
        {
            MemberDetailsUserControl MemberDetails = new MemberDetailsUserControl();
            this.MemberDetailsPanel.Controls.Add(MemberDetails);
            this.MemberDetailsMap.Add(MemberID, MemberDetails);
            MemberDetails.SetDataSet(CoffeeHomeDataSet);
            MemberDetails.SetForm(MemberID);
            MemberDetails.Dock = DockStyle.Fill;
            MemberDetails.BringToFront();

            MemberDetailsTabUserControl MemberDetailsTab = new MemberDetailsTabUserControl();
            this.MemberHeaderPanel.Controls.Add(MemberDetailsTab);
            this.MemberDetailsTabMap.Add(MemberID, MemberDetailsTab);
            MemberDetailsTab.SetForm(MemberID, MemberDetails.MemberName);
            MemberDetailsTab.ClickMemberName += new EventHandler(ClickMemberTab);
            MemberDetailsTab.ClickCloseButton += new EventHandler(CloseMemberTab);
            MemberDetailsTab.SetClickMemberName();
            MemberDetailsTab.SetClickCloseButton();
            MemberDetailsTab.Dock = DockStyle.Left;
            MemberDetailsTab.BringToFront();

            HideAllPanel();
            MemberDetailsPanel.Visible = true;
            MemberHeaderPanel.Visible = true;
        }

        private void ClickMemberTab(object sender, EventArgs e)
        {
            Button MemberNameButton = sender as Button;
            MemberDetailsTabUserControl MemberDetailsTab = MemberNameButton.Parent as MemberDetailsTabUserControl;
            int MemberID = MemberDetailsTab.MemberID;
            MemberDetailsMap[MemberID].BringToFront();

            HideAllPanel();
            MemberHeaderPanel.Visible = true;
            MemberDetailsPanel.Visible = true;
        }

        private void CloseMemberTab(object sender, EventArgs e)
        {
            Button CloseButton = sender as Button;
            MemberDetailsTabUserControl MemberDetailsTab = CloseButton.Parent as MemberDetailsTabUserControl;
            int MemberID = MemberDetailsTab.MemberID;
            this.CloseMember(MemberID);
        }

        private void CloseMember(int MemberID)
        {
            MemberDetailsUserControl MemberDetails = MemberDetailsMap[MemberID];
            MemberDetailsTabUserControl MemberDetailsTab = MemberDetailsTabMap[MemberID];

            this.MemberDetailsPanel.Controls.Remove(MemberDetails);
            this.MemberHeaderPanel.Controls.Remove(MemberDetailsTab);
            this.MemberDetailsMap.Remove(MemberID);
            this.MemberDetailsTabMap.Remove(MemberID);

            MemberDetails.Dispose();
            MemberDetailsTab.Dispose();

            if (!MemberDetailsPanel.HasChildren)
            {
                HideAllPanel();
                MemberHeaderPanel.Visible = true;
                MemberListPanel.Visible = true;
            }
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
                NewItemRow.OnShelf = true;
                this.CoffeeHomeDataSet.Item.Rows.Add(NewItemRow);

                this.ItemBindingSource.EndEdit();
                this.ItemTableAdapter.Update(this.CoffeeHomeDataSet.Item);
                this.ItemDataGridView.DataSource = this.CoffeeHomeDataSet.Item;
                this.ItemDataGridView.FirstDisplayedScrollingRowIndex = this.ItemDataGridView.Rows.Count - 1;
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
                int ItemID = (int)Row.Cells[0].Value;
                CoffeeHomeDataSet.ItemRow ItemRow = this.CoffeeHomeDataSet.Item.FindByID(ItemID);
                ItemRow.OnShelf = true;
            }

            this.ItemBindingSource.EndEdit();
            this.ItemTableAdapter.Update(this.CoffeeHomeDataSet.Item);
        }

        private void ItemRemoveFromShelfButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in this.ItemDataGridView.SelectedRows)
            {
                int ItemID = (int)Row.Cells[0].Value;
                CoffeeHomeDataSet.ItemRow ItemRow = this.CoffeeHomeDataSet.Item.FindByID(ItemID);
                ItemRow.OnShelf = false;
            }

            this.ItemBindingSource.EndEdit();
            this.ItemTableAdapter.Update(this.CoffeeHomeDataSet.Item);
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
                }
            }

            this.ItemBindingSource.EndEdit();
            this.ItemTableAdapter.Update(this.CoffeeHomeDataSet.Item);
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
                bool OnShelf = (bool)e.Value;
                if (OnShelf)
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
            this.AccountMonthUserControl.Visible = true;
            this.AccountHeaderPanel.Visible = true;
            this.AccountMonthUserControl.SetDataSet(this.CoffeeHomeDataSet);
            this.AccountMonthUserControl.SetForm();
            this.AccountMonthUserControl.ShowForm();
        }

        #endregion

        #region Day Account Functions

        private void AccountDayButton_Click(object sender, EventArgs e)
        {
            this.HideAllPanel();
            this.AccountDayUserControl.Visible = true;
            this.AccountHeaderPanel.Visible = true;
            this.AccountDayUserControl.SetDataSet(this.CoffeeHomeDataSet);
            this.AccountDayUserControl.SetForm();
            this.AccountDayUserControl.ShowForm();
        }

        #endregion

        #endregion

    }
}
