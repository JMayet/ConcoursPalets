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
    public partial class EditSettings : Telerik.WinControls.UI.RadForm
    {
        public Configuration Resultat
        {
            get;
            private set;
        }

        public EditSettings(Configuration configuration)
        {   
            InitializeComponent();

            this.Resultat = configuration;

            this.FieldsNumberTextBox.Text = configuration.BoardsNumber.ToString();
            this.RandomRoundsNumberTextBox.Text = configuration.RandomRoundsNumber.ToString();
            this.RankingRoundsNumberTextBox.Text = configuration.RankingRoundsNumber.ToString();             
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            Resultat.BoardsNumber = int.Parse(FieldsNumberTextBox.Text);
            Resultat.RandomRoundsNumber = int.Parse(RandomRoundsNumberTextBox.Text);
            Resultat.RankingRoundsNumber = int.Parse(RankingRoundsNumberTextBox.Text);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();            
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void radTextBox1_TextChanging(object sender, TextChangingEventArgs e)
        {
            e.Cancel = !IsNumber(e.NewValue);
        }

        private bool IsNumber(string text)
        {
            bool res = true;
            try
            {
                if (!string.IsNullOrEmpty(text) && ((text.Length != 1) || (text != "-")))
                {
                    Decimal d = decimal.Parse(text, CultureInfo.CurrentCulture);
                }
            }
            catch
            {
                res = false;
            }
            return res;
        }
    }
}
