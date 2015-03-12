using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [DataContract]
    public class Configuration
    {
        #region public properties

        [DataMember]
        public int BoardsNumber
        {
            get;
            set;
        }

        [DataMember]        
        public int RandomRoundsNumber
        {
            get;
            set;
        }

        [DataMember]       
        public int RankingRoundsNumber
        {
            get;
            set;
        }

        #endregion
               
        public Configuration()
        {
            this.BoardsNumber = 30;
            this.RandomRoundsNumber = 2;
            this.RankingRoundsNumber = 4;
        }
    }
}
