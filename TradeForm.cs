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
    public partial class TradeForm : Form
    {
        private int ID;
        private int MemberID;
        private List<TradeItem> TradeItemList = new List<TradeItem>();
        private int SelectedTypeID = 0;
        private string SearchPattern = string.Empty;

        private TradeForm()
        {
            InitializeComponent();

            // TODO: 這行程式碼會將資料載入 'CoffeeHomeDataSet.TradeItem' 資料表。您可以視需要進行移動或移除。
            this.TradeItemTableAdapter.Fill(this.CoffeeHomeDataSet.TradeItem);
            // TODO: 這行程式碼會將資料載入 'CoffeeHomeDataSet.Trade' 資料表。您可以視需要進行移動或移除。
            this.TradeTableAdapter.Fill(this.CoffeeHomeDataSet.Trade);
            // TODO: 這行程式碼會將資料載入 'CoffeeHomeDataSet.Member' 資料表。您可以視需要進行移動或移除。
            this.MemberTableAdapter.Fill(this.CoffeeHomeDataSet.Member);
            // TODO: 這行程式碼會將資料載入 'CoffeeHomeDataSet.PaymentType' 資料表。您可以視需要進行移動或移除。
            this.PaymentTypeTableAdapter.Fill(this.CoffeeHomeDataSet.PaymentType);
            // TODO: 這行程式碼會將資料載入 'CoffeeHomeDataSet.ItemType' 資料表。您可以視需要進行移動或移除。
            this.ItemTypeTableAdapter.Fill(this.CoffeeHomeDataSet.ItemType);
            // TODO: 這行程式碼會將資料載入 'CoffeeHomeDataSet.RoastDegree' 資料表。您可以視需要進行移動或移除。
            this.RoastDegreeTableAdapter.Fill(this.CoffeeHomeDataSet.RoastDegree);
            // TODO: 這行程式碼會將資料載入 'CoffeeHomeDataSet.ItemShelf' 資料表。您可以視需要進行移動或移除。
            this.ItemShelfTableAdapter.Fill(this.CoffeeHomeDataSet.ItemShelf);
            // TODO: 這行程式碼會將資料載入 'coffeeHomeDataSet.Item' 資料表。您可以視需要進行移動或移除。
            this.ItemTableAdapter.Fill(this.CoffeeHomeDataSet.Item);

            ShowShelfDataGridView();
            InitializeItemTypeSelectMenu();
        }

        public static TradeForm NewTrade(int MemberID)
        {
            TradeForm Form = new TradeForm();
            Form.MemberID = MemberID;
            return Form;
        }

        public static TradeForm EditTrade(int TradeID)
        {
            TradeForm Form = new TradeForm();
            Form.Text = "編輯交易";
            Form.FormOKButton.Text = "確定";
            Form.ID = TradeID;
            Form.ShowTradeDetails();
            return Form;
        }

        public int TradeID
        {
            get { return this.ID; }
        }

        public int PaymentTypeID
        {
            get
            {
                return (int)this.PaymentTypeComboBox.SelectedValue;
            }
            set
            {
                this.PaymentTypeComboBox.SelectedValue = value;
            }
        }

        public bool Receipt
        {
            get
            {
                return this.ReceiptCheckBox.Checked;
            }
            set
            {
                this.ReceiptCheckBox.Checked = value;
            }
        }

        public int Subtotal
        {
            get
            {
                int Value = 0;
                Int32.TryParse(this.SubtotalTextBox.Text, out Value);
                return Value;
            }
            set
            {
                this.SubtotalTextBox.Text = value.ToString();
            }
        }

        public TradeItem[] TradeItems
        {
            get
            {
                this.TradeItemList.Clear();
                foreach (DataGridViewRow Row in this.TradeItemDataGridView.Rows)
                {
                    TradeItem TradeItem = new TradeItem();
                    TradeItem.ItemID = (int)Row.Cells[0].Value;
                    int Amount = 0;
                    Int32.TryParse(Row.Cells[5].Value.ToString(), out Amount);
                    TradeItem.Amount = Amount;
                    TradeItem.RoastDegreeID = (int)Row.Cells[3].Value;
                    this.TradeItemList.Add(TradeItem);
                }
                return this.TradeItemList.ToArray();
            }
        }

        private void ShowTradeDetails()
        {
            CoffeeHomeDataSet.TradeRow TradeRow = this.CoffeeHomeDataSet.Trade.FindByID(this.ID);
            this.MemberID = TradeRow.MemberID;
            this.PaymentTypeID = TradeRow.PaymentTypeID;
            this.Receipt = TradeRow.Receipt;
            this.Subtotal = TradeRow.Subtotal;
            ShowTradeItems();
        }

        private void ShowTradeItems()
        {
            DataRow[] Rows = this.CoffeeHomeDataSet.TradeItem.Select("TradeID = " + ID.ToString());
            foreach (CoffeeHomeDataSet.TradeItemRow Row in Rows)
            {
                CoffeeHomeDataSet.ItemRow ItemRow = this.CoffeeHomeDataSet.Item.FindByID(Row.ItemID);
                this.TradeItemDataGridView.Rows.Add(
                    Row.ItemID,
                    ItemRow.Name,
                    this.GetItemTypeName(ItemRow.TypeID),
                    Row.RoastDegreeID,  // Roast degree
                    ItemRow.Price,
                    Row.Amount,  // Amount
                    ItemRow.Price * Row.Amount);
            }
            UpdateSubtotalTextBox();
        }

        private void InitializeShelfDataGridView()
        {
            foreach (CoffeeHomeDataSet.ItemShelfRow ItemShelfRow in this.CoffeeHomeDataSet.ItemShelf)
            {
                CoffeeHomeDataSet.ItemRow ItemRow = this.CoffeeHomeDataSet.Item.FindByID(ItemShelfRow.ItemID);
                this.ShelfDataGridView.Rows.Add(
                    ItemShelfRow.ItemID,
                    ItemRow.Name,
                    this.GetItemTypeName(ItemRow.TypeID),
                    ItemRow.Price);
            }
        }

        private void UpdateSubtotalTextBox()
        {
            int Subtotal = 0;
            foreach (DataGridViewRow Row in this.TradeItemDataGridView.Rows)
            {
                int Price = (int)Row.Cells[4].Value;
                int Amount = 0;
                Int32.TryParse(Row.Cells[5].Value.ToString(), out Amount);
                Subtotal += Price * Amount;
            }
            this.AutoSubtotalTextBox.Text = Subtotal.ToString();
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

        private void TradeItemDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                // Subtotal
                int Price = (int)this.TradeItemDataGridView[4, e.RowIndex].Value;
                int Amount = 0;
                Int32.TryParse(this.TradeItemDataGridView[5, e.RowIndex].Value.ToString(), out Amount);
                e.Value = Price * Amount;
            }
        }

        private void TradeItemDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) // Amount column
            {
                int Amount = 0;
                if (Int32.TryParse(this.TradeItemDataGridView[5, e.RowIndex].Value.ToString(), out Amount))
                {
                    int Price = (int)this.TradeItemDataGridView[4, e.RowIndex].Value;
                    this.TradeItemDataGridView[6, e.RowIndex].Value = Price * Amount;
                    UpdateSubtotalTextBox();
                }
                else
                {
                    this.TradeItemDataGridView[5, e.RowIndex].Value = "0";
                }
            }
        }

        private void FormOKButton_Click(object sender, EventArgs e)
        {
            if (this.SubtotalTextBox.Text == string.Empty)
                return;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void InitializeItemTypeSelectMenu()
        {
            this.ShowTypeToolStrip(this.ItemTypeSelectMenuStrip.Items, 0);
        }

        private void ShowTypeToolStrip(ToolStripItemCollection Collection, int TypeID)
        {
            DataRow[] ItemTypeRows = this.CoffeeHomeDataSet.ItemType.Select("FatherID = " + TypeID.ToString());
            foreach (CoffeeHomeDataSet.ItemTypeRow ItemTypeRow in ItemTypeRows)
            {
                ToolStripMenuItem Item = new ToolStripMenuItem(ItemTypeRow.Name, null, ItemSelectItem_onClick) as ToolStripMenuItem;
                Item.Tag = ItemTypeRow.ID;
                Item.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                ShowTypeToolStrip(Item.DropDownItems, ItemTypeRow.ID); 
                
                if (TypeID == 0)
                {
                    Collection.Insert(Collection.Count - 1, Item);
                }
                else
                {
                    Collection.Add(Item);
                }
            }
        }

        private void ItemSelectItem_onClick(object sender, EventArgs e)
        {
            this.ShelfDataGridView.Rows.Clear();
            this.SelectedTypeID = (int)(sender as ToolStripItem).Tag;
            ShowShelfDataGridView();
        }

        private void ShowShelfDataGridView()
        {
            ShowShelfDataGridView(this.SelectedTypeID);
        }

        private void ShowShelfDataGridView(int TypeID)
        {
            DataRow[] ItemRows = this.CoffeeHomeDataSet.Item.Select("TypeID = " + TypeID + " AND Name LIKE '*" + this.SearchPattern + "*'");
            foreach (CoffeeHomeDataSet.ItemRow ItemRow in ItemRows)
            {
                CoffeeHomeDataSet.ItemShelfRow ItemShelfRow = this.CoffeeHomeDataSet.ItemShelf.FindByItemID(ItemRow.ID);
                if (ItemShelfRow == null) continue;
                this.ShelfDataGridView.Rows.Add(
                    ItemRow.ID,
                    ItemRow.Name,
                    this.GetItemTypeName(ItemRow.TypeID),
                    ItemRow.Price);
            }
            DataRow[] ChildItemTypeRows = this.CoffeeHomeDataSet.ItemType.Select("FatherID = " + TypeID.ToString());
            foreach (CoffeeHomeDataSet.ItemTypeRow ItemTypeRow in ChildItemTypeRows)
            {
                ShowShelfDataGridView(ItemTypeRow.ID);
            }
        }

        private void AllItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShelfDataGridView.Rows.Clear();
            this.SelectedTypeID = 0;
            ShowShelfDataGridView();
        }

        private void ShelfDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int ItemID = (int)this.ShelfDataGridView[0, e.RowIndex].Value;
            CoffeeHomeDataSet.ItemRow ItemRow = this.CoffeeHomeDataSet.Item.FindByID(ItemID);
            this.TradeItemDataGridView.Rows.Add(
                ItemID,
                ItemRow.Name,
                this.GetItemTypeName(ItemRow.TypeID),
                0,  // Roast degree
                ItemRow.Price,
                1,  // Amount
                ItemRow.Price);
            UpdateSubtotalTextBox();
        }

        private void TradeForm_Load(object sender, EventArgs e)
        {
            if (this.MemberID == 0)
            {
                this.MemberTextBox.Text = "非會員";
            }
            else
            {
                CoffeeHomeDataSet.MemberRow MemberRow = this.CoffeeHomeDataSet.Member.FindByID(this.MemberID);
                this.MemberTextBox.Text = MemberRow.Name;
            }
        }

        private void SearchToolStripTextBox_Enter(object sender, EventArgs e)
        {
            if (this.SearchToolStripTextBox.Text == "搜尋...")
            {
                this.SearchToolStripTextBox.Text = "";
                this.SearchToolStripTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }

        private void SearchToolStripTextBox_Leave(object sender, EventArgs e)
        {

            if (this.SearchToolStripTextBox.Text == "")
            {
                this.SearchToolStripTextBox.Text = "搜尋...";
                this.SearchToolStripTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void SearchToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.SearchToolStripTextBox.Text == "搜尋...")
            {
                return;
            }

            this.SearchPattern = this.SearchToolStripTextBox.Text;
            this.ShelfDataGridView.Rows.Clear();
            this.ShowShelfDataGridView();
        }

        private void TradeItemDataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow SelectedRow in this.TradeItemDataGridView.SelectedRows)
                {
                    this.TradeItemDataGridView.Rows.Remove(SelectedRow);
                }
                UpdateSubtotalTextBox();
            }
        }

    }
}
