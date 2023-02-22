using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FetchDataViaWebAutomation
{
    class APIRequest
    {
        //=======================
        // Variables
        //=======================
        public readonly string endPoint;
        public readonly string httpMethod;
        static public readonly string filename = "Filename.json";


        //=======================
        // Constructor
        //=======================
        public APIRequest()
        {
            endPoint = "";     
            httpMethod = "GET";
        }


        //=======================
        // Methods
        //=======================

        /// <FetchData-Method>
        /// Retrieves the data via an interface to Web-App and stores it in the form of a JSON-String to pass the data to the WriteJSON-Method
        /// </FetchData-Method>
        public string FetchData()       
        {
            string responseData = string.Empty;

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(endPoint);
            request.Method = httpMethod;
            request.Headers.Add("", "");


            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                StreamReader reader = new StreamReader(responseStream);
                responseData = reader.ReadToEnd();
            }

            return responseData;
        }

        /// <WriteJSON-Method>
        /// Writes new formatted data into the empty .json-file delivered via the FetchData-Method
        /// </WriteJSON-Method>
        public void WriteJSON()
        {
            FileStream fileStream = new FileStream(filename, FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(fileStream);

            string data = FetchData();
            writer.Write(FormatJSON(data)); ;

            writer.Close();
            fileStream.Close();
        }

        /// <CleanFile-Method>
        /// Cleans the .json-file of old data so that an empty file with the same name is created and then describes it with new data
        /// </CleanFile-Method>
        public void CleanFile()
        {
            File.WriteAllText(filename, string.Empty);
        }

        /// <FormatJSON-Method>
        /// Gets the json-string which is initially still in one line. This is formatted into the structure of a json-file returned, 
        /// and then further processed in the WriteJSON-Method
        /// </FormatJSON-Method>
        public string FormatJSON(string jsonData)
        {
            var valueObject = JsonConvert.DeserializeObject(jsonData);
            string formattedJson = JsonConvert.SerializeObject(valueObject, Formatting.Indented);

            return formattedJson;
        }
    }
}
