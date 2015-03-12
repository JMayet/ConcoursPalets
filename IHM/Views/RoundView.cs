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
using BLL.CustomException;
using Telerik.WinControls.UI;
using IHM.Views.UserControl;

namespace IHM.Pages
{
    public partial class RoundView : MyUserControl
    {
         #region Constructor

        public RoundView()
        {            
            InitializeComponent();            
        }

        #endregion
             
        private void UpdateNextButtonState()
        {
            this.NextBtn.Enabled = Competition.Current.CurrentRound.IsRoundFinished;            
        }

        private void UpdatePrintButtonState()
        {
            this.PrintBtn.Enabled = Competition.Current.CurrentRound.IsRoundStarted;
        }

        private void UpdateDrawingButtonState(bool enabled)
        {
            this.TirrageBtn.Enabled = enabled;
            this.TirrageBtn.Refresh();
        }
               
        #region events

        private void Matchs_Load(object sender, EventArgs e)
        {
            if (typeof(RandomRound) == Competition.Current.CurrentRound.GetType())
            {
                this.Title.SetTitle("Matchs n°" + Competition.Current.Rounds.Count.ToString() + " (tirage aléatoire)");
            }
            else
            {

                this.Title.SetTitle("Matchs n°" + Competition.Current.Rounds.Count.ToString() + " (montée-descente)");
            }

            Game.GameFinishedEvent += OnGameScoreUpdated;

            UpdateNextButtonState();
            UpdatePrintButtonState();
            UpdateDrawingButtonState(!Competition.Current.CurrentRound.IsRoundStarted);
        }

        private void OnGameScoreUpdated(object sender, EventArgs e)
        {
            UpdateNextButtonState();
        }        

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.NavigateToStartView();
        }

        private void DrawingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateDrawingButtonState(false);
                Competition.Current.DrawNextGames();                
                this.Fiels.StartGames();
                UpdatePrintButtonState();
                PrintMessageBox messageBox = new PrintMessageBox("Le tirrage de la manche " + Competition.Current.Rounds.Count.ToString() + " est terminé. Voulez vous imprimer la liste des matchs ?", false);
                messageBox.ShowDialog();
                if(messageBox.DialogResult == DialogResult.Yes)
                {
                    PrintRoundGames();
                }
            }
            catch (InvalidWokflowStateException)
            {
                CustomMessageBox.ShowMessage(Properties.Resources.InvalidWorkflowStateError, UserMessageType.Warning);                
            }
            catch (ActionAlreadyDoneException)
            {
                CustomMessageBox.ShowMessage(Properties.Resources.ActionAlreadyDoneError, UserMessageType.Warning);                
            } 
            catch(Exception ex)
            {
                Logger.WriteError(ex);
                CustomMessageBox.ShowMessage(Properties.Resources.ActionError, UserMessageType.Error);                
            }                     
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(Competition.Current.StartNextRound() == true)
                {
                    NavigateToRoundView();
                }
                else
                {
                    NavigateToRankingView(Competition.GetLatestCompletedCompetition());
                }
            }
            catch (InvalidWokflowStateException)
            {
                
            }           
            catch (Exception ex)
            {
                Logger.WriteError(ex);
                CustomMessageBox.ShowMessage(Properties.Resources.ActionError, UserMessageType.Error);
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            PrintRoundGames();
        }

        private void PrintRoundGames()
        {
            RadPrintDocument printer = new RadPrintDocument();
            printer.DefaultPageSettings.Landscape = false;
            printer.DefaultPageSettings.PrinterSettings.Copies = 1;
            printer.Margins.Top = 40;
            printer.HeaderFont = new Font("Arial", 20);
            printer.FooterHeight = 0;
            printer.MiddleHeader = "Matchs de la manche " + Competition.Current.Rounds.Count.ToString();

            HiddenGamesGrid hiddenGamesGrid = new HiddenGamesGrid();
            RadGridView objectToPrint = hiddenGamesGrid.GetGrid();
            printer.AssociatedObject = objectToPrint;

            RadPrintPreviewDialog printDialog = new RadPrintPreviewDialog(printer);
            printDialog.ThemeName = "Office2010Silver";
            printDialog.ShowDialog();
        }

        #endregion
        
    }
}
