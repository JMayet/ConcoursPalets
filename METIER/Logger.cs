using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Logger
    {           
        public static void WriteError(Exception ex)
        {
            DAL.Logger.WriteMessage(CreateLogMessage(ex), AppDomain.CurrentDomain.BaseDirectory + Properties.Settings.Default.LoggingSource);            
        }

        public static void WriteInformation(string Message)
        {
            DAL.Logger.WriteMessage(CreateLogMessage(Message), AppDomain.CurrentDomain.BaseDirectory + Properties.Settings.Default.LoggingSource);            
        }

        private static string CreateLogMessage(Exception Ex)
        {
            string ErrorHeader = "[Error] ERROR OCCURS : ";
            string Timestamp = "[Date] {0} ";
            string DetailHeader = "[Details]";
            string DetailCorps = "{0} : {1}";
            string Footer = "------------------- ";

            StringBuilder SB = new StringBuilder();
            SB.AppendLine(ErrorHeader + Ex.Message);
            SB.AppendLine(string.Format(Timestamp, DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString()));
            SB.AppendLine(DetailHeader);
            do
            {
                if (Ex.InnerException == null)
                {
                    SB.AppendLine(string.Format(DetailCorps, Ex.StackTrace, Ex.Message));
                }
                else
                {
                    SB.AppendLine(string.Format(DetailCorps, Ex.TargetSite, Ex.Message));
                }
                Ex = Ex.InnerException;
            }
            while (Ex != null);
            SB.AppendLine(Footer);
            SB.AppendLine("");
            SB.AppendLine("");

            return SB.ToString();
        }

        private static string CreateLogMessage(string Message)
        {
            string Template = "[Information] {0} - {1} :";
            string Footer = "-------------------";

            StringBuilder SB = new StringBuilder();
            SB.AppendLine(string.Format(Template, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString()));
            SB.AppendLine(Message);
            SB.AppendLine(Footer);
            SB.AppendLine("");
            SB.AppendLine("");

            return SB.ToString();
        }
    }
}
