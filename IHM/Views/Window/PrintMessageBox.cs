using BLL;
using IHM.Views.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace IHM
{
    public partial class PrintMessageBox : Telerik.WinControls.UI.RadForm
    {
        public PrintMessageBox(string message, bool showCancelBtn = true)
        {
            InitializeComponent();
            TextLabel.Text = message;
            if(showCancelBtn == false)
            {
                YesNoButtons buttons = new YesNoButtons();
                this.ButtonsPanel.Controls.Add(buttons);
                this.ButtonsPanel.Controls[0].Dock = DockStyle.Fill;
                buttons.NoBtnClickEvent += ResetBtn_Click;
                buttons.YesBtnClickEvent += YesBtn_Click;
            }
            else
            {
                YesNoCancelButtons buttons = new YesNoCancelButtons();
                this.ButtonsPanel.Controls.Add(buttons);
                this.ButtonsPanel.Controls[0].Dock = DockStyle.Fill;
                buttons.NoBtnClickEvent += ResetBtn_Click;
                buttons.YesBtnClickEvent += YesBtn_Click;
                buttons.CancelBtnClickEvent += CancelBtn_Click;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
        
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
