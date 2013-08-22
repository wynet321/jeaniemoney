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
            MemoryStream memoryStream=new MemoryStream(1024);
            memoryStream.
            BufferedStream bufferStream = new BufferedStream(,1024);

            streamWriter.Flush();
        }
        private void logFileGenerate()
        {
            if (new FileInfo(logPath).Length > logFileSize)
            {
                streamWriter.Close();
                int i = logFileCount;
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
                streamWriter = File.CreateText(logPath);
            }
        }
    }
}
