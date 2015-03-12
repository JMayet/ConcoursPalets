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
    public partial class YesNoCancelButtons : MyUserControl
    {
        public event EventHandler YesBtnClickEvent;
        public event EventHandler NoBtnClickEvent;
        public event EventHandler CancelBtnClickEvent;

        public YesNoCancelButtons()
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

        private void RaiseCancelBtnClickEvent()
        {
            if (CancelBtnClickEvent != null)
                CancelBtnClickEvent(this, new EventArgs());
        }       

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.RaiseCancelBtnClickEvent();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            this.RaiseNoBtnClickEvent();
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            this.RaiseYesBtnClickEvent();
        }
    }
}
