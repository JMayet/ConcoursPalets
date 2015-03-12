using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class InvalidWokflowStateException : Exception
    {
        public Enum.CompetitionWorkflowState InvalidState;

        public InvalidWokflowStateException(Enum.CompetitionWorkflowState invalidState)
            :base()
        {
            this.InvalidState = invalidState;
        }

    }
}
