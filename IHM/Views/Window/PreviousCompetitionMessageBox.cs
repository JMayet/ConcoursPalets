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
    public partial class PreviousCompetitionMessageBox : Telerik.WinControls.UI.RadForm
    {
        private string _selectedCompetition;

        public PreviousCompetitionMessageBox(List<string> previousCompetitions)
        {
            InitializeComponent();
            this.CompetitionComboBox.DataSource = previousCompetitions;
        }
             
        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            this._selectedCompetition = CompetitionComboBox.SelectedItem.ToString();
            Close();
        }

        public string GetPreviousCompetition()
        {
            return _selectedCompetition;
        }
    }
       
}
