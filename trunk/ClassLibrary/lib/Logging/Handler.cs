using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ClassLibrary
{
    public abstract class Handler
    {
        StreamWriter streamWriter;

        private int logFileCount;

        private int logFileSize;

        private string logFullPath;

        private int logLevel;
        public Handler()
        {
            
        }

        public void write()
        {
            
        }

               public void format()
        {
            
        }
    }
}
