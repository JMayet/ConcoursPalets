using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace IHM
{        
    public partial class TeamEdition : Telerik.WinControls.UI.RadForm
    {
        public Team Result
        {
            get;
            set;
        }

        public TeamEdition(string name, string teamMember1, string teamMember2)
        {
                this.Result = null;
                InitializeComponent();
                this.LabelNomEquipe.Text = name;
                this.TB_Equipier1.Text = teamMember1;
                this.TB_Equipier2.Text = teamMember2;             
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            this.Result = new Team(LabelNomEquipe.Text, TB_Equipier1.Text, TB_Equipier2.Text);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;            
            this.Close();                 
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
