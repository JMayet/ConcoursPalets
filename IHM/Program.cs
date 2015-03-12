using IHM.Form;
using IHM.Properties;
using BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace IHM
{
    static public class Program
    {
        static private MainForm mainForm;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);          

            // Add the event handler for handling UI thread exceptions to the event.
            Application.ThreadException += new ThreadExceptionEventHandler(MainForm_UIThreadException);

            // Set the unhandled exception mode to force all Windows Forms errors to go through our handler.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling non-UI thread exceptions to the event. 
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(UnhandledExceptionHandler);  

            mainForm = new MainForm();
            Logger.WriteInformation(Resources.StartMessage); // Log start informations

            Application.Run(mainForm);
        }
                
        private static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs args)
        {
            HandleUnhandledException((Exception)args.ExceptionObject);
        }

        // Handle the UI exceptions
        private static void MainForm_UIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            HandleUnhandledException(t.Exception); 
        }

        // log the event and inform the user about it.
        private static void HandleUnhandledException(Exception ex)
        {
            try
            {
                Logger.WriteError(ex);
                MessageBox.Show(Resources.UnhandledErrorMessage);                
            }            
            catch(Exception)
            {
                MessageBox.Show(Resources.FatalErrorMessage); 
                Application.Exit();
            }           
        }
    }
}
