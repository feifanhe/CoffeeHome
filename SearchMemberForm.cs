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
    public partial class SearchMemberForm : Form
    {
        public string PhoneNumber
        {
            get
            {
                return this.PhoneNumberTextBox.Text;
            }
        }

        public string MemberName
        {
            get
            {
                return this.NameTextBox.Text;
            }
        }

        public string Remarks
        {
            get
            {
                return this.RemarksTextBox.Text;
            }
        }

        public SearchMemberForm()
        {
            InitializeComponent();
        }
    }
}
