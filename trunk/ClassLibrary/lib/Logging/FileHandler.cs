using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ClassLibrary.lib.Logging;

namespace ClassLibrary
{
    public class FileHandler : Handler
    {
        private StreamWriter streamWriter;
        private int logFileCount;
        private int logFileSize;
        private string logPath;
        private Level logLevel;
        private string logFormat;

        public FileHandler(HandlerConfig handlerConfig)
        {
            logFileCount = --handlerConfig.logFileCount;
            logFileSize = handlerConfig.logFileSize;
            logPath = handlerConfig.logPath;
            logLevel = handlerConfig.logLevel;
            logFormat = handlerConfig.logFormat;
            if (logFileCount < 0)
            {
                logFileCount = 0;
            }
            if (File.Exists(logPath))
                streamWriter = File.AppendText(logPath);
            else
                streamWriter = File.CreateText(logPath);
        }
        public void write(string message, Level lineLevel)
        {
            if (lineLevel > logLevel)
                writeToLogFile(message);
        }

        public void format()
        {

        }
        private void writeToLogFile(string message)
        {
            streamWriter.WriteLine("{0} {1} {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), message);
            streamWriter.Flush();
            if (new FileInfo(logPath).Length > logFileSize)
                generateNewLogFile();
        }
        private void generateNewLogFile()
        {
            streamWriter.Close();
            int i = logFileCount;
            string logText = File.ReadAllText(logPath);
            //keep log text with >logFileSize
            string newLogText = logText.Substring(logFileSize - 1, logText.Length - logFileSize);
            //keep log text with logFileSize 
            logText = logText.Substring(0, logFileSize);
            //after keep current log file content above, delete current log
            File.Delete(logPath);
            while (i >= 0)
            {
                if (File.Exists(logPath + "." + i.ToString()))
                    File.Delete(logPath + "." + i.ToString());
                if (i == 0)
                    File.WriteAllText(logPath + "." + i.ToString(), logText);
                else
                    File.Move(logPath + "." + (i - 1).ToString(), logPath + "." + i.ToString());
                --i;
            }
            streamWriter = File.CreateText(logPath);
            streamWriter.WriteLine(newLogText);
            streamWriter.Flush();
        }
    }
}
