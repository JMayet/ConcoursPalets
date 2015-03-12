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

namespace IHM.Pages
{
    public partial class Field : MyUserControl
    {
        private int _board;

        public Field(int board)
        {
            this._board = board;
            InitializeComponent();
            this.LabelTerrain.Text = board.ToString();                  
        }

        public void UpdateView()
        {
            if (Competition.Current.CurrentRound.Games.Count > _board - 1) // if there is a game in progress on this field
            {
                UpdateGame();
            }
        }

        #region private functions              

        private void UpdateGame()
        {           
            UpdateTeams();
            UpdateScores();
            UpdateGameState();           
        }
        
        private void UpdateTeams()
        {
            this.LabelTeamA.Text = Competition.Current.CurrentRound.Games[_board-1].Team1;
            this.LabelTeamB.Text = Competition.Current.CurrentRound.Games[_board-1].Team2;
        }

        private void UpdateScores()
        {
            this.LabelScoreTeamA.Text = Competition.Current.CurrentRound.Games[_board-1].Scores[0].ToString();
            this.LabelScoreTeamB.Text = Competition.Current.CurrentRound.Games[_board-1].Scores[1].ToString(); 
        }
               
        private void UpdateGameState()
        {
            // Mettre à jour l'état du match (Terminé ou non)
            if (Competition.Current.CurrentRound.Games[_board-1].Finished) this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gold;
            else this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
        }

        private void EditGameScore()
        {
            if (Competition.Current.CurrentRound.Games.Count != 0 && Competition.Current.CurrentRound.Games[_board-1] != null)
            { 
                EditionScore scoreEdition = new EditionScore(int.Parse(this.LabelTerrain.Text), this.LabelTeamA.Text, this.LabelTeamB.Text, int.Parse(this.LabelScoreTeamA.Text), int.Parse(this.LabelScoreTeamB.Text));
                scoreEdition.ShowDialog();
                if(scoreEdition.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        Competition.Current.CurrentRound.Games[_board-1].UpdateGameScore(scoreEdition.Result[0], scoreEdition.Result[1]);
                        UpdateGame();
                    }
                    catch(InvalidOperationException)
                    {
                        CustomMessageBox.ShowMessage("Match " + _board.ToString() + " : impossible d'enregistrer le score, le match n'est pas commencé.", UserMessageType.Warning);
                    }
                    catch(InvalidWokflowStateException)
                    {
                        CustomMessageBox.ShowMessage("Match " + _board.ToString() + " : impossible d'enregistrer le score à ce moment du concours", UserMessageType.Warning);
                    }
                    catch(ArgumentException)
                    {
                        CustomMessageBox.ShowMessage("Impossible d'enregistrer le score du match " +_board.ToString() + " : score incorrect.", UserMessageType.Warning);
                    }
                    catch(Exception ex)
                    {
                        Logger.WriteError(ex);
                        CustomMessageBox.ShowMessage("Impossible d'enregistrer le score du match " + _board.ToString() + " : erreur inconnue.", UserMessageType.Error);
                    }
                }
            }                                         
        }     

        #endregion
        
        private void Field_Load(object sender, EventArgs e)
        {
            UpdateView();     
        }
        private void LabelField_Click(object sender, EventArgs e)
        {
           EditGameScore();
        }
        private void LabelTeamA_Click(object sender, EventArgs e)
        {
            EditGameScore();
        }
        private void LabelTeamB_Click(object sender, EventArgs e)
        {
            EditGameScore();
        }
        private void LabelScoreTeamA_Click(object sender, EventArgs e)
        {
            EditGameScore();
        }
        private void LabelScoreTeamB_Click(object sender, EventArgs e)
        {
            EditGameScore();
        }
    }
}
