using System;

namespace EternalQuest
{
    class SimpleGoal : Goal
    {
        
        private bool _isComplete;

       
        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)   
        {
            _isComplete = false;  
        }

        

        
        public override void RecordEvent()
        {
            if (_isComplete)
            {
                Console.WriteLine($"Goal '{GetShortName()}' is already complete!");
            }
            else
            {
                _isComplete = true;
                Console.WriteLine($"Goal '{GetShortName()}' completed! You earned {GetPoints()} points!");
            }
        }

        
        public override bool IsComplete()
        {
            return _isComplete;
        }

        
        public override string GetDetailsString()
        {
            string status = _isComplete ? "[X]" : "[ ]";
            return $"{status} {GetShortName()} - {GetDescription()} ({GetPoints()} points)";
        }

        public override string GetStringRepresentation()
        {
            return $"SimpleGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
        }
    }
}