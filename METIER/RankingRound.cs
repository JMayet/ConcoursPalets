using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BLL
{
    [DataContract]
    public class RankingRound : Round
    {       
        public RankingRound(int number) 
            : base(number)
        {
            
        }

        public RankingRound()
        {

        }

        override public void DrawNextGames(List<Team> teams)
        { 
            for (int i = 0; i < teams.Count / 2; i++)
            {
                Game game = new Game(Games.Count + 1);
                game.Team1 = teams[2 * i].Name;
                game.Team2 = teams[(2 * i) + 1].Name;
                Games.Add(game);
            }  
        }   
    }
}
