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
    public partial class MemberDetailsTabUserControl : UserControl
    {
        public EventHandler ClickMemberName;
        public EventHandler ClickCloseButton;

        public int MemberID;
        public string MemberName;

        public MemberDetailsTabUserControl()
        {
            InitializeComponent();
        }

        public void SetForm(int MemberID, string MemberName)
        {
            this.MemberID = MemberID;
            this.MemberName = MemberName;
            this.MemberNameButton.Text = MemberName;
            this.CloseButton.Click += ClickCloseButton;
        }

        public void SetClickMemberName()
        {
            this.MemberNameButton.Click += ClickMemberName;
        }

        public void SetClickCloseButton()
        {
            this.CloseButton.Click += ClickCloseButton;
        }
    }
}
