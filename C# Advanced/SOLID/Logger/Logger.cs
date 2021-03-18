using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class Logger
    {
        private Appender appender;
        public Logger(Appender appender)
        {
            this.appender = appender;
        }

        public void Error(string dateTime, string message)
        {
            appender.Append(dateTime, ReportLevel.Error, message);
        }

        public void Info(string dateTime, string message)
        {
            appender.Append(dateTime, ReportLevel.Info, message);
        }
    }
}
