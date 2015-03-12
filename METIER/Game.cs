using BLL.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BLL
{
    [DataContract]
    public class Game
    {
        static public event EventHandler GameFinishedEvent;

        #region public properties
                
        public bool Finished
        {
            get
            {
                if ((Scores[0] == 0) && (Scores[1] == 0)) return false;
                else return true;
            }
        }

        [DataMember]
        public int Board
        {
            get;
            set;
        }

        [DataMember]
        public string Team1
        {
            get;
            set;
        }

        [DataMember]
        public string Team2
        {
            get;
            set;
        }

        [DataMember]
        public int[] Scores
        {
            get;
            private set;
        }

        public int Diff 
        {
            get
            {
                return (Scores[0] - Scores[1]);
            }
        }
                
        #endregion
        
        public Game() { }

        public Game(int Planche)
        {
            try
            {
                this.Board = Planche;                
                Scores = new int[2];                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public string GetLoser()
        {
            #region requirements

            int Diff = (Scores[0] - Scores[1]);

            if (Scores[0] < 0 || Scores[1] < 0 || Diff == 0) // If the score is not valid
            {
                throw new InvalidScore(Board, Scores);
            }

            if(!Finished) // If the game is not finished yet
            {
                throw new InvalidOperationException("Impossible de récupérer le perdant du match : le match n'est pas terminé.");
            }

            #endregion

            return Diff > 0 ? Team2 : Team1;
        }

        public string GetWinner()
        {
            #region requirements         

            if (Scores[0] < 0 || Scores[1] < 0 || Diff == 0)
            {
                throw new InvalidScore(Board, Scores);
            }

            if (!Finished) // If the game is not finished yet
            {
                throw new InvalidOperationException("Impossible de récupérer le gagnant du match : le match n'est pas terminé.");
            }

            #endregion

            return Diff > 0 ? Team1 : Team2;
        }

        public void UpdateGameScore(int scoreA, int scoreB)
        {
            #region requirements
                       
            if (!(Competition.Current.WorkflowState == BLL.Enum.CompetitionWorkflowState.RandomRound || Competition.Current.WorkflowState == BLL.Enum.CompetitionWorkflowState.RankingRound))
            {
                Logger.WriteInformation("Match " + Board.ToString() + " : impossible d'enregistrer le score à ce moment du concours");
                throw new InvalidWokflowStateException(Competition.Current.WorkflowState);
            }

            if (scoreA < 0 || scoreB < 0)
            {
                Logger.WriteInformation("Impossible d'enregistrer le score du match " + Board.ToString() + " : score incorrect.");
                throw new ArgumentException();
            }

            #endregion

            Scores[0] = scoreA;
            Scores[1] = scoreB;

            Logger.WriteInformation("Enregistremment du score sur le terrain " + Board.ToString() + ". " + Team1 + " : " + Scores[0] + " / " + Team2 + " : " + Scores[1]);

            RaiseGameScoreUpdatedEvent();

            Competition.Current.Save();
        }

        private void RaiseGameScoreUpdatedEvent()
        {
            if (GameFinishedEvent != null)
                GameFinishedEvent(this, new EventArgs());
        }
    }
}
