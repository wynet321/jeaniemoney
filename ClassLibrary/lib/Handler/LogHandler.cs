using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ClassLibrary.lib
{
    public class LogHandler
    {
        private int logLevel;
        private string logFullPath;
        private int logFileSize;
        private int logFileCount;
        StreamWriter streamWriter;
        public LogHandler(string logLevelString, short logFileCount, int logFileSize, string logFullPath)
        {
            this.logFullPath = logFullPath;
            this.logFileSize = logFileSize;
            logFileCount -= 1;
            if (logFileCount < 0)
            {
                logFileCount = 0;
            }
            this.logFileCount = logFileCount;

            switch (logLevelString.ToUpper())
            {
                case "DEBUG": logLevel = 4; break;
                case "INFO": logLevel = 3; break;
                case "WARN": logLevel = 2; break;
                case "ERROR": logLevel = 1; break;
                default: //exception on log level and output
                    logLevel = 1; break;
            }

            if (File.Exists(logFullPath))
                streamWriter = File.AppendText(logFullPath);
            else
                streamWriter = File.CreateText(logFullPath);

            if (File.Exists(System.Environment.CurrentDirectory + "/trace.log"))
            {
                
                File.Copy(File.ReadAllText(System.Environment.CurrentDirectory + "/trace.log"), logFullPath, true);
                //streamWriter.Write(File.ReadAllText(System.Environment.CurrentDirectory + "/trace.log"));
                //streamWriter.Flush();
                //File.Delete(System.Environment.CurrentDirectory + "/trace.log");
            }
        }

        public LogHandler()
        {
            logLevel = 4;
            logFileCount = 1;
            logFileSize = 1024000;
            logFullPath = System.Environment.CurrentDirectory + "/trace.log";
            if (File.Exists(logFullPath))
                streamWriter = File.AppendText(logFullPath);
            else
                streamWriter = File.CreateText(logFullPath);
        }

        private void writeToLogFile(string message)
        {
            if (new FileInfo(logFullPath).Length > logFileSize)
            {
                streamWriter.Close();
                int i = logFileCount;
                while (i >= 0)
                {
                    if (File.Exists(logFullPath + "." + i.ToString()))
                        File.Delete(logFullPath + "." + i.ToString());
                    if (i == 0)
                        File.Move(logFullPath, logFullPath + "." + i.ToString());
                    else
                        File.Move(logFullPath + "." + (i - 1).ToString(), logFullPath + "." + i.ToString());
                    --i;
                }
                streamWriter = File.CreateText(logFullPath);
            }
            streamWriter.WriteLine("{0} {1} {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), message);
            streamWriter.Flush();
        }
        // debug
        public void debug(string message)
        {
            if (logLevel == 4)
                writeToLogFile("DEBUG - " + message);
        }
        //info
        public void info(string message)
        {
            if (logLevel > 2)
            {
                writeToLogFile("INFO - " + message);
            }
        }
        //warn
        public void warn(string message)
        {
            if (logLevel > 1)
            {
                writeToLogFile("WARN - " + message);
            }
        }
        //error
        public void error(string message)
        {
            //MessageBox
            if (logLevel > 0)
            {
                writeToLogFile("ERROR - " + message);
            }
        }
    }
}
