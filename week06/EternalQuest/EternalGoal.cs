using System;

namespace EternalQuest
{
    class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override void RecordEvent()
        {
            Console.WriteLine($"Eternal goal '{GetShortName()}' recorded! You earned {GetPoints()} points!");
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetDetailsString()
        {
            return $"[∞] {GetShortName()} - {GetDescription()} ({GetPoints()} points each time)";
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}";
        }
    }
}