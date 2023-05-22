﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LoggerApp.Services;

namespace LoggerApp
{
    public class Logger
    {

        private static StringBuilder _sb = new StringBuilder();
        public static StringBuilder Sb
        {
            get { return _sb; }
        }

        public static void DisplayLog(LogType type, string message)
        {
            var date = DateTime.Now.ToString("HH:mm:ss");
            string logConsole = date + " : " + type + " : " + message;
            Console.WriteLine(logConsole);
            _sb.Append(logConsole + "\n");
        }

        public static void RunFileServices()
        {
            FileService.Run();
        }
    }
}
