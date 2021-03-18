namespace Logger
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            string output = string.Format(layout.GetLayout(), dateTime, reportLevel, message);
            System.Console.WriteLine(output);
        }
    }
}