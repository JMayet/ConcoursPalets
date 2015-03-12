using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CustomException
{
    public class ActionAlreadyDoneException:Exception
    {
        public string Action
        {
            get;
            set;
        }

        public ActionAlreadyDoneException(string action)
        {
            this.Action = action;
        }

    }
}
