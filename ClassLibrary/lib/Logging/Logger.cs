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
            if(handler!=null)
                handlers.Add(handler);
        }
        public void removeHandler(Handler handler)
        {
            if(handler!=null)
                handlers.Remove(handler);
        }
        public void append(string message,Level level)
        {
            //if (logLevel == 4)
            //    writeToLogFile("DEBUG - " + message);
            if (handlers == null || handlers.Count < 1)
                return;
            foreach (Handler handler in handlers)
            {
                handler.write();
            }
        }

        //public Logger(string logLevelString, short logFileCount, int logFileSize, string logFullPath)
        //{
        //    this.logFullPath = logFullPath;
        //    this.logFileSize = logFileSize;
        //    logFileCount -= 1;
        //    if (logFileCount < 0)
        //    {
        //        logFileCount = 0;
        //    }
        //    this.logFileCount = logFileCount;

        //    switch (logLevelString.ToUpper())
        //    {
        //        case "DEBUG": logLevel = 4; break;
        //        case "INFO": logLevel = 3; break;
        //        case "WARN": logLevel = 2; break;
        //        case "ERROR": logLevel = 1; break;
        //        default: //exception on log level and output
        //            logLevel = 1; break;
        //    }

        //    if (File.Exists(logFullPath))
        //        streamWriter = File.AppendText(logFullPath);
        //    else
        //        streamWriter = File.CreateText(logFullPath);

        //    if (File.Exists(System.Environment.CurrentDirectory + "/trace.log"))
        //    {

        //        File.Copy(File.ReadAllText(System.Environment.CurrentDirectory + "/trace.log"), logFullPath, true);
        //        //streamWriter.Write(File.ReadAllText(System.Environment.CurrentDirectory + "/trace.log"));
        //        //streamWriter.Flush();
        //        //File.Delete(System.Environment.CurrentDirectory + "/trace.log");
        //    }
        //}

        public Logger()
        {
            //logLevel = 4;
            //logFileCount = 1;
            //logFileSize = 1024000;
            //logFullPath = System.Environment.CurrentDirectory + "/trace.log";
            //if (File.Exists(logFullPath))
            //    streamWriter = File.AppendText(logFullPath);
            //else
            //    streamWriter = File.CreateText(logFullPath);
        }
    }
}
