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
            if (logFileCount < 0)
            {
                logFileCount = 0;
            }
        }
        public void write(string message, Level lineLevel)
        {
            if (lineLevel > logLevel)
            {
                logText += DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + message + "\0";
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
        private void writeToLogFile(string logText)
        {
            if (File.Exists(logPath))
                streamWriter = File.AppendText(logPath);
            else
                streamWriter = File.CreateText(logPath);
            streamWriter.WriteLine("{0} {1} {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), logText);
            streamWriter.Flush();
            streamWriter.Close();
        }
        private void generateNewLogFile()
        {
            int i = logFileCount - 1;
            while (i >= 0)
            {
                if (File.Exists(logPath + "." + i.ToString()))
                    File.Delete(logPath + "." + i.ToString());
                if (i == 0)
                    File.Move(logPath, logPath + "." + i.ToString());
                else
                    File.Move(logPath + "." + (i - 1).ToString(), logPath + "." + i.ToString());
                --i;
            }
        }
    }
}
