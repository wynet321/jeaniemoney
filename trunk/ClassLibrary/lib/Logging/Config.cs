using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary.lib.Logging
{
    public class Config
    {
        private static Config config;
        public static Config getConfig()
        {
            if (config == null)
                config = new Config();
            return config;
        }

        public int fileCount { get; set; }

        public int fileSize { get; set; }

        public string path { get; set; }

        public Level level { get; set; }

        public List<Category> categoryList { get; set; }

        public Category stringToCategory(string category)
        {
            return (Category)Enum.Parse(typeof(Category), category, true);
        }
    }
}
