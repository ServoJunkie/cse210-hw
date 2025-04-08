using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> _goals = new List<Goal>();

        int goalsFinished = 0;
        int simpleGoalsFinished = 0;
        int eternalGoalsFinished = 0;
        int checklistGoalsFinished = 0;

        int pointTotal = 0;
        bool finished = false;

        while (finished == false)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"You have {pointTotal} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string goalChoice = Console.ReadLine();

                if (goalChoice == "1")
                {
                    Console.Write("What is the name of your goal? ");
                    string _name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string _description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string _pointInput = Console.ReadLine();
                    int _pointValue = int.Parse(_pointInput);
                    
                    SimpleGoal currentSimpleGoal = new SimpleGoal(_name, _description, _pointValue);
                    _goals.Add(currentSimpleGoal);
                }
                else if (goalChoice == "2")
                {
                    Console.Write("What is the name of your goal? ");
                    string _name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string _description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string _pointInput = Console.ReadLine();
                    int _pointValue = int.Parse(_pointInput);
                    
                    EternalGoal currentEternalGoal = new EternalGoal(_name, _description, _pointValue);
                    _goals.Add(currentEternalGoal);
                }
                else if (goalChoice == "3")
                {
                    Console.Write("What is the name of your goal? ");
                    string _name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string _description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string _pointInput = Console.ReadLine();
                    int _pointValue = int.Parse(_pointInput);
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string _totalInput = Console.ReadLine();
                    int _totalToComplete = int.Parse(_totalInput);
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    string _bonusInput = Console.ReadLine();
                    int _bonusPoints = int.Parse(_bonusInput);
                    
                    ChecklistGoal currentChecklistGoal = new ChecklistGoal(_name, _description, _pointValue, _totalToComplete, _bonusPoints);
                    _goals.Add(currentChecklistGoal);
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please try again.");
                }
            }
            else if (userChoice == "2")
            {
                foreach (Goal currentgoal in _goals)
                {
                    currentgoal.Display();
                }
            }
            else if (userChoice == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string _filename = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(_filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");

                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    if (type == "Checklist")
                    {
                        int totalToComplete = int.Parse(parts[4]);
                        int bonus = int.Parse(parts[5]);

                        ChecklistGoal currentChecklistGoal = new ChecklistGoal(name, description, points, totalToComplete, bonus);
                        _goals.Add(currentChecklistGoal);
                    }
                    else if (type == "Eternal")
                    {
                        EternalGoal currentEternalGoal = new EternalGoal(name, description, points);
                        _goals.Add(currentEternalGoal);
                    }
                    else if (type == "Simple")
                    {
                        SimpleGoal currentSimpleGoal = new SimpleGoal(name, description, points);
                        _goals.Add(currentSimpleGoal);
                    }
                }
            }
            else if (userChoice == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string _filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(_filename))
                {
                    foreach (Goal currentGoal in _goals)
                    { 
                        outputFile.WriteLine(currentGoal.Serialize());
                    }
                }
            }
            else if (userChoice == "5")
            {
                Console.Write("Which goal did you accomplish? ");
                int goalNumber = int.Parse(Console.ReadLine());

                _goals[goalNumber].SetCompleted();
                int newPoints = _goals[goalNumber].GetPoints();
                pointTotal = pointTotal + newPoints;

                goalsFinished ++;
                if (_goals[goalNumber].GetGoalType() == "Simple")
                {
                    simpleGoalsFinished ++;
                }
                else if (_goals[goalNumber].GetGoalType() == "Eternal")
                {
                    eternalGoalsFinished ++;
                }
                else if (_goals[goalNumber].GetGoalType() == "Checklist")
                {
                    checklistGoalsFinished ++;
                }
            }
            else if (userChoice == "6")
            {
                finished = true;
            }
            else
            {
                Console.WriteLine("Invalid entry. Please try again.");
            }
        }

        Console.WriteLine("Thanks for using the goal program!");
        Console.WriteLine("You completed:");
        Console.WriteLine($"  {simpleGoalsFinished} simple goals");
        Console.WriteLine($"  {eternalGoalsFinished} eternal goals");
        Console.WriteLine($"  and {checklistGoalsFinished} checklist goals");
        Console.WriteLine($"for a total of {goalsFinished} goals finished.");
    }
}