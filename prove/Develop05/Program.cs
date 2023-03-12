using System;

class Program
{
    static void Main(string[] args)
    {  
        bool statement = true;
        Goals goal = new Goals();
        ListGoals listgoal = new ListGoals();
        
        
        while (statement == true)
        {
            Console.Clear();
            Console.WriteLine($"You have {goal._goalPoints} points.");
            Console.WriteLine(" ");
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Create new goal");
            Console.WriteLine("  2. List goals");
            Console.WriteLine("  3. Save goals");
            Console.WriteLine("  4. Load goals");
            Console.WriteLine("  5. Record events");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choise from the menu: ");
            string choise = Console.ReadLine();
            goal = new Goals();

            if (choise == "1")
            {
                Console.WriteLine("Type of goals are:");
                Console.WriteLine("  1. Simple goal");
                Console.WriteLine("  2. Eternal goal");
                Console.WriteLine("  3. Checklist goal");
                Console.Write("Which type of goal would you like to create? ");
                string gOption = Console.ReadLine();

               if (gOption == "1")
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string amount = Console.ReadLine();
                    int amountFin = int.Parse(amount);
                    SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription);
                    listgoal._goals.Add(simpleGoal);

                    
                }
                else if (gOption == "2")
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is the short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string amount = Console.ReadLine();
                    int amountFin = int.Parse(amount);
                    EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription);
                    listgoal._goals.Add(eternalGoal);
                    
                    
                }
                else if (gOption == "3")
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is the short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string amount = Console.ReadLine();
                    int amountFin = int.Parse(amount);
                    // Console.Write("How many times does this goal need to be accomplish for a bonus? ");
                    // string amount = Console.ReadLine();
                    // // int points = int.Parse(amount);
                    // Console.Write("What is the bonus for accomplish ? ");
                    // string amount = Console.ReadLine();
                    // // int points = int.Parse(amount);
                    EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription);
                    listgoal._goals.Add(eternalGoal);
                    
                    
                }
            }
            else if (choise == "2")
            {
                Console.WriteLine(" ");
                listgoal.displayGoals();

                Console.ReadLine();
            }
            else if (choise == "3")
            {
                SaveGoals saveGoals = new SaveGoals();
                saveGoals.GetSaveFile();
            }
            else if (choise == "4")
            {
                LoadGoals lGoals = new LoadGoals();
                lGoals.readFile();
            }
            
        }
    }
}