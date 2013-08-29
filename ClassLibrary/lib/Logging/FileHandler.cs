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
        private string logText;
        private int logTextWriteUnitSize;
        private int logTextWriteUnitCount;

        public FileHandler(HandlerConfig handlerConfig)
        {
            logTextWriteUnitSize = logFileSize > 1024 ? 1024 : logFileSize;
            logFileCount = handlerConfig.logFileCount;
            logFileSize = handlerConfig.logFileSize;
            logPath = handlerConfig.logPath;
            logLevel = handlerConfig.logLevel;
            logFormat = handlerConfig.logFormat;
            if (logFileCount < 0)
            {
                logFileCount = 0;
            }
           
        }
        public void write(string message, Level lineLevel)
        {
            if (lineLevel > logLevel)
            {
                logText +=  DateTime.Now.ToShortDateString()+DateTime.Now.ToShortTimeString()+message + "\0";

                if (logText.Length >= logTextWriteUnitSize)
                {
                    writeToLogFile(logText.Substring(0, logTextWriteUnitSize));
                    logText = logText.Substring(logTextWriteUnitSize - 1, logText.Length - logTextWriteUnitSize);
                    logTextWriteUnitCount++;
                        if (logTextWriteUnitCount >= logFileSize / logTextWriteUnitSize)
                        {
                            generateNewLogFile();
                            logTextWriteUnitCount = 0;
                        }
                }
            }
        }

        public void format()
        {

        }
        private void writeToLogFile(string logText)
        {
            if (File.Exists(logPath))
                streamWriter = File.AppendText(logPath);
            else
                streamWriter = File.CreateText(logPath);
            streamWriter.WriteLine(logText);
            streamWriter.Flush();
            streamWriter.Close();
        }
        private void generateNewLogFile()
        {
            int i = logFileCount-1;
            while (i > 1)
            {
                if (File.Exists(logPath + "." + i.ToString()))
                    File.Delete(logPath + "." + i.ToString());
                    File.Move(logPath + "." + (i - 1).ToString(), logPath + "." + i.ToString());
                --i;
            }
        }
    }
}
