using System;

namespace FootballTeamGenerator
{
    public class Stat
    {
        public const int maxStatValue = 100;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stat(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public int Endurance
        {
            get => endurance;
            private set
            {
                ThrowIfInvalidStatValue(value, nameof(Endurance));

                endurance = value;
            }
        }
        public int Sprint
        {
            get => sprint;
            private set
            {
                ThrowIfInvalidStatValue(value, nameof(Sprint));

                sprint = value;
            }
        }

        public int Dribble
        {
            get => dribble;
            private set
            {
                ThrowIfInvalidStatValue(value, nameof(Dribble));

                dribble = value;
            }
        }

        public int Passing
        {
            get => passing;
            private set
            {
                ThrowIfInvalidStatValue(value, nameof(Passing));

                passing = value;
            }
        }

        public int Shooting
        {
            get => shooting;
            private set
            {
                ThrowIfInvalidStatValue(value, nameof(Shooting));

                shooting = value;
            }
        }

        private void ThrowIfInvalidStatValue(int value, string stat)
        {
            if (value < 0 || value > maxStatValue)
            {
                throw new ArgumentException($"{stat} should be between 0 and {maxStatValue}.");
            }
            
        }
    }
}
