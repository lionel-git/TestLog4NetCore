using System;
using System.IO;
using System.Reflection;
using System.Xml;
using log4net;
using log4net.Appender;
using log4net.Config;

namespace TestLog4NetCore
{
    class Program
    {
        public static void TestChangeFile(ILog logger)
        {
            var ret= logger.Logger.Repository.GetAppenders();
            FileAppender f = ret[0] as FileAppender;
            f.File = @"c:\tmp\titi.log";
            f.ActivateOptions();
            logger.Info("zizi");          
        }


        public static void Main()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            log4net.GlobalContext.Properties["LogFileName"] = @"c:\tmp\toto0.log"; //log file path 
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));


            var logger = LogManager.GetLogger(typeof(Program));
            logger.Error("Hello World!");

            log4net.GlobalContext.Properties["LogFileName"] = @"c:\tmp\toto2.log"; //log file path 
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            logger.Error("Hello World toto2");

            log4net.GlobalContext.Properties["LogFileName"] = @"c:\tmp\toto3.log"; //log file path 
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            logger.Error("Hello World toto3");

            TestChangeFile(logger);


        }
    }
}
