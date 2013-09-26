using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ClassLibrary.lib;

namespace ClassLibrary
{
    public class ConsoleAppender : Appender
    {
        //Console handler only need set level and categoryList before use.
        public ConsoleAppender()
        {
            level = (Level)Enum.Parse(typeof(Level), HandlerFactory.getLogConfigHandler().getString("/Configuration/Log/FileAppender/Level"), true);
            categoryList = HandlerFactory.getLogConfigHandler().getElementListByNodePath("/Configuration/Log/FileAppender/Category").ConvertAll(new Converter<string, Category>(delegate(string x) { return (Category)Enum.Parse(typeof(Category), x, true); }));
        }
        public override void write(string message, Level lineLevel, Category category)
        {
            if (categoryList.Contains(category) && lineLevel > level)
            {
                System.Console.WriteLine(DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + message + "\0");
            }
        }
        public override void flush(bool flashAll)
        {
            return;
        }
    }
}
