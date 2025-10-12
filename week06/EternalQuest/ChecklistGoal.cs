using System;

namespace EternalQuest
{
    class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus)
            : base(name, description, points)
        {
            _target = target;
            _bonus = bonus;
            _amountCompleted = 0;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;

            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You completed '{GetShortName()}' {_target} times!");
                Console.WriteLine($"You earned {GetPoints()} points + {_bonus} bonus points!");
            }
            else if (_amountCompleted > _target)
            {
                Console.WriteLine($"You've already finished '{GetShortName()}'!");
            }
            else
            {
                Console.WriteLine($"Progress: {_amountCompleted}/{_target} for '{GetShortName()}' — +{GetPoints()} points!");
            }
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public override string GetDetailsString()
        {
            string status = IsComplete() ? "[X]" : "[ ]";
            return $"{status} {GetShortName()} - {GetDescription()} ({GetPoints()} points each, Bonus: {_bonus}) — Completed {_amountCompleted}/{_target}";
        }

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
        }
    }
}