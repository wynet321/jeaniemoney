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
                text += DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " " + lineLevel.ToString() + " " + category.ToString() + " " + message + "\r";
                flush(false);
            }
        }
        public override void flush(bool flashAll)
        {
            //int lengthAlreadyInLog=0;
            if (File.Exists(path))
            {
                //lengthAlreadyInLog = File.ReadAllText(path).Length;
                streamWriter = File.AppendText(path);
            }
            else
                streamWriter = File.CreateText(path);
            while (text.Length >= textWriteUnitSize)
            {
                streamWriter.Write(text.Substring(0, textWriteUnitSize));
                streamWriter.Flush();
                text = text.Substring(textWriteUnitSize, text.Length - textWriteUnitSize);
                textWriteUnitCount++;
                if (textWriteUnitCount >= fileSize / textWriteUnitSize)
                {
                    streamWriter.Close();
                    generateNewLogFile();
                    textWriteUnitCount = 0;
                    streamWriter = File.CreateText(path);
                }
            }
            if(flashAll)
                streamWriter.Write(text);
            streamWriter.Close();
        }
        private void generateNewLogFile()
        {
            if (fileCount == 1 && File.Exists(path))
                File.Delete(path);
            else
            {
                int i = fileCount - 1;
                while (i > 1)
                {
                    if (File.Exists(path + "." + i.ToString()))
                        File.Delete(path + "." + i.ToString());
                    if (File.Exists(path + "." + (i - 1).ToString()))
                        File.Move(path + "." + (i - 1).ToString(), path + "." + i.ToString());
                    --i;
                }
                if (File.Exists(path + ".1"))
                    File.Delete(path + ".1");
                File.Move(path, path + ".1");
            }
        }
    }
}
