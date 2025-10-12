using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void Start()
        {
            string choice = "";

            while (choice != "7")
            {
                Console.WriteLine("\n--- Eternal Quest ---");
                Console.WriteLine("1. Display Player Info");
                Console.WriteLine("2. List Goal Names");
                Console.WriteLine("3. List Goal Details");
                Console.WriteLine("4. Create New Goal");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Save / Load Goals");
                Console.WriteLine("7. Quit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    DisplayPlayerInfo();
                }
                else if (choice == "2")
                {
                    ListGoalNames();
                }
                else if (choice == "3")
                {
                    ListGoalDetails();
                }
                else if (choice == "4")
                {
                    CreateGoal();
                }
                else if (choice == "5")
                {
                    RecordEvent();
                }
                else if (choice == "6")
                {
                    SaveOrLoadMenu();
                }
                else if (choice == "7")
                {
                    Console.WriteLine("Goodbye! Keep working on your Eternal Quest!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"\nCurrent Score: {_score}");
        }

        public void ListGoalNames()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals yet.");
                return;
            }

            Console.WriteLine("\nGoal Names:");
            int i = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{i}. {goal.GetShortName()}");
                i++;
            }
        }

        public void ListGoalDetails()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals yet.");
                return;
            }

            Console.WriteLine("\nGoal Details:");
            int i = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{i}. {goal.GetDetailsString()}");
                i++;
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine("\nTypes of Goals:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Progress Goal");
            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter description: ");
            string desc = Console.ReadLine();
            Console.Write("Enter point value: ");
            int points = int.Parse(Console.ReadLine());

            Goal newGoal = null;

            if (choice == "1")
            {
                newGoal = new SimpleGoal(name, desc, points);
            }
            else if (choice == "2")
            {
                newGoal = new EternalGoal(name, desc, points);
            }
            else if (choice == "3")
            {
                Console.Write("Enter target number of completions: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, desc, points, target, bonus);
            }
            else if (choice == "4")
            {
                Console.Write("Enter target amount: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for finishing: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ProgressGoal(name, desc, points, target, bonus);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            _goals.Add(newGoal);
            Console.WriteLine($"Goal '{name}' created!");
        }

        public void RecordEvent()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals to record yet.");
                return;
            }

            ListGoalNames();
            Console.Write("Which goal did you accomplish? (number): ");
            int num = int.Parse(Console.ReadLine());

            if (num < 1 || num > _goals.Count)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }

            Goal selected = _goals[num - 1];
            selected.RecordEvent();
            _score += selected.GetPoints();
            Console.WriteLine($"Total Score: {_score}");
        }

        public void SaveGoals()
        {
            Console.Write("Enter filename to save to (e.g., goals.txt): ");
            string file = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine(_score);
                foreach (Goal g in _goals)
                {
                    sw.WriteLine(g.GetStringRepresentation());
                }
            }

            Console.WriteLine("Goals saved successfully!");
        }

        public void LoadGoals()
        {
            Console.Write("Enter filename to load: ");
            string file = Console.ReadLine();

            if (!File.Exists(file))
            {
                Console.WriteLine("File not found.");
                return;
            }

            _goals.Clear();
            string[] lines = File.ReadAllLines(file);
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];

                if (type == "SimpleGoal")
                {
                    SimpleGoal sg = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    bool completed = bool.Parse(parts[4]);
                    if (completed) sg.RecordEvent();
                    _goals.Add(sg);
                }
                else if (type == "EternalGoal")
                {
                    EternalGoal eg = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                    _goals.Add(eg);
                }
                else if (type == "ChecklistGoal")
                {
                    ChecklistGoal cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                        int.Parse(parts[5]), int.Parse(parts[6]));
                    int amountDone = int.Parse(parts[4]);
                    for (int j = 0; j < amountDone; j++)
                    {
                        cg.RecordEvent();
                    }
                    _goals.Add(cg);
                }
                else if (type == "ProgressGoal")
                {
                    ProgressGoal pg = new ProgressGoal(parts[1], parts[2], int.Parse(parts[3]),
                        int.Parse(parts[5]), int.Parse(parts[6]));
                    _goals.Add(pg);
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }

        private void SaveOrLoadMenu()
        {
            Console.WriteLine("\n1. Save Goals");
            Console.WriteLine("2. Load Goals");
            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "1")
                SaveGoals();
            else if (choice == "2")
                LoadGoals();
            else
                Console.WriteLine("Invalid option.");
        }
    }
}