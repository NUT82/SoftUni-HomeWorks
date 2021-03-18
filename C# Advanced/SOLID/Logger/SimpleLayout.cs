using System;

namespace Logger
{
    public class SimpleLayout : ILayout
    {
        public string GetLayout()
        {
            return "{0} - {1} - {2}";
        }
    }
}