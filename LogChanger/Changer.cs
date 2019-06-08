using log4net;
using log4net.Appender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogChanger
{
    public class Changer
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(Changer));
        public static void ChangeLogName(string path)
        {
            var ret = Logger.Logger.Repository.GetAppenders();
            FileAppender f = ret[0] as FileAppender;
            f.File = path;
            f.ActivateOptions();           
        }
    }
}
