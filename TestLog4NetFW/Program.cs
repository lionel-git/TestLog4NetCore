using log4net;
using log4net.Appender;
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
            var logger = LogManager.GetLogger("zozo");
            logger.Info("Test");

            TestChangeFile(logger);
        }
    }
}
