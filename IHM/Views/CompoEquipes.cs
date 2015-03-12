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
using System.Globalization;
using Telerik.WinControls.UI;
using IHM.Form;
using BLL.CustomException;

namespace IHM.Pages
{
    public partial class TeamsEditionView : MyUserControl
    {
        #region Constructor

        public TeamsEditionView()
            : base()
        {
            InitializeComponent();
        }

        #endregion

        #region events

        private void TeamEditionPage_Load(object sender, EventArgs e)
        {
            this.Title.SetTitle("Inscription des participants");
            RefreshAll();
        }

        private void AddTeamBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string teamName = "Equipe " + (Competition.Current.Teams.Count + 1).ToString();
                TeamEdition teamEditionForm = new TeamEdition(teamName, "", "");
                teamEditionForm.ShowDialog();
                if (teamEditionForm.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        Competition.Current.AddNewTeam(teamEditionForm.Result);
                        this.RefreshAll();
                    }
                    catch (InvalidWokflowStateException)
                    {
                        CustomMessageBox.ShowMessage(Properties.Resources.AddTeamInvalidWokflowStateMessage, UserMessageType.Information);
                    }
                    catch (InvalidTeamNameException)
                    {
                        CustomMessageBox.ShowMessage(string.Format(Properties.Resources.TeamAlreadyExistMessage, teamName), UserMessageType.Information);
                    }
                    catch (InvalidTeamsCountException)
                    {
                        CustomMessageBox.ShowMessage(string.Format(Properties.Resources.MaxTeamsNumberReached, teamName), UserMessageType.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowMessage(Properties.Resources.AddNewTeamError, UserMessageType.Error);
                Logger.WriteError(ex);
            }
        }

