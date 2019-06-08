using System;
using System.IO;
using System.Reflection;
using System.Xml;
using log4net;
using log4net.Config;

namespace TestLog4NetCore
{
    class Program
    {
        public static void Main()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            var logger = LogManager.GetLogger(typeof(Program));
            logger.Error("Hello World!");
        }
    }
}
