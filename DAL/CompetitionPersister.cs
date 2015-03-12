using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DAL
{
    public class CompetitionPersister
    {
        #region private static properties
        private static string InProgressCompetitionBackupPath
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory + Properties.Settings.Default.CompetitionInProgress;
            }
        }

        private static string CompletedCompetitionsBackupDirectory
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory + Properties.Settings.Default.CompletedCompetitonDirectory;
            }
        }

        #endregion

        #region public static functions 

        public static bool ExistInProgressCompetition
        {
            get
            {
                return FileExist(InProgressCompetitionBackupPath);
            }
        }

        public static bool ExistPreviousCompetitions
        {
            get
            {
                return HasFiles(CompletedCompetitionsBackupDirectory);
            }
        }

        public static void FinalizeCompetition()
        {
            MoveFile(InProgressCompetitionBackupPath, CompletedCompetitionsBackupDirectory, "CompletedCompetition_" + DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".xml");
        }

        public static void GetCompletedCompetitionByStartDate(string competitionName, ref Object competition)
        {
            Load(CompletedCompetitionsBackupDirectory + "/" + competitionName + ".xml", ref competition); 
        }

        public static List<string> GetPreviousCompetitionsNames()
        {
            return GetFilesNames(CompletedCompetitionsBackupDirectory);
        }

        public static void GetInProgressCompetition(ref Object competition)
        {
            Load(InProgressCompetitionBackupPath, ref competition);           
        }

        public static void SaveInProgressCompetition(Object objectToSave)
        {
            #region requirements

            if (objectToSave == null) throw new ArgumentNullException("objectToSave", "Object to save is missing");
            if (string.IsNullOrWhiteSpace(InProgressCompetitionBackupPath)) throw new ArgumentNullException("path", "The path of the serialization file is empty");

            #endregion 

            try
            {               
                DataContractSerializer serializer = new DataContractSerializer(objectToSave.GetType());
                using (StreamWriter sw = new StreamWriter(InProgressCompetitionBackupPath, false))
                {
                    using (var xmlWriter = XmlWriter.Create(sw))
                    {
                        serializer.WriteObject(xmlWriter, objectToSave);
                    }
                } 
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception("impossible d'écrire dans le fichier de sérialisation, chemin d'accès inconnu", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new Exception("impossible d'écrire dans le fichier de sérialisation, accès non autorisé", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("une erreur inconnue est survenue lors de l'écriture dans le fichier de sérialisation", ex);
            }                                  
        }
               
        public static void GetLatestCompletedCompetition(ref Object competition)
        {
            Load(GetLatestCreatedFile(CompletedCompetitionsBackupDirectory), ref competition);  
        }

        #endregion

        #region private static functions

        private static void Load(string path, ref Object obj)
        {
            #region requirements

            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentNullException("path", "The path of the serialization file is empty");
            if (obj == null) throw new ArgumentNullException("obj", "The serialization object is empty");

            #endregion

            try
            {
                DataContractSerializer serializer = new DataContractSerializer(obj.GetType());
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (XmlDictionaryReader xmlReader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas()))
                    {
                        obj = serializer.ReadObject(xmlReader);
                    }
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception("impossible de lire le fichier de sérialisation, répertoire inconnu", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new Exception("impossible de lire le fichier de sérialisation, accès non autorisé", ex);
            }
            catch (FileNotFoundException ex)
            {
                throw new Exception("impossible de lire le fichier de sérialisation, fichier inconnu", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("une erreur inconnue est survenue lors de la lecture du fichier de sérialisation", ex);
            }
        }      

        private static void MoveFile(string filePath, string NewLocation, string newFilename)
        {
            #region requirements

            if (string.IsNullOrWhiteSpace(filePath)) throw new ArgumentNullException("PreviousLocation", "File previous location is missing");
            if (string.IsNullOrWhiteSpace(NewLocation)) throw new ArgumentNullException("NewLocation", "File new location is missing");
            if (!FileExist(filePath)) throw new Exception("impossible de trouver le fichier à déplacer");
            #endregion

            try
            {
                Directory.CreateDirectory(NewLocation);
                File.Move(filePath, NewLocation + "\\" + newFilename);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new Exception("Impossible de déplacer le fichier : autorisation refusée", ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception("Impossible de déplacer le fichier : répertoire de destination inconnu", ex);
            }
            catch (IOException ex)
            {
                throw new Exception("Impossible de déplacer le fichier : le fichier de destination éxiste déjà", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Impossible de déplacer le fichier : erreur inconnue", ex);
            }
        }

        private static bool FileExist(string filepath)
        {
            #region requirements

            if (string.IsNullOrWhiteSpace(filepath)) throw new ArgumentNullException("filepath");

            #endregion

            return File.Exists(filepath);
        }

        private static bool HasFiles(string directoryPath)
        {
            #region requirements

            if (string.IsNullOrWhiteSpace(directoryPath)) throw new ArgumentNullException("directoryPath");

            #endregion

            try
            {
                return (Directory.GetFiles(directoryPath).Length > 0) ? true : false;
            }
            catch (DirectoryNotFoundException)
            {
                return false;
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new Exception("impossible d'accèder au répertoire de sauvegarde des précédents concours : accès non autorisé", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("impossible d'accèder au répertoire de sauvegarde des précédents concours : erreur inconnue", ex);
            }
        }

        private static List<string> GetFilesNames(string directoryPath)
        {
            #region requirements

            if (string.IsNullOrWhiteSpace(directoryPath)) throw new ArgumentNullException("directoryPath");

            #endregion

            List<string> ret = new List<string>();

            foreach (string file in Directory.GetFiles(directoryPath))
            {
                ret.Add(Path.GetFileNameWithoutExtension(file));
            }

            return ret;
        }

        private static string GetLatestCreatedFile(string directoryPath)
        {
            #region requirements

            if (string.IsNullOrWhiteSpace(directoryPath)) throw new ArgumentNullException("directoryPath");

            #endregion                       

            DirectoryInfo directory = new DirectoryInfo(directoryPath);
            FileInfo latestCreatedFile = (from f in directory.GetFiles()
                          orderby f.CreationTime descending
                          select f).First();

            return latestCreatedFile.FullName;
        }

        #endregion

    }
}
