using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM.Views.UserControl
{
    public partial class YesNoButtons : MyUserControl
    {
        public event EventHandler YesBtnClickEvent;
        public event EventHandler NoBtnClickEvent;

        public YesNoButtons()
        {
            InitializeComponent();
        }

        private void RaiseYesBtnClickEvent()
        {
            if (YesBtnClickEvent != null)
                YesBtnClickEvent(this, new EventArgs());
        }

        private void RaiseNoBtnClickEvent()
        {
            if (NoBtnClickEvent != null)
                NoBtnClickEvent(this, new EventArgs());
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            this.RaiseYesBtnClickEvent();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            this.RaiseNoBtnClickEvent();
        }
    }
}
