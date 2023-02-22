using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.IO;

namespace FetchDataViaWebAutomation
{
    class Download
    {
        //=======================
        // Methods
        //=======================

        /// <Download-Method>
        /// Navigates to the website, asks the user to Athentify and than clicks through the website to download the file,
        /// which is located in the user specific download folder
        /// </Download-Method>
        public void DownloadFile()
        {
            //Variables and configuration for logs
            EdgeOptions options = new EdgeOptions();
            options.AddArgument("log-level=3");


            EdgeDriver driver = new EdgeDriver(options);
            IWebElement webElement;
            bool webElementFound;

            const string URL = "";


            //Authentification
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl(URL);

            while (true)
            {
                try
                {
                    webElement = driver.FindElement(By.XPath(""));
                    webElement.Click();
                    break;
                }
                catch
                {
                }
            }

            driver.Manage().Window.Maximize();

            while (true)
            {
                if (driver.Url.Contains(""))
                {
                    break;
                }
            }


            //'Export zu MS Project'-Click
            while (true)
            {
                try
                {
                    webElement = driver.FindElement(By.XPath(""));
                    webElement.Click();
                    break;
                }
                catch
                {
                }
            }

            //'Exportieren'-Click
            while (true)
            {
                try
                {
                    webElement = driver.FindElement(By.XPath(""));
                    webElement.Click();
                    break;
                }
                catch
                {
                }
            }

            //'Download'-Click
            while (true)
            {
                try
                {
                    webElement = driver.FindElement(By.XPath(""));
                    webElementFound = true;
                }
                catch
                {
                    webElementFound = false;
                }

                if (webElementFound == true)
                {
                    webElement.Click();
                    break;
                }
            }

            ChangeFolder();
            driver.Close();

            Console.Clear();
        }

        /// <ChangeFolder-Method>
        /// Finds the downloaded file by its name in the user-specific download folder. As soon as the file is found it is moved to the
        /// destination folder 'Aktueller Datenabzug'
        /// </ChangeFolder-Method>
        public void ChangeFolder()
        {
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string sourceFile = downloadsPath + "\\Filename.xml";
            string targetPath = Directory.GetCurrentDirectory() + "\\Aktueller Datenabzug\\Filename.xml";

            while (true)
            {
                if (File.Exists(sourceFile) == true)
                {
                    File.Move(sourceFile, targetPath);
                    break;
                }
            }
        }
    }
}
