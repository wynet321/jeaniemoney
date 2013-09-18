using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Logger
    {
        private List<Handler> handlers = new List<Handler>();
        private static Logger logger;
        public static Logger getLogger()
        {
            if (logger == null)
                logger = new Logger();
            return logger;
        }
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
        public void append(string message, Level level, Category category)
        {
            if (handlers.Count == 0)
                return;
            foreach (Handler handler in handlers)
            {
                handler.write(message, level, category);
            }
        }
        public void flush()
        {
            if (handlers.Count == 0)
                return;
            foreach (Handler handler in handlers)
            {
                handler.flush();
            }
        }
    }
}
