    using System;
    using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
public class GoalManager

    {
        private LinkedList<Goal> _goals = new LinkedList<Goal>();
        private int _score;

        public void Start()
        {
            bool running = true;
            while(running)
            {
                DisplayPlayerInfo();
                Console.WriteLine("1. Create Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Select a choice from the menu: ");
                string choice = Console.ReadLine();
                Console.WriteLine();
                
                switch(choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        ListGoalDetails();
                        break;
                    case "3":
                        SaveGoals();
                        break;
                    case "4":
                        LoadGoals();
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"You have {_score} points");
        }
        public void ListGoalDetails()
        {
            Console.WriteLine("The goals are: ");
            int index = 1;
            foreach (var goal in _goals)
            {
                Console.WriteLine($"{index}.{goal.GetDetailString()}");
                index++;        }Console.WriteLine();
        }
        public void CreateGoal()
        {
            Console.WriteLine("The types of Goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n");
            Console.Write("Which type of goal would you like to create? ");
            string goalType = Console.ReadLine();
            Console.Write("What is the name your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            if (goalType == "1")
            {
                _goals.AddLast(new SimpleGoal(name, description,points));
            }
            else if (goalType == "2")
            {
                _goals.AddLast(new EternalGoal(name, description,points));
            }
            else if (goalType == "3")
            {
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                 int targetCount = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.AddLast(new ChecklistGoal(name, description, points, targetCount));
            }
        }
       public void RecordEvent()
{
    int index = 1;
    foreach (var goal in _goals)
    {
        Console.WriteLine($"{index++}. {goal.GetDetailString()}");
    }

    Console.WriteLine("Select the goal number you completed an event for:");
    int goalIndex = int.Parse(Console.ReadLine());

    
    Goal selectedGoal = null;
    int currentIndex = 1;
    foreach (var goal in _goals)
    {
        if (currentIndex == goalIndex)
        {
            selectedGoal = goal;
            break;
        }
        currentIndex++;
    }

    if (selectedGoal != null)
    {
        selectedGoal.RecordEvent();
        
        
        if (selectedGoal.IsComplete())
        {
            _score += selectedGoal.Points;
            Console.WriteLine($"Goal completed! Your score increased by {selectedGoal.Points} points.");
        }
    }
    else
    {
        Console.WriteLine("Invalid goal selection.");
    }
}       
            public void SaveGoals()
        {
            Console.Write("Enter the filename to save your goals: ");
            string filepath = Console.ReadLine();

            if (string.IsNullOrEmpty(filepath))
            {
                Console.WriteLine("Filename cannot be empty. Please try again.");
                return;
            }

            using (StreamWriter writer = new StreamWriter(filepath))
            {
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }

            Console.WriteLine("Goals successfully saved.");
        }
            public void LoadGoals()
        {
            Console.Write("Enter the filename to load your goals from: ");
            string filepath = Console.ReadLine();

            if (string.IsNullOrEmpty(filepath))
            {
                Console.WriteLine("Filename cannot be empty. Please try again.");
                return;
            }

            if (!File.Exists(filepath))
            {
                Console.WriteLine("No file found with the specified name.");
                return;
            }

            _goals.Clear();
            using (StreamReader reader = new StreamReader(filepath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var typeDataSplit = line.Split(':', 2);
                    if (typeDataSplit.Length < 2)
                    {
                        Console.WriteLine("Invalid format in file. Skipping line.");
                        continue;  
                    }

                    var goalType = typeDataSplit[0];
                    var goalData = typeDataSplit[1].Split(',');

                    Goal newGoal = null;

                    try
                    {
                        switch (goalType)
                        {
                            case "SimpleGoal":
                                if (goalData.Length >= 3) 
                                {
                                    newGoal = new SimpleGoal(
                                        goalData[0],        
                                        goalData[1],        
                                        int.Parse(goalData[2])
                                    );
                                }
                                else
                                {
                                    Console.WriteLine("Invalid data for SimpleGoal. Skipping entry.");
                                }
                                break;

                            case "EternalGoal":
                                if (goalData.Length >= 3) 
                                {
                                    newGoal = new EternalGoal(
                                        goalData[0],         
                                        goalData[1],         
                                        int.Parse(goalData[2]) 
                                    );
                                }
                                else
                                {
                                    Console.WriteLine("Invalid data for EternalGoal. Skipping entry.");
                                }
                                break;

                            case "ChecklistGoal":
                                if (goalData.Length >= 5) 
                                {
                                    newGoal = new ChecklistGoal(
                                        goalData[0],         
                                        goalData[1],         
                                        int.Parse(goalData[2]), 
                                        int.Parse(goalData[3]), 
                                        int.Parse(goalData[4])  
                                    );
                                }
                                else
                                {
                                    Console.WriteLine("Invalid data for ChecklistGoal. Skipping entry.");
                                }
                                break;

                            default:
                                Console.WriteLine($"Unknown goal type: {goalType}. Skipping entry.");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading goal: {ex.Message}. Skipping entry.");
                    }

                    if (newGoal != null)
                    {
                        _goals.AddLast(newGoal);
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
    }