        private void DeleteTeamBtn_Click(object sender, EventArgs e)
        {
            string teamName = TeamsGrid.SelectedRows[0].Cells[0].Value.ToString();

            try
            {
                Competition.Current.RemoveTeam(teamName);
                this.RefreshAll();
            }
            catch (InvalidWokflowStateException)
            {
                CustomMessageBox.ShowMessage(Properties.Resources.RemoveTeamInvalidWokflowStateMessage, UserMessageType.Information);
            }
            catch (InvalidTeamNameException)
            {
                CustomMessageBox.ShowMessage(string.Format(Properties.Resources.TeamNotExistMessage, teamName), UserMessageType.Information);
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowMessage(string.Format(Properties.Resources.RemoveTeamError, teamName), UserMessageType.Error);
                Logger.WriteError(ex);
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            PrintMessageBox messageBox = new PrintMessageBox("Voulez vous imprimer la liste des équipes avant de commencer le concours ?");
            messageBox.ShowDialog();

            switch (messageBox.DialogResult)
            {
                case DialogResult.Yes:
                    PrintTeamsList();
                    break;
                case DialogResult.No:
                    try
                    {
                        Competition.Current.StartNextRound();
                        this.NavigateToRoundView();
                    }
                    catch (InvalidWokflowStateException)
                    {
                        CustomMessageBox.ShowMessage(Properties.Resources.NewRandomRoundInvalidWokflowStateMessage, UserMessageType.Warning);
                    }
                    catch (RoundsCountException)
                    {
                        CustomMessageBox.ShowMessage(Properties.Resources.NewRandomRoundNumberMessage, UserMessageType.Warning);
                    }
                    catch (InvalidTeamsCountException)
                    {
                        CustomMessageBox.ShowMessage(Properties.Resources.NewRandomRoundTeamsNumberError, UserMessageType.Warning);
                    }
                    catch (PreviousRoundInProgressException)
                    {
                        CustomMessageBox.ShowMessage(Properties.Resources.NewRandomRoundPreviousRoundInProgress, UserMessageType.Warning);
                    }
                    catch (Exception)
                    {
                        Logger.WriteInformation(Properties.Resources.NewRandomRoundUnknownError);
                        CustomMessageBox.ShowMessage(Properties.Resources.NewRandomRoundUnknownError, UserMessageType.Warning);
                    }
                    break;
                default :
                    break;
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
#if DEBUG
            for (int i = 0; i < 30; i++)
            {
                Team T = new Team("Equipe " + (i + 1).ToString(), "Joueur " + ((2 * i) + 1).ToString(), "Joueur " + ((2 * i) + 2).ToString());
                Competition.Current.AddNewTeam(T);
            }

            RefreshAll();
#endif

            PrintTeamsList();
        }

        private void ConfigBtn_Click(object sender, EventArgs e)
        {
            try
            {
                EditSettings editSettings = new EditSettings(Competition.Current.Configuration);
                editSettings.ShowDialog();
                if (editSettings.DialogResult == DialogResult.OK)
                {
                    Competition.Current.UpdateSettings(editSettings.Resultat);
                    this.RefreshAll();
                }
            }
            catch (InvalidWokflowStateException)
            {
                CustomMessageBox.ShowMessage(Properties.Resources.EditConfigInvalidWokflowStateMessage, UserMessageType.Information);
            }
            catch (Exception ex)
            {
                Logger.WriteError(ex);
                CustomMessageBox.ShowMessage(Properties.Resources.EditConfigError, UserMessageType.Error);
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.NavigateToStartView();
        }

        private void TeamGrid_Click(object sender, EventArgs e)
        {
            UpdateDeleteButtonsState();
        }

        private void TeamsGrid_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                string selectedTeam = e.Row.Cells[0].Value.ToString();
                Team team = Competition.Current.GetTeam(selectedTeam);
                TeamEdition teamEditionForm = new TeamEdition(team.Name, team.TeamMember1, team.TeamMember2);
                teamEditionForm.ShowDialog();
                if (teamEditionForm.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        Competition.Current.UpdateTeam(selectedTeam, teamEditionForm.Result);
                        this.RefreshTeamsGrid();
                    }
                    catch (InvalidWokflowStateException)
                    {
                        CustomMessageBox.ShowMessage(Properties.Resources.UpdateTeamInvalidWokflowStateMessage, UserMessageType.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.WriteError(ex);
                CustomMessageBox.ShowMessage(Properties.Resources.UpdateTeamError, UserMessageType.Error);
            }
        }

        #endregion

        #region private functions

        private void PrintTeamsList()
        {
            RadPrintDocument printer = new RadPrintDocument();
            printer.DefaultPageSettings.Landscape = false;
            printer.DefaultPageSettings.PrinterSettings.Copies = 1;
            printer.Margins.Top = 40;
            printer.HeaderFont = new Font("Arial", 20);
            printer.FooterHeight = 0;
            printer.MiddleHeader = "Liste des équipes";
            printer.AssociatedObject = TeamsGrid;

            RadPrintPreviewDialog printDialog = new RadPrintPreviewDialog(printer);
            printDialog.ThemeName = "Office2010Silver";
            printDialog.ShowDialog();
        }

        private void RefreshTeamsGrid()
        {
            TeamsGrid.DataSource = null;
            TeamsGrid.DataSource = Competition.Current.Teams;
            TeamsGrid.TableElement.ScrollToRow(TeamsGrid.Rows.Count);
        }

        private void UpdateTeamsNumberLabel()
        {
            string teamsNumber = Competition.Current.Teams.Count.ToString();
            string maxTeamsNumber = Competition.Current.MaxTeamsNumber.ToString();
            this.LabelNbEquipes.Text = teamsNumber + " Equipes / " + maxTeamsNumber + " Equipes possibles";
        }

        private void UpdatePlayersNumberLabel()
        {
            this.LabelNbParticipants.Text = Competition.Current.PlayersCount.ToString() + " Participants";
        }

        private void UpdateDeleteButtonsState()
        {
            if (TeamsGrid.SelectedRows.Count == 1)
            {
                this.DeleteBtn.Enabled = true;
            }
            else
            {
                this.DeleteBtn.Enabled = false;
            }
        }

        private void UpdateAddButtonState()
        {
            if (Competition.Current.IsAddTeamCommandAvailable) this.AddBtn.Enabled = true;
            else this.AddBtn.Enabled = false;
        }

        private void UpdateNextButtonState()
        {
            if (Competition.Current.IsTeamsNumberValid) this.StartBtn.Enabled = true;
            else this.StartBtn.Enabled = false;
        }

        private void UpdatePrintButtonState()
        {
            if (Competition.Current.IsTeamsNumberValid) this.PrintBtn.Enabled = true;
            else this.PrintBtn.Enabled = false;
        }

        private void RefreshAll()
        {
            RefreshTeamsGrid();
            UpdateTeamsNumberLabel();
            UpdatePlayersNumberLabel();
            UpdateDeleteButtonsState();
            UpdateAddButtonState();
            UpdateNextButtonState();
#if DEBUG
#else
            UpdatePrintButtonState();
#endif
        }

        #endregion
    }
}
