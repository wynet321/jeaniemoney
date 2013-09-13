using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ClassLibrary.lib.Logging;

namespace ClassLibrary
{
    public class ConsoleHandler : Handler
    {
        //Console handler only need set level and categoryList before use.
        public ConsoleHandler(Config config)
        {
            level = config.level;
            categoryList = config.categoryList;
        }
        public override void write(string message, Level lineLevel, Category category)
        {
            if (categoryList.Contains(category) && lineLevel > level)
            {
                System.Console.WriteLine(DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + message + "\0");
            }
        }
    }
}
