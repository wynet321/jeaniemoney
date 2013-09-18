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
        private int fileCount;
        private int fileSize;
        private string path;
        private string text;
        private int textWriteUnitSize;
        private int textWriteUnitCount;

        public FileHandler(Config config)
        {
            fileCount = config.fileCount;
            fileSize = config.fileSize;
            textWriteUnitSize = (fileSize >= 1024) ? 1024 : fileSize;
            path = config.path;
            level = config.level;
            categoryList = config.categoryList;
            if (fileCount < 0)
            {
                fileCount = 0;
            }
        }
        public override void write(string message, Level lineLevel, Category category)
        {
            if (categoryList.Contains(category) && lineLevel >= level)
            {
                text += DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " " + message + "\r";
                if (text.Length >= textWriteUnitSize)
                {
                    writeToLogFile(text.Substring(0, textWriteUnitSize));
                    text = text.Substring(textWriteUnitSize - 1, text.Length - textWriteUnitSize);
                    textWriteUnitCount++;
                    if (textWriteUnitCount >= fileSize / textWriteUnitSize)
                    {
                        generateNewLogFile();
                        textWriteUnitCount = 0;
                    }
                }
            }
        }
        private void writeToLogFile(string logText)
        {
            if (File.Exists(path))
                streamWriter = File.AppendText(path);
            else
                streamWriter = File.CreateText(path);
            //streamWriter.WriteLine("{0} {1} {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), logText);
            streamWriter.Write(logText);
            streamWriter.Flush();
            streamWriter.Close();
        }
        private void generateNewLogFile()
        {
            int i = fileCount - 1;
            while (i >= 0)
            {
                if (File.Exists(path + "." + i.ToString()))
                    File.Delete(path + "." + i.ToString());
                if (i == 0)
                    File.Move(path, path + "." + i.ToString());
                else
                    File.Move(path + "." + (i - 1).ToString(), path + "." + i.ToString());
                --i;
            }
        }
        public override void flush()
        {
            writeToLogFile("");
        }

    }
}
