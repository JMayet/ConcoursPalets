using BLL.CustomException;
using DAL;
using System;
using System.Activities;
using System.Activities.Hosting;
using System.Activities.XamlIntegration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Timers;
using System.Workflow.Activities;
using System.Xaml;
using System.Xml.Serialization;

namespace BLL
{
    [DataContract]
    public class Competition
    {
        #region public properties

        [DataMember]
        public List<Round> Rounds
        {
            get;
            set;
        }

        [DataMember]
        public DateTime StartDate
        {
            get;
            set;
        }

        [DataMember]
        public List<Team> Teams
        {
            get;
            set;
        }

        [DataMember]
        public Configuration Configuration
        {
            get;
            set;
        }

        [DataMember]
        public Enum.CompetitionWorkflowState WorkflowState
        {
            get;
            set;
        }

        [DataMember]
        public List<Dictionary<int, string>> Rankings
        {
            get;
            set;
        }

        public bool IsTeamsNumberValid
        {
            get
            {
                return ((Teams.Count % 2 == 0) && (Teams.Count > 0) && (Teams.Count <= MaxTeamsNumber));
            }
        }

        public int MaxTeamsNumber
        {
            get
            {
                return Configuration.BoardsNumber * 2;
            }
        }

        public bool IsAddTeamCommandAvailable
        {
            get
            {
                return (Teams.Count < MaxTeamsNumber);
            }
        }
                     
        public int PlayersCount
        {
            get
            {
                return Teams.Count * 2;
            }
        }

        public Round CurrentRound
        {
            get
            {
                return Rounds.LastOrDefault();
            }
        } 

        #endregion             

        #region static properties

        public static bool ExistInProgressCompetition
        {
            get
            {
                return CompetitionPersister.ExistInProgressCompetition;
            }
        }

        public static bool ExistPreviousCompetitions
        {
            get
            {
                return CompetitionPersister.ExistPreviousCompetitions;
            }
        }

        public static Competition Current
        {
            get;
            set;
        }

        #endregion

        #region Constructors

        public Competition()
        {
            this.StartDate = DateTime.Now;
            this.Teams = new List<Team>();
            this.Rounds = new List<Round>();
            this.Configuration = new Configuration();
            this.Rankings = new List<Dictionary<int, string>>();
        } 

        #endregion

        #region public functions

        public void AddNewTeam(Team team)
        {
            # region requirements

            if (team == null)
            {
                throw new ArgumentNullException("team", "l'équipe à ajouter est nulle");
            }

            if (WorkflowState != BLL.Enum.CompetitionWorkflowState.Configuration)
            {
                Logger.WriteInformation(Properties.Resources.AddTeamInvalidWokflowStateMessage);
                throw new InvalidWokflowStateException(WorkflowState);
            }

            if (!(IsAddTeamCommandAvailable))
            {
                Logger.WriteInformation(string.Format(Properties.Resources.MaxTeamsNumberReached, team.Name));
                throw new InvalidTeamsCountException();
            }

            foreach (Team T in Teams)
            {
                if (T.Name == team.Name)
                {
                    Logger.WriteInformation(string.Format(Properties.Resources.TeamAlreadyExistMessage, team.Name));
                    throw new InvalidTeamNameException();
                }
            }

            #endregion

            Teams.Add(team);
            Logger.WriteInformation("Nouvelle équipe ajoutée : " + team.Name);
            Save();
        }

        public void UpdateTeam(string teamName, Team team)
        {
            # region requirements

            if (team == null)
            {
                throw new ArgumentNullException("team", "l'équipe à modifier est nulle");
            }

            if (string.IsNullOrWhiteSpace(teamName))
            {
                throw new ArgumentNullException("teamName", "l'équipe à modifier est nulle");
            }

            if (WorkflowState != BLL.Enum.CompetitionWorkflowState.Configuration)
            {
                Logger.WriteInformation(Properties.Resources.UpdateTeamInvalidWokflowStateMessage);
                throw new InvalidWokflowStateException(WorkflowState);
            }

            #endregion

            Teams.First(t => t.Name == teamName).UpdateTeam(team.TeamMember1, team.TeamMember2);
            Logger.WriteInformation("Equipe modifiée : " + teamName);
            Save();
        }

