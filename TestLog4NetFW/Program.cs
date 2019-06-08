using log4net;
using log4net.Appender;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLog4NetFW
{
    class Program
    {
        public static void TestChangeFile(ILog logger)
        {
            var ret = logger.Logger.Repository.GetAppenders();
            FileAppender f = ret[0] as FileAppender;
            f.File = @"c:\tmp\titi2.log";
            f.ActivateOptions();
            logger.Info("titi");
        }


        static void Main(string[] args)
        {
            //XmlConfigurator.Configure(new FileInfo("log4net.config"));
            var logger = LogManager.GetLogger(typeof(Program));
            var logger2 = LogManager.GetLogger("zuzu");
            logger.Info("Test");
            logger2.Info("zuzu");

            // TestChangeFile(logger);
            //LogChanger.Changer.ChangeLogName(@"c:\tmp\zzz.log");
            LogChangerStd.ChangerStd.ChangeLogName(@"c:\tmp\zzz.log");
            logger2.Info("rrrr");

            Console.WriteLine("Wait for key...");
            Console.ReadKey();

        }
    }
}
