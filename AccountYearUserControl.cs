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
    public partial class AccountYearUserControl : UserControl
    {
        CoffeeHomeDataSet CoffeeHomeDataSet;

        public AccountYearUserControl()
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

            this.AccountYearComboBox.Items.Clear();
            for (int year = RecentYear; year >= EarliestYear; year--)
            {
                this.AccountYearComboBox.Items.Add(year.ToString() + " 年");
            }
            this.AccountYearComboBox.SelectedIndex = 0;
        }

        public void ShowForm()
        {
            this.ShowStatistics();
            this.ShowChart();
        }

        private void ShowStatistics()
        {
            if (this.AccountYearComboBox.SelectedIndex == -1)
            {
                return;
            }
            int RecentYear = DateTime.Today.Year;
            int SelectedYear = RecentYear - this.AccountYearComboBox.SelectedIndex;
            DateTime FirstDayOfYear = new DateTime(SelectedYear, 1, 1);
            DateTime FirstDayOfNextYear = FirstDayOfYear.AddYears(1);

            string TimeQuery = "Time >= #" + FirstDayOfYear.ToShortDateString() + "# AND Time < #" + FirstDayOfNextYear.ToShortDateString() + "#";
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
            this.AccountYearReceiptTextBox.Text = ReceiptSubtotal.ToString();
            this.AccountYearNoReceiptTextBox.Text = NoReceiptSubtotal.ToString();
            this.AccountYearCreditCardTextBox.Text = CreditCardSubtotal.ToString();
            this.AccountYearDeliveryTextBox.Text = DeliverySubtotal.ToString();
            this.AccountYearCashTextBox.Text = CashSubtotal.ToString();

            // Count mistake
            int Mistake = CountMistake(AccountRows);
            this.AccountYearMistakeTextBox.Text = Mistake.ToString();

            // Count achievement
            int Achievement = ReceiptSubtotal + NoReceiptSubtotal;
            this.AccountYearAchievementTextBox.Text = Achievement.ToString();
        }

        private void ShowChart()
        {
            if (this.AccountYearComboBox.SelectedIndex == -1)
            {
                return;
            }

            int RecentYear = DateTime.Today.Year;
            int SelectedYear = RecentYear - this.AccountYearComboBox.SelectedIndex;
            DateTime FirstDayOfMonth = new DateTime(SelectedYear, 1, 1);
            DateTime FirstDayOfNextMonth = FirstDayOfMonth.AddMonths(1);

            foreach (var Series in this.AccountYearChart.Series)
            {
                Series.Points.Clear();
            }

            for (int i = 0; i < 12; i++)
            {
                string TimeQuery = "Time >= #" + FirstDayOfMonth.ToShortDateString() + "# AND Time < #" + FirstDayOfNextMonth.ToShortDateString() + "#";
                DataRow[] TradeRows = this.CoffeeHomeDataSet.Trade.Select(TimeQuery);
                this.RenderChart(i + 1, TradeRows);
                FirstDayOfMonth = FirstDayOfMonth.AddMonths(1);
                FirstDayOfNextMonth = FirstDayOfNextMonth.AddMonths(1);
            }

        }

        private int GetRootTypeID(int TypeID)
        {
            while (TypeID >= 10)
            {
                TypeID /= 10;
            }
            return TypeID;
        }

        private void RenderChart(int Month, DataRow[] TradeRows)
        {
            int AchievementSubtotal = 0;
            int BeansSubtotal = 0;
            int InstrumentSubtotal = 0;
            int CoffeeBagSubtotal = 0;
            int DrinkSubtotal = 0;

            foreach (CoffeeHomeDataSet.TradeRow TradeRow in TradeRows)
            {
                AchievementSubtotal += TradeRow.Subtotal;
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

            if (AchievementSubtotal > 0)
                this.AccountYearChart.Series[0].Points.AddXY(Month, AchievementSubtotal);
            if (BeansSubtotal > 0)
                this.AccountYearChart.Series[1].Points.AddXY(Month, BeansSubtotal);
            if (InstrumentSubtotal > 0)
                this.AccountYearChart.Series[2].Points.AddXY(Month, InstrumentSubtotal);
            if (CoffeeBagSubtotal > 0)
                this.AccountYearChart.Series[3].Points.AddXY(Month, CoffeeBagSubtotal);
            if (DrinkSubtotal > 0)
                this.AccountYearChart.Series[4].Points.AddXY(Month, DrinkSubtotal);
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

        private void AccountYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ShowForm();
        }

    }
}
