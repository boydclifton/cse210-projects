using System;

namespace EternalQuest
{
    class Goal
    {
        private string _shortName;
        private string _description;
        private int _points;

        public Goal(string name, string description, int points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        public virtual void RecordEvent()
        {
            Console.WriteLine("This goal type doesn’t define RecordEvent yet.");
        }

        public virtual bool IsComplete()
        {
            return false;
        }

        public virtual string GetDetailsString()
        {
            return $"{_shortName} - {_description} ({_points} points)";
        }

        public virtual string GetStringRepresentation()
        {
            return $"Goal|{_shortName}|{_description}|{_points}";
        }

        public string GetShortName()
        {
            return _shortName;
        }

        public string GetDescription()
        {
            return _description;
        }

        public int GetPoints()
        {
            return _points;
        }
    }
}