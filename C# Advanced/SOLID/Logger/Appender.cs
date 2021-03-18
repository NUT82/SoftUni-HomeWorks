using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public abstract class Appender
    {
        protected ILayout layout;

        public Appender(ILayout layout)
        {
            this.layout = layout;
        }

        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);
    }
}
