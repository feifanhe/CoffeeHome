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
            int SelectedYear = RecentYear - this.AccountMonthYearComboBox.SelectedIndex;
            int SelectedMonth = this.AccountMonthMonthComboBox.SelectedIndex + 1;
            DateTime FirstDayOfMonth = new DateTime(SelectedYear, SelectedMonth, 1);
            DateTime FirstDayOfNextMonth = FirstDayOfMonth.AddMonths(1);
            int NumberOfWeek = 0;

            foreach (var Series in this.AccountMonthChart.Series)
            {
                Series.Points.Clear();
                Series.IsVisibleInLegend = false;
            }
            
            for (DateTime Day = FirstDayOfMonth; Day < FirstDayOfNextMonth; )
            {
                DateTime NextDay = Day.AddDays(1);
                string TimeQuery = "Time >= #" + Day.ToShortDateString() + "# AND Time < #" + NextDay.ToShortDateString() + "#";
                DataRow[] TradeRows = this.CoffeeHomeDataSet.Trade.Select(TimeQuery);
                int Subtotal = CountSubtotal(TradeRows);
                this.AccountMonthChart.Series[NumberOfWeek].Points.AddXY((int)Day.DayOfWeek, Subtotal);
                this.AccountMonthChart.Series[NumberOfWeek].IsVisibleInLegend = true;
                if (Day.DayOfWeek == DayOfWeek.Saturday) NumberOfWeek++;
                Day = NextDay;
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

        private void AccountMonthChart_FormatNumber(object sender, System.Windows.Forms.DataVisualization.Charting.FormatNumberEventArgs e)
        {
            if (e.ElementType == System.Windows.Forms.DataVisualization.Charting.ChartElementType.AxisLabels
                && e.Format == "CustomAxisXFormat")
            {
                switch ((int)e.Value)
                {
                    case 0:
                        e.LocalizedValue = "星期日";
                        break;
                    case 1:
                        e.LocalizedValue = "星期一";
                        break;
                    case 2:
                        e.LocalizedValue = "星期二";
                        break;
                    case 3:
                        e.LocalizedValue = "星期三";
                        break;
                    case 4:
                        e.LocalizedValue = "星期四";
                        break;
                    case 5:
                        e.LocalizedValue = "星期五";
                        break;
                    case 6:
                        e.LocalizedValue = "星期六";
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
