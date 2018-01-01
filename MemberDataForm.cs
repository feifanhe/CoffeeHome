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
    public partial class MemberDataForm : Form
    {
        private int m_ID = 0;

        public int ID
        {
            get { return this.m_ID; }
            set { this.m_ID = value; }
        }

        public string MemberName
        {
            get { return this.NameTextBox.Text; }
            set { this.NameTextBox.Text = value; }
        }

        public byte Sex
        {
            get { return (byte)(this.SexComboBox.SelectedIndex + 1); }
            set { this.SexComboBox.SelectedIndex = value - 1; }
        }

        public string PhoneNumber
        {
            get { return this.PhoneNumberTextBox.Text; }
            set { this.PhoneNumberTextBox.Text = value; }
        }

        public string ZipCode
        {
            get { return this.ZipCodeTextBox.Text; }
            set { this.ZipCodeTextBox.Text = value; }
        }

        public string Address
        {
            get { return this.AddressTextBox.Text; }
            set { this.AddressTextBox.Text = value; }
        }

        public string Email
        {
            get { return this.EmailTextBox.Text; }
            set { this.EmailTextBox.Text = value; }
        }

        public string Remarks
        {
            get { return this.RemarksTextBox.Text; }
            set { this.RemarksTextBox.Text = value; }
        }

        public MemberDataForm()
        {
            // New member
            InitializeComponent();
            this.SexComboBox.SelectedIndex = 0;
        }

        public MemberDataForm(CoffeeHomeDataSet.MemberRow MemberRow)
        {
            // Update member row
            InitializeComponent();
            this.Text = "編輯會員";
            this.FormOKButton.Text = "確定";
            this.ID = MemberRow.ID;
            this.MemberName = MemberRow.Name;
            this.Sex = MemberRow.Sex;
            this.PhoneNumber = MemberRow.PhoneNumber;
            this.ZipCode = MemberRow.ZipCode;
            this.Address = MemberRow.Address;
            this.Email = MemberRow.Email;
            this.Remarks = MemberRow.Remarks;
        }

        private void FormOKButton_Click(object sender, EventArgs e)
        {
            if (this.MemberName == string.Empty || this.PhoneNumber == string.Empty)
            {
                return;
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
