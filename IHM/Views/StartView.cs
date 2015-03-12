using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Configuration;
using IHM.Pages;
using System.Activities;
using IHM.Form;
using Telerik.WinControls.UI;

namespace IHM
{
    public partial class StartView : MyUserControl
    {
        #region ButtonsClick
        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Competition.StartNewCompetition();
                NavigateToTeamsEditionView();               
            }
            catch(Exception ex)
            {
                Logger.WriteError(ex); 
                CustomMessageBox.ShowMessage(Properties.Resources.StartNewCompetitionError, UserMessageType.Error);                            
            }        
        }

        private void InProgressCompetitionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(Competition.Current == null) // If there is no competition in progress loaded
                {
                    Competition.Current = Competition.GetInProgressCompetition();
                }

                switch (Competition.Current.WorkflowState)
                {
                    case BLL.Enum.CompetitionWorkflowState.Configuration :
                        this.NavigateToTeamsEditionView();
                        break;
                    case BLL.Enum.CompetitionWorkflowState.RandomRound :
                        this.NavigateToRoundView();
                        break;
                    case BLL.Enum.CompetitionWorkflowState.RankingRound :
                        this.NavigateToRoundView();
                        break;
                    default :
                        this.NavigateToStartView();
                        break;                        
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowMessage(Properties.Resources.StartInProgressCompetitionError, UserMessageType.Error);
                Logger.WriteError(ex);   
            }                      
        }

        private void PreviousCompetitionsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.NavigateToRankingView(Competition.GetLatestCompletedCompetition());
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowMessage(Properties.Resources.LoadPreviousCompetitionError, UserMessageType.Error);
                Logger.WriteError(ex);   
            }
           
        }

        #endregion

        private void Start_Load(object sender, EventArgs e)
        {            
            UpdateButtonsVisibility();
        }

        public StartView()
        {
            InitializeComponent();   
        }
         
        private void UpdateButtonsVisibility()
        {
            // Update InProgressCompetitionBtn visibility
            this.InProgressCompetitionButton.Enabled = Competition.ExistInProgressCompetition;

            // Update InPreviousCompetitionBtn visibility
            this.PreviousCompetitionsButton.Enabled = Competition.ExistPreviousCompetitions;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
