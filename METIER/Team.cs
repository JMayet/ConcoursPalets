using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BLL
{    
    [DataContract]
    public class Team
    {
        #region public properties      

        [DataMember]
        public int Rank
        {
            get;
            set;
        }

        [DataMember]
        public int DefeatsCount
        {
            get ;
            set ;
        }

        [DataMember]
        public int VictoryCount
        {
            get;
            set;
        }

        [DataMember]
        public int PointsDifference
        {
            get;
            set;
        }
        
        [DataMember]
        public string TeamMember2
        {
            get;
            set;
        }

        [DataMember]
        public string TeamMember1
        {
            get;
            set;
        }

        [DataMember]
        public string Name
        {
            get;
            set;
        }

        #endregion

        # region Constructors

        public Team() { }

        public Team(string name, string teamMember1, string teamMember2)
        {
            this.Name = name;
            this.TeamMember1 = teamMember1;
            this.TeamMember2 = teamMember2;
        }

        #endregion

        public void UpdateTeam(string teamMember1, string teamMember2)
        {
            this.TeamMember1 = teamMember1;
            this.TeamMember2 = teamMember2;
        }
               
    }
}
