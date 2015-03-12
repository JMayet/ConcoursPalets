using IHM.Form;
using IHM.Pages;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM
{
    public class MyUserControl : UserControl
    {       
        public MyUserControl()
            :base()
        {
            
        }

        public void NavigateToStartView()
        {
            MainForm mainForm = (MainForm) this.ParentForm;
            mainForm.UpdateView(new StartView());
        }

        public void NavigateToTeamsEditionView()
        {
            MainForm mainForm = (MainForm)this.ParentForm;
            mainForm.UpdateView(new TeamsEditionView());
        }

        public void NavigateToRoundView()
        {
            MainForm mainForm = (MainForm)this.ParentForm;
            mainForm.UpdateView(new RoundView());
        }

        public void NavigateToRankingView(Competition competitionToDisplay)
        {
            MainForm mainForm = (MainForm)this.ParentForm;
            mainForm.UpdateView(new RankingView(competitionToDisplay));
        }
    }
}
