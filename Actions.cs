using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoggerApp
{
    public class Actions
    {
        private readonly string _message1;
        private readonly string _message2;
        private readonly string _message3;

        public Actions()
        {
            _message1 = "Start method";
            _message2 = "Skipped logic in method";
            _message3 = "I broke a logic";
        }

        public void Method1()
        {
            Logger.DisplayLog(LogType.Info, $"{_message1}: Method1()");
        }

        public void Method2()
        {
            Logger.DisplayLog(LogType.Warning, $"{_message2}: Method2()");
        }

        public void Method3()
        {
            Logger.DisplayLog(LogType.Error, $"{_message3}: Method3()");
        }
    }
}
