using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary.lib.Logging
{
    public class Config
    {
        public int fileCount { get; set; }

        public int fileSize { get; set; }

        public string path { get; set; }

        public Level level { get; set; }

        public List<Category> categoryList { get; set; }
    }
}
