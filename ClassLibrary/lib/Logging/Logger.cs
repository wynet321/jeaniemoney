using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Logger
    {
        private List<Handler> handlers;
        public void addHandler(Handler handler)
        {
            if (handler != null)
                handlers.Add(handler);
        }
        public void removeHandler(Handler handler)
        {
            if (handler != null)
                handlers.Remove(handler);
        }
        public void append(string message, Level level)
        {
            //if (logLevel == 4)
            //    writeToLogFile("DEBUG - " + message);
            if (handlers == null || handlers.Count < 1)
                return;
            foreach (Handler handler in handlers)
            {
                handler.write(message, level);
            }
        }
    }
}
