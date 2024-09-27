using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NLog;
namespace LaserSolution
{
     class MyLogger
    {
        Logger logger;
        private MyLogger(NLog.Logger x_logger)
        {
            this.logger = x_logger;
        }
        public MyLogger(string x_name)
        {
            logger=NLog.LogManager.GetLogger(x_name);
        }
        public void Trace(string x_message)
        {

        }
    }

}
