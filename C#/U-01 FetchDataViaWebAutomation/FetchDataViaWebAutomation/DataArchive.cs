using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchDataViaWebAutomation
{
    class DataArchive
    {
        //=======================
        // Variables
        //=======================

        public readonly string file = Directory.GetCurrentDirectory() + "\\Aktueller Datenabzug\\Filename.xml";
        public readonly string archivePath = Directory.GetCurrentDirectory() + "\\Archiv";


        //=======================
        // Methods
        //=======================

        /// <Archive-Method>
        /// Creates a copy of the .xml-file and saves it to the Archive folder with the last write date
        /// </Archive-Method>
        public void Archive()
        {
            string lastWriteTime = Convert.ToString(File.GetLastWriteTime(file)).Replace(':', '-');
            string archiveFileName = lastWriteTime + "";
            string newArchiveFile = archivePath + "\\" + archiveFileName;

            File.Copy(file, newArchiveFile, true);
        }

        /// <CheckArchive-Method>
        /// Checks the archived files for the date the file was last opened. If the last opening was more than 12 Months ago, the file is classified 
        /// as no longer relevant and removed from the archive.
        /// </CheckArchive-Method>
        public void CheckArchive()
        {
            int archivePeriodInMonths = 12;

            string[] archiveFiles = Directory.GetFiles(archivePath);
            foreach (string file in archiveFiles)
            {
                FileInfo fileInfo = new FileInfo(file);

                if (fileInfo.LastAccessTime < DateTime.Now.AddMinutes(-archivePeriodInMonths))
                {
                    fileInfo.Delete();
                }
            }
        }
    }
}
