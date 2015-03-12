using BLL;
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
    public partial class CustomMessageBox : Telerik.WinControls.UI.RadForm
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public static void ShowMessage(string message, UserMessageType type)
        {
            CustomMessageBox  customMessageBox = new CustomMessageBox();
            customMessageBox.TextLabel.Text = message;
            switch(type)
            {
                case UserMessageType.Information :
                    customMessageBox.Text = "Information";
                    customMessageBox.imagePanel.BackgroundImage = Properties.Resources.Information;
                    break;
                case UserMessageType.Warning :
                    customMessageBox.Text = "Avertissement";
                    customMessageBox.imagePanel.BackgroundImage = Properties.Resources.Warning;
                    break;
                default :
                    customMessageBox.Text = "Erreur";
                    customMessageBox.imagePanel.BackgroundImage = Properties.Resources.Error;                    
                    break;
            }
            customMessageBox.ShowDialog();
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imagePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
       
}
