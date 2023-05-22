using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LoggerApp.Services;
using Newtonsoft.Json;

namespace LoggerApp
{
    public class Starter
    {
        public void Run()
        {
            Actions action = new Actions();

            for (int i = 0; i < 100; i++)
            {
                int choice = new Random().Next(1, 4);
                switch (choice)
                {
                    case 1:
                        action.Method1();
                        break;
                    case 2:
                        action.Method2();
                        break;
                    case 3:
                        action.Method3();
                        break;
                    default:
                        Console.WriteLine("No one method enter the switcher");
                        break;
                }
            }

            Logger.RunFileServices();
        }
    }
}
