using System;

namespace EternalQuest
{
    class ProgressGoal : Goal
    {
        private int _progress;
        private int _target;
        private int _bonus;

        public ProgressGoal(string name, string description, int points, int target, int bonus)
            : base(name, description, points)
        {
            _target = target;
            _bonus = bonus;
            _progress = 0;
        }

        public override void RecordEvent()
        {
            Console.Write($"\nHow much progress did you make toward '{GetShortName()}' today (respond with an integer)?");
            int amount = int.Parse(Console.ReadLine());

            _progress += amount;

            if (_progress < _target)
            {
                Console.WriteLine($"Nice job! You've added {amount} to your total progress.");
                Console.WriteLine($"Current progress: {_progress}/{_target}");
                Console.WriteLine($"You earned {GetPoints()} points for your effort!");
            }
            else if (_progress == _target)
            {
                Console.WriteLine($"\n🏁 Amazing! You reached your goal: '{GetShortName()}'!");
                Console.WriteLine($"You’ve completed {_target}/{_target} total progress.");
                Console.WriteLine($"You earned {GetPoints()} points plus a {_bonus}-point bonus!");
            }
            else
            {
                Console.WriteLine($"\nWow! You’ve gone beyond the target for '{GetShortName()}'!");
                Console.WriteLine($"Progress: {_progress}/{_target} — keep pushing your limits!");
                Console.WriteLine($"You still earned {GetPoints()} points for staying consistent!");
            }
        }

        public override bool IsComplete()
        {
            return _progress >= _target;
        }

        public override string GetDetailsString()
        {
            string status = IsComplete() ? "[X]" : "[ ]";
            return $"{status} {GetShortName()} - {GetDescription()} ({GetPoints()} pts per update, Bonus: {_bonus}) → Progress: {_progress}/{_target}";
        }

        public override string GetStringRepresentation()
        {
            return $"ProgressGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_progress}|{_target}|{_bonus}";
        }
    }
}