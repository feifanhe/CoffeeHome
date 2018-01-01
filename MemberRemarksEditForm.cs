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
    public partial class MemberRemarksEditForm : Form
    {
        public MemberRemarksEditForm()
        {
            InitializeComponent();
        }

        public string Remarks
        {
            get
            {
                return this.RemarksTextBox.Text;
            }
            set
            {
                this.RemarksTextBox.Text = value;
            }
        }
    }
}
