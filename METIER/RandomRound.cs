using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace BLL
{    
    [DataContract]
    public class RandomRound : Round
    {
        public RandomRound(int number)
            : base(number)
        {
            
        }

        public RandomRound()            
        {

        }


        public override void DrawNextGames(List<Team> teams)
        {
            List<Team> tempTeams = new List<Team>(teams);

            Random R = new Random();
            int gameCount = tempTeams.Count / 2;

            for (int i = 1; i <= gameCount; i++)
            {
                Game game = new Game(this.Games.Count + 1);

                int teamA = R.Next(0, tempTeams.Count - 1);
                game.Team1 = tempTeams[teamA].Name;
                tempTeams.RemoveAt(teamA);

                int teamB = R.Next(0, tempTeams.Count - 1);
                game.Team2 = tempTeams[teamB].Name;
                tempTeams.RemoveAt(teamB);

                this.Games.Add(game);
            }      
        } 
     
    }
}
