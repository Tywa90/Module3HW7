using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LoggerApp.Services
{
    public class FileService
    {
        public static Config Config { get; set; }
        public static string LogDirPath { get; set; }
        public static string BackUpDirPath { get; set; }

        public static void Run()
        {
            SerializationSample();
            DirectoryPath();
            DirectoryCheck();
            CreateLog();
        }

        private static void SerializationSample()
        {
            var path = "Services\\jsconfig1.json";
            var configFile = File.ReadAllText(path);
            Config = JsonConvert.DeserializeObject<Config>(configFile);
        }

        private static void DirectoryPath()
        {
            LogDirPath = Config.Logger.DirectoryPath;
            BackUpDirPath = Config.Logger.BackUpDirectoryPath;
        }

        private static void DirectoryCheck()
        {
            if (!Directory.Exists(LogDirPath))
            {
                Console.WriteLine("Enter");
                Directory.CreateDirectory(LogDirPath);
            }

            if (!Directory.Exists(BackUpDirPath))
            {
                Console.WriteLine("Enter");
                Directory.CreateDirectory(BackUpDirPath);
            }
        }

        private static void CreateLog()
        {
            string name = DateTime.Now.ToString(Config.Logger.FileName);

            var textLog = Logger.Sb.ToString();

            File.WriteAllText($"{LogDirPath}\\{name}.txt", textLog);
            File.WriteAllText($"{BackUpDirPath}\\{name}.txt", textLog);
        }
    }
}
