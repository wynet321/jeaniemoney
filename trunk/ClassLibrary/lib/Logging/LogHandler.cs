using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary.lib;

namespace ClassLibrary
{
    public class LogHandler
    {
        private List<Appender> appenders = new List<Appender>();
        public LogHandler()
        {
            List<string> appenderstringlist = new List<string>();
            appenderstringlist = HandlerFactory.getLogConfigHandler().getElementListByNodePath("/Configuration/Log");
            foreach (string appender in appenderstringlist)
            {
                switch (appender)
                {
                    case "FileAppender": appenders.Add(new FileAppender()); break;
                    case "ConsoleAppender": appenders.Add(new ConsoleAppender()); break;
                }
            }
        }
        public void append(string message, Level level, Category category)
        {
            foreach (Appender handler in appenders)
            {
                handler.write(message, level, category);
            }
        }
        public void flush()
        {
            foreach (Appender handler in appenders)
            {
                handler.flush(true);
            }
        }
    }
}
