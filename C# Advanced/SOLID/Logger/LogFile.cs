using System.Text;

namespace Logger
{
    public class LogFile : Appender
    {
        private const string filePath = "../../../log.txt";

        public LogFile(ILayout layout)
            : base(layout)
        {
        }

        public int Size => 5;

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            
        }
    }
}