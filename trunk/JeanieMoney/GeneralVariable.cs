using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary.lib.Handler;
using ClassLibrary.lib.DBImpl;
using ClassLibrary.lib;

namespace JeanieMoney
{
    class GeneralVariable
    {
        public static string configUri = System.Environment.CurrentDirectory + "/" + "config.xml";
        public static XmlHandler configHandler = HandlerFactory.getConfigHandler(configUri);
        public static IDbHandler dbHandler;
    }
}