        public void RemoveTeam(string teamName)
        {
            # region requirements

            if (string.IsNullOrWhiteSpace(teamName))
            {
                throw new ArgumentNullException("teamName", "l'équipe à supprimer est nulle");
            }

            if (WorkflowState != BLL.Enum.CompetitionWorkflowState.Configuration)
            {
                Logger.WriteInformation(Properties.Resources.RemoveTeamInvalidWokflowStateMessage);
                throw new InvalidWokflowStateException(WorkflowState);
            }

            #endregion

            if (Teams.RemoveAll(t => t.Name == teamName) > 0)
            {
                UpdateTeamNames();
                Logger.WriteInformation("Equipe supprimée : " + teamName);
                Save();
            }
            else
            {
                Logger.WriteInformation(string.Format(Properties.Resources.TeamNotExistMessage, teamName));
                throw new InvalidTeamNameException();
            }
        }

        public Team GetTeam(string name)
        {
            return Teams.First(t => t.Name == name);
        }

        public List<Game> GetGames(string team)
        {
            List<Game> result = new List<Game>();
            foreach(Round round in Rounds)
            {
                foreach(Game game in round.Games)
                {
                    if(game.Team1 == team || game.Team2 == team)
                    {
                        result.Add(game);
                    }                    
                }
            }
            return result;
        }

        public void UpdateTeamNames()
        {
            for (short i = 0; i < Teams.Count; i++)
            {
                int NumEquipe = i + 1;
                Teams[i].Name = "Equipe " + NumEquipe.ToString();
            }
        }

        /// <summary>
        /// Start the next round of the competition
        /// </summary>
        /// <returns>True if it's possible false otherwise</returns>       
        public bool StartNextRound()
        {
            #region requirements

            if (WorkflowState != BLL.Enum.CompetitionWorkflowState.RandomRound && WorkflowState != BLL.Enum.CompetitionWorkflowState.RankingRound && WorkflowState != BLL.Enum.CompetitionWorkflowState.Configuration)
            {
                throw new InvalidWokflowStateException(WorkflowState);            
            }
               
            //if(Rounds.Count >= Configuration.RandomRoundsNumber + Configuration.RankingRoundsNumber)
            //{
            //    Logger.WriteInformation(Properties.Resources.NewRandomRoundTeamsNumberError);
            //    throw new RoundsCountException();
            //}

            if (!IsTeamsNumberValid)
            {
                Logger.WriteInformation("Erreur : nombre d'équipes incorrect pour démarrer une nouvelle manche");
                throw new InvalidTeamsCountException();
            }             

            #endregion

            if (CurrentRound != null) // If a round is in progress
            {
                CurrentRound.Finish();
                Save();
            }

            bool ret;
            if (Rounds.Count(round => round.GetType() == typeof(RandomRound))< Configuration.RandomRoundsNumber) // If random round count has not been reach yet
            {
                StartNewRandomRound(); // We start a new random round
                Save();
                ret = true;
            }
            else if (Rounds.Count(round => round.GetType() == typeof(RankingRound)) < Configuration.RankingRoundsNumber) // If random round count has been reach and not ranking round count
            {
                StartNewRankingRound();
                Save();
                ret = true;
            }
            else // If random and ranking round count have been reached we can't start a new round
            {
                CompetitionPersister.FinalizeCompetition();
                ret = false; 
            }           
                        
            return ret;            
        }

        public void DrawNextGames()
        {
            #region requirements
            if ((WorkflowState != BLL.Enum.CompetitionWorkflowState.RankingRound) && (WorkflowState != BLL.Enum.CompetitionWorkflowState.RandomRound))
            {
                Logger.WriteInformation(Properties.Resources.InvalidWorkflowStateError);
                throw new InvalidWokflowStateException(WorkflowState);
            }
            if (CurrentRound.Games.Count != 0)
            {
                Logger.WriteInformation(Properties.Resources.ActionAlreadyDoneError);
                throw new ActionAlreadyDoneException("tirrage des matchs à jouer");
            }
            #endregion

            CurrentRound.DrawNextGames(Teams);
            Logger.WriteInformation("Matchs à venir générés");
            Save();
        }       

