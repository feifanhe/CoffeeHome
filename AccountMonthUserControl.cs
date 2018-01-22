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
    public partial class AccountMonthUserControl : UserControl
    {
        CoffeeHomeDataSet CoffeeHomeDataSet;

        public AccountMonthUserControl()
        {
            InitializeComponent();
        }

        public void SetDataSet(CoffeeHomeDataSet CoffeeHomeDataSet)
        {
            this.CoffeeHomeDataSet = CoffeeHomeDataSet;
        }

        public void SetForm()
        {
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
        }

        public void ShowForm()
        {

            ShowStatistics();
        }

        private void AccountMonthYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void AccountMonthMonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void ShowStatistics()
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

            ShowChart();
        }

        private void ShowChart()
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

            this.AccountMonthChart.Series[0].Points.Clear();
            DataRow[] TradeRows = this.CoffeeHomeDataSet.Trade.Select(TimeQuery);
            this.RenderChart(TradeRows);
        }


        private int GetRootTypeID(int TypeID)
        {
            while (TypeID >= 10)
            {
                TypeID /= 10;
            }
            return TypeID;
        }

        private void RenderChart(DataRow[] TradeRows)
        {
            int BeansSubtotal = 0;
            int InstrumentSubtotal = 0;
            int CoffeeBagSubtotal = 0;
            int DrinkSubtotal = 0;

            foreach (CoffeeHomeDataSet.TradeRow TradeRow in TradeRows)
            {
                int TradeID = TradeRow.ID;
                DataRow[] TradeItemRows = this.CoffeeHomeDataSet.TradeItem.Select("TradeID = " + TradeID.ToString());
                foreach (CoffeeHomeDataSet.TradeItemRow TradeItemRow in TradeItemRows)
                {
                    int ItemID = TradeItemRow.ItemID;
                    DataRow[] ItemRows = this.CoffeeHomeDataSet.Item.Select("ID = " + ItemID.ToString());
                    foreach (CoffeeHomeDataSet.ItemRow ItemRow in ItemRows)
                    {
                        switch (GetRootTypeID(ItemRow.TypeID))
                        {
                            case 1:
                                BeansSubtotal += ItemRow.Price * TradeItemRow.Amount;
                                break;
                            case 2:
                                InstrumentSubtotal += ItemRow.Price * TradeItemRow.Amount;
                                break;
                            case 3:
                                CoffeeBagSubtotal += ItemRow.Price * TradeItemRow.Amount;
                                break;
                            case 4:
                                DrinkSubtotal += ItemRow.Price * TradeItemRow.Amount;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            if (BeansSubtotal > 0)
                this.AccountMonthChart.Series[0].Points.AddXY("咖啡豆", BeansSubtotal);
            if (InstrumentSubtotal > 0)
                this.AccountMonthChart.Series[0].Points.AddXY("器材", InstrumentSubtotal);
            if (CoffeeBagSubtotal > 0)
                this.AccountMonthChart.Series[0].Points.AddXY("掛耳包", CoffeeBagSubtotal);
            if (DrinkSubtotal > 0)
                this.AccountMonthChart.Series[0].Points.AddXY("咖啡", DrinkSubtotal);
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
    }
}
