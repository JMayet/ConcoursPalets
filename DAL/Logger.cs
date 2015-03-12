using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Logger
    {       
        public static void WriteMessage(string Message, string LogPath)
        {
            try
            {
                #region requirements

                if (string.IsNullOrWhiteSpace(LogPath)) throw new ArgumentNullException("LogPath", "The path of the log file is empty");
                if (string.IsNullOrWhiteSpace(Message)) throw new ArgumentNullException("Message", "The message to log is empty");
                
                #endregion 

                using(StreamWriter fileWriter = GetFileWriter(LogPath))
                {
                    fileWriter.Write(Message);                    
                }
            }
            catch (Exception)
            {
                // Catch the error but do nothing because it's just logging
            }
        }
                    
        private static StreamWriter GetFileWriter(string LogPath)
        {
            #region requirements

            if (string.IsNullOrWhiteSpace(LogPath)) throw new ArgumentNullException("LogPath", "The path of the log file is empty");

            #endregion 

            StreamWriter LogWriter = null;
 
                // Init the Writer and create the log file if it doesn't already exist                
                if (!File.Exists(LogPath))
                {
                    try
                    {
                        LogWriter = File.CreateText(LogPath);
                    }
                    catch (DirectoryNotFoundException ex)
                    {
                        throw new Exception("impossible de créer le fichier de log, chemin d'accès inconnu", ex);
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        throw new Exception("impossible de créer le fichier de log, accès non autorisé", ex);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("une erreur inconnue est survenue lors de la création du fichier de Log", ex);
                    }
                }
                else
                {
                    try
                    {
                        LogWriter = new StreamWriter(LogPath, true);
                    }
                    catch (DirectoryNotFoundException ex)
                    {
                        throw new Exception("impossible d'accèder au fichier de log, chemin d'accès inconnu", ex);
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        throw new Exception("impossible d'accèder au fichier de log, accès non autorisé", ex);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("une erreur inconnue est survenue lors de l'accès au fichier de Log", ex);
                    }
                }

                LogWriter.AutoFlush = true;

                return LogWriter;            
        }     

    }
}
