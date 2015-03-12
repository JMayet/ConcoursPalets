using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace BLL
{
    [DataContract]
    [KnownType(typeof(RandomRound))]
    [KnownType(typeof(RankingRound))]
    public abstract class Round
    {

        #region public properties

        [DataMember]
        public List<Game> Games
        {
            get;
            set;
        }

        [DataMember]
        public int Number
        {
            get;
            set;
        }  

        public 
        
        #endregion

        #region Constructor

        Round()
        {
            this.Games = new List<Game>();
        }

        protected Round(int number)
        {   
            this.Number = number;
            this.Games = new List<Game>();            
            //if(Competition.GetCurrentConcours().Manches.Count > 0)
            //{
            //    this.Classement = Competition.GetCurrentConcours().Manches.Last().Classement;
            //}
            //else
            //{
            //    Team[] Equipes = new Team[Competition.GetCurrentConcours().ListeEquipes.Count];
            //    Competition.GetCurrentConcours().ListeEquipes.CopyTo(Equipes);
            //    this.Classement = Equipes.ToList(); 
            //}    
        }

        #endregion

        abstract public void DrawNextGames(List<Team> teams);   

        public bool IsRoundFinished
        {
            get
            {
                return (IsRoundStarted && Games.TrueForAll(x => x.Finished == true));    
            }                        
        }

        public bool IsRoundStarted
        {
            get
            {
                return (Games.Count > 0);
            }            
        }   
                           
        private void UpdateTeamsRanking()
        {
          int teamsCount = Competition.Current.Teams.Count;
          Team[] teams = new Team[teamsCount];
          List<Team> rankingTeams = Competition.Current.Teams;
          rankingTeams.CopyTo(teams);
          rankingTeams.Clear();  

          for (int i = 0; i < teamsCount; i++)
          {
              int index = -1;
              if (i == 0) rankingTeams.Add(teams[i]);
              else
              {
                  for (int j = 0; j < rankingTeams.Count; j++)
                  {
                      if (teams[i].VictoryCount > rankingTeams[j].VictoryCount)
                      {
                          index = j;
                          break;
                      }
                      else if (teams[i].VictoryCount == rankingTeams[j].VictoryCount)
                      {
                          if (teams[i].PointsDifference > rankingTeams[j].PointsDifference)
                          {
                              index = j;
                              break;
                          }
                      }
                  }
                  if (index == -1) rankingTeams.Insert(i, teams[i]);
                  else rankingTeams.Insert(index, teams[i]);
              }
          }

          Dictionary<int, string> ranking = new Dictionary<int, string>();

          for (int i = 0; i < rankingTeams.Count; i++)
          {
              ranking.Add(i + 1, rankingTeams[i].Name);
          }

          Competition.Current.Rankings.Add(ranking);            
        }

        /// <summary>
        /// Update points difference and victories/defeats count of each team.
        /// </summary>
        public void Finish()
        {
            #region requirements
            if (!IsRoundFinished)
            {
                throw new InvalidOperationException("Impossible de finaliser la manche actuelle : la manche n'est pas terminée.");
            }
            #endregion

            foreach(Game game in Games)
            {
                Team Winner = Competition.Current.Teams.Find(team => team.Name == game.GetWinner()); // Get the winner team
                Winner.VictoryCount += 1; // Update victory count of the winner
                Winner.PointsDifference += Math.Abs(game.Diff); // Update points difference of the winner

                Team Loser = Competition.Current.Teams.Find(team => team.Name == game.GetLoser()); // Get the loser team
                Loser.DefeatsCount += 1; // Update defeats count of the loser
                Loser.PointsDifference -= Math.Abs(game.Diff); // Update points difference of the loser
            }

            UpdateTeamsRanking();
        }  
    }
}
