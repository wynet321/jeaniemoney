using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary.lib.Logging
{
    class HandlerConfig
    {
        public int logFileCount { get; set; }

        public int logFileSize { get; set; }

        public string logPath { get; set; }

        public Level logLevel { get; set; }
    }
}
