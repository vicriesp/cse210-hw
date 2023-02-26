using System;

class Program
{
    static void Main(string[] args)
    {   
        string option = "4";

        while (option == "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Start Breathing Activity.");
            Console.WriteLine("     2. Start Reflecting Activity.");
            Console.WriteLine("     3. Start Listing Activity");
            Console.WriteLine("     4. Quit.");
            Console.Write("Select a choise from the menu: ");
            option = Console.ReadLine();

            if (option == "1")
            {
                Console.Clear();
                Activity activity = new Activity(
                "Welcome to the breathing Activity.", 
                "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");
                Console.WriteLine(activity.GetStartingMessage());
                Console.WriteLine(" ");
                Console.WriteLine(activity.GetWelcomeMessage());
                Console.WriteLine(" ");
            
                BreathingActivity bAct = new BreathingActivity(
                " ");
                Console.WriteLine(bAct.GetBreathInOut());           
                bAct.timeToBreath();
            
            }
            if (option == "2")
            {
                Console.Clear();
                ReflectingActivity activity2 = new ReflectingActivity("Welcome to the reflecting Activity.", 
                "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life",
                "Consider the following prompt:");
                Console.WriteLine(activity2.GetStartingMessage());
                Console.WriteLine(" ");
                Console.WriteLine(activity2.GetWelcomeMessage());
                Console.WriteLine(" ");
                Console.WriteLine(activity2.GetReflectingList());
                Console.WriteLine(" ");
                activity2.GetList();
            } 
            if (option == "3")
            {
                Console.Clear();
                ListingActivity activity3 = new ListingActivity("Welcome to the listing Activity.",
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                " ");
                Console.WriteLine(activity3.GetStartingMessage());
                Console.WriteLine(" ");
                Console.WriteLine(activity3.GetWelcomeMessage());
                Console.WriteLine(" ");
                Console.WriteLine(activity3.GetInstructions());
                Console.WriteLine(" ");
                activity3.GetSpinerAnimation();
                activity3.GetListResponses();
                activity3.GetEnd();
            }
            if (option == "4")
            {
                Console.WriteLine("Good by!!");
            }   
        }
    }
}