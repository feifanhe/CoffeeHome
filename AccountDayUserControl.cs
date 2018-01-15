using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CoffeeHome
{
    public partial class AccountDayUserControl : UserControl
    {
        private CoffeeHomeDataSet CoffeeHomeDataSet;
        private CoffeeHomeDataSet.AccountRow AccountRow;

        public AccountDayUserControl()
        {
            InitializeComponent();
        }

        public void SetDataSet(CoffeeHomeDataSet CoffeeHomeDataSet)
        {
            this.CoffeeHomeDataSet = CoffeeHomeDataSet;
            this.AccountDateTimePicker.Value = DateTime.Today;
        }

        public void SetForm()
        {
            this.AccountTableAdapter.Fill(this.CoffeeHomeDataSet.Account);
            this.TradeTableAdapter.Fill(this.CoffeeHomeDataSet.Trade);
            this.TradeItemTableAdapter.Fill(this.CoffeeHomeDataSet.TradeItem);
        }

        public void ShowForm()
        {
            DateTime Day = this.AccountDateTimePicker.Value;
            DateTime NextDay = Day.AddDays(1);
            string TimeQuery = "Time >= #" + Day.ToShortDateString() + "# AND Time < #" + NextDay.ToShortDateString() + "#";

            // Load account row
            DataRow[] AccountRows = this.CoffeeHomeDataSet.Account.Select(TimeQuery);
            if (AccountRows.Length == 0)
            {
                this.AccountRow = this.CoffeeHomeDataSet.Account.NewAccountRow();
                this.AccountRow.Time = Day;
                this.AccountRow.WorkingCapital = int.Parse(ConfigurationManager.AppSettings["WorkingCapital"]);
                this.CoffeeHomeDataSet.Account.AddAccountRow(this.AccountRow);
                this.AccountTableAdapter.Update(this.CoffeeHomeDataSet.Account);
            }
            else
            {
                this.AccountRow = this.CoffeeHomeDataSet.Account.FindByID((int)AccountRows[0][0]);
            }

            this.ShowStatistics();
            this.ShowAccountDetails();
        }

        private void ShowStatistics()
        {
            DateTime Day = this.AccountDateTimePicker.Value;
            DateTime NextDay = Day.AddDays(1);
            int WorkingCapital = this.AccountRow.WorkingCapital;
            int Mistake = this.AccountRow.Mistake;
            int Mistake2 = this.AccountRow.Mistake2;
            int Mistake3 = this.AccountRow.Mistake3;

            this.WorkingCapitalTextBox.Text = WorkingCapital.ToString();
            this.MistakeTextBox.Text = Mistake.ToString();
            this.MistakeTextBox2.Text = Mistake2.ToString();
            this.MistakeTextBox3.Text = Mistake3.ToString();

            string TimeQuery = "Time >= #" + Day.ToShortDateString() + "# AND Time < #" + NextDay.ToShortDateString() + "#";
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
            DateTime Day = this.AccountDateTimePicker.Value;
            DateTime NextDay = Day.AddDays(1);
            this.AccountDetailsDataGridView.Rows.Clear();
            string TimeQuery = "Time >= #" + Day.ToShortDateString() + "# AND Time < #" + NextDay.ToShortDateString() + "#";
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
            this.ShowForm();
        }

        private void WorkingCapitalTextBox_TextChanged(object sender, EventArgs e)
        {
            int WorkingCapital = 0;
            Int32.TryParse(this.WorkingCapitalTextBox.Text, out WorkingCapital);
            this.AccountRow.WorkingCapital = WorkingCapital;
            this.AccountTableAdapter.Update(this.CoffeeHomeDataSet.Account);
            ShowStatistics();
        }

        private void MistakeTextBox_TextChanged(object sender, EventArgs e)
        {
            int Mistake = 0;
            Int32.TryParse(this.MistakeTextBox.Text, out Mistake);
            this.AccountRow.Mistake = Mistake;
            this.AccountTableAdapter.Update(this.CoffeeHomeDataSet.Account);
            ShowStatistics();
        }

        private void MistakeTextBox2_TextChanged(object sender, EventArgs e)
        {
            int Mistake2 = 0;
            Int32.TryParse(this.MistakeTextBox2.Text, out Mistake2);
            this.AccountRow.Mistake2 = Mistake2;
            this.AccountTableAdapter.Update(this.CoffeeHomeDataSet.Account);
            ShowStatistics();
        }

        private void MistakeTextBox3_TextChanged(object sender, EventArgs e)
        {
            int Mistake3 = 0;
            Int32.TryParse(this.MistakeTextBox3.Text, out Mistake3);
            this.AccountRow.Mistake3 = Mistake3;
            this.AccountTableAdapter.Update(this.CoffeeHomeDataSet.Account);
            ShowStatistics();
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
                this.TradeItemTableAdapter.Update(this.CoffeeHomeDataSet.TradeItem);

                this.ShowForm();
            }
        }

    }
}
