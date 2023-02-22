using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// - FechDataViaWebAutomation -
/// Script fetches data from Web-App (API-Provider or Web-Download), write the data in a seperate .json-/.xml-File, creates and manages a archive to update a PowerBI report.
/// After the script runs successfully, the PowerBI report is automatically opened and provided to the customer with up-to-date data.
/// 
/// WARNING: Dieses Projekt wurde innerhalb eines Unternehmens entwickelt. Dateipfade und Internetadressen wurden hierbei entfernt, um die Daten- und Konzernsicherheit zu gewährleisten.
///  
/// author:     Maurice Hofmann
/// date:       24.12.2022
/// version:    1.0.0
/// </summary>

namespace FetchDataViaWebAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DataArchive dataArchive = new DataArchive();
                Download Download = new Download();

                //The sequence of the program is defined here
                //====================================================================
                // START
                //====================================================================

                ConsoleProgressBar.WriteProgressBar(0, "Starting process...");

                ConsoleProgressBar.RefreshProgressBar(10, "Check archive");
                dataArchive.CheckArchive();

                ConsoleProgressBar.RefreshProgressBar(20, "Archive file");
                dataArchive.Archive();

                ConsoleProgressBar.RefreshProgressBar(500, "Download\n");
                Download.DownloadFile();

                ConsoleProgressBar.RefreshProgressBar(90, "Open PowerBI-Report");
                OpenPowerBIReport();

                ConsoleProgressBar.RefreshProgressBar(100, "Process finished");

                //====================================================================
                // END
                //====================================================================

                Console.WriteLine("\nScript ran successfully and the data was updated!");
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                Console.Clear();

                //Error output for the user
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: " + ex.Message);

                //Contact options for the user to help
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        /// <OpenPowerBIReport-Method>
        /// Open the Power BI report with up-to-date data for the customer
        /// </OpenPowerBIReport-Method>
        static void OpenPowerBIReport()
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = Directory.GetCurrentDirectory() + "\\PowerBI-Dashboard.pbix"
            };

            process.Start();
        }
    }
}
