using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace Windows_Organizer
{
    class FileManager
    {
        private static readonly string filename = "rules.json";

        /// <summary>
        /// Serializes the rules list object to a JSON string
        /// </summary>
        /// <param name="rules"></param>
        /// <returns>A string containing the JSON</returns>
        private static string ObjectToJson(List<Rule> rules) => JsonConvert.SerializeObject(rules, Formatting.Indented);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rules"></param>
        /// <returns>true if the file is written, otherwise false</returns>
        public static bool SaveSettings(List<Rule> rules)
        {
            try
            {
                File.WriteAllText(filename, ObjectToJson(rules));

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Reads the contents of the file containing the rules
        /// </summary>
        /// <returns>A string containing the JSON</returns>
        private static string ReadFile() => File.ReadAllText(filename);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>true if the rules file exist, otherwise false</returns>
        private static bool CheckFile() => File.Exists(filename);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The deserialized object from the JSON string, or an empty object</returns>
        public static List<Rule> LoadSettings()
        {
            if (CheckFile())
            {
                return JsonConvert.DeserializeObject<List<Rule>>(ReadFile());
            }

            return new List<Rule>();
        }
       
    }
}
