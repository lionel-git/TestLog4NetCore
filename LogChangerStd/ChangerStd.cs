using log4net;
using log4net.Appender;
using System;

namespace LogChangerStd
{
    public class ChangerStd
    {

        private static readonly ILog Logger = LogManager.GetLogger(typeof(ChangerStd));
        public static void ChangeLogName(string path)
        {
            var ret = Logger.Logger.Repository.GetAppenders();
            FileAppender f = ret[0] as FileAppender;
            f.File = path;
            f.ActivateOptions();
        }
    }
}
