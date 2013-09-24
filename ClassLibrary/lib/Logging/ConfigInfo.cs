using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary.lib.Logging
{
    public class ConfigInfo
    {
        private static ConfigInfo configInfo;
        public static ConfigInfo getConfigInfo()
        {
            if (configInfo == null)
                configInfo = new ConfigInfo();
            return configInfo;
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