        public void UpdateSettings(Configuration configuration)
        {
            # region requirements

            if (WorkflowState != BLL.Enum.CompetitionWorkflowState.Configuration)
            {
                throw new InvalidWokflowStateException(WorkflowState);
            }

            if (configuration == null)
            {
                throw new ArgumentNullException("Configuration");
            }

            #endregion

            Configuration = configuration;
            Logger.WriteInformation(Properties.Resources.EditConfigInvalidWokflowStateMessage);
            Save();
        }

        public Dictionary<int,int> GetRankingEvolution(string teamName)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            int i = 1;
            foreach(Dictionary<int, string> ranking in Rankings)
            {
                result.Add(i, ranking.First(r => r.Value == teamName).Key);
                i++;
            }

            return result;
        }

        public void Save()
        {
            CompetitionPersister.SaveInProgressCompetition(this);
            Logger.WriteInformation("Concours sauvegardé.");
        }

        #endregion

        #region private functions

        private void StartNewRandomRound()
        {
            #region requirements

            if ((WorkflowState != BLL.Enum.CompetitionWorkflowState.Configuration) && (WorkflowState != BLL.Enum.CompetitionWorkflowState.RandomRound))
            {
                Logger.WriteInformation(Properties.Resources.NewRandomRoundInvalidWokflowStateMessage);
                throw new InvalidWokflowStateException(WorkflowState);
            }

            if (Rounds.Count(random => random.GetType() == typeof(RandomRound)) >= Configuration.RandomRoundsNumber)
            {
                Logger.WriteInformation(Properties.Resources.NewRandomRoundNumberMessage);
                throw new RoundsCountException();
            }

            if (Rounds.Count > 0 && !(Rounds.LastOrDefault().IsRoundFinished))
            {
                Logger.WriteInformation(Properties.Resources.NewRandomRoundPreviousRoundInProgress);
                throw new PreviousRoundInProgressException();
            }

            #endregion

            Rounds.Add(new RandomRound(Rounds.Count + 1));
            WorkflowState = BLL.Enum.CompetitionWorkflowState.RandomRound;
            Logger.WriteInformation("Début de la manche " + (Rounds.Count + 1).ToString() + " : manche aléatoire");
        }

        private void StartNewRankingRound()
        {
            #region requirements

            if ((WorkflowState != BLL.Enum.CompetitionWorkflowState.RandomRound) && (WorkflowState != BLL.Enum.CompetitionWorkflowState.RankingRound))
            {
                Logger.WriteInformation(Properties.Resources.NewRankingRoundInvalidWokflowStateMessage);
                throw new InvalidWokflowStateException(WorkflowState);
            }

            if (Rounds.Count(round => round.GetType() == typeof(RankingRound)) >= Configuration.RankingRoundsNumber)
            {
                Logger.WriteInformation(Properties.Resources.NewRankingRoundNumberMessage);
                throw new RoundsCountException();
            }

            if (Rounds.Count > 0 && !(Rounds.LastOrDefault().IsRoundFinished))
            {
                Logger.WriteInformation(Properties.Resources.NewRankingRoundPreviousRoundInProgress);
                throw new PreviousRoundInProgressException();
            }

            #endregion

            Rounds.Add(new RankingRound(Rounds.Count + 1));
            WorkflowState = BLL.Enum.CompetitionWorkflowState.RankingRound;
            Logger.WriteInformation("Début de la manche " + (Rounds.Count + 1).ToString() + " : manche de classement");
        }      

        #endregion

        #region static functions

        public static Competition GetCompletedCompetitionByName(string competitionName)
        {
            Object C = new Competition();
            CompetitionPersister.GetCompletedCompetitionByStartDate(competitionName, ref C);
            return (Competition)C;
        }

        public static Competition GetInProgressCompetition()
        {
            Object C = new Competition();
            CompetitionPersister.GetInProgressCompetition(ref C);
            return (Competition)C;
        }

        public static void StartNewCompetition()
        {
            Competition.Current = new Competition();
            Competition.Current.Save();
        }

        public static Competition GetLatestCompletedCompetition()
        {
            Object C = new Competition();
            CompetitionPersister.GetLatestCompletedCompetition(ref C);
            return (Competition)C;
        }

        public static List<string> GetPreviousCompetitionsNames()
        {
            return CompetitionPersister.GetPreviousCompetitionsNames();
        }
          
        #endregion
    }
}