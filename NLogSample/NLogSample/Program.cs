using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogSample
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            logger.Trace("trace log message");
            logger.Debug("debug log message");
            logger.Info("info log message");
            logger.Warn("warn log message");
            logger.Error(new Exception("exception test"), "error log message");
            logger.Fatal("fatal log message");

            Console.ReadLine();
        }

    }
}
