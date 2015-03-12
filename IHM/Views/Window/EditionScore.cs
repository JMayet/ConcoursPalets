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
    public partial class EditionScore : Telerik.WinControls.UI.RadForm
    {
        public int[] Result
        {
            get;
            private set;
        }
        
        public EditionScore(int field, string teamA, string teamB, int scoreA, int scoreB)
        {
            InitializeComponent();

            Result = new int[2];
          
            this.LabelField.Text = "Terrain " + field.ToString();
            this.LabelTeamA.Text = teamA;
            this.LabelTeamB.Text = teamB;
            this.LabelScoreA.Text = scoreA.ToString();
            this.LabelScoreB.Text = scoreB.ToString();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ValidBtn_Click(object sender, EventArgs e)
        {
            Result[0] = int.Parse(this.LabelScoreA.Text);
            Result[1] = int.Parse(this.LabelScoreB.Text);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            this.Close();
        }
        
        private void ResetBtn_Click(object sender, EventArgs e)
        {     
            this.LabelScoreA.Text = "0";
            this.LabelScoreB.Text = "0";          
        }

        private void ScoreChanging(object sender, TextChangingEventArgs e)
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
