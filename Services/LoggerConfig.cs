﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerApp.Services
{
    public class LoggerConfig
    {
        public int BackupConfig { get; set; }
        public string TimeFormat { get; set; }
        public string DirectoryPath { get; set; }
        public string BackUpDirectoryPath { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
    }
}
