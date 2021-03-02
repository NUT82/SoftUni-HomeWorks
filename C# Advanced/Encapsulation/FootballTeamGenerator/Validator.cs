using System;

namespace FootballTeamGenerator
{
    public static class Validator
    {
        public static void ThrowIfStringIsNullOrEmpty(string name, string exeptionMsg)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(exeptionMsg);
            }
        }
    }
}
