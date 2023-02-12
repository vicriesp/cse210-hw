using System;

using System.Collections.Generic;

public class Write
{
    public string entry;

    public string displayQuestions()
    {
        
            
            string[] questionsJournal = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"};
    
            Random rnd = new Random();
            int randNum = rnd.Next(0, questionsJournal.Length);
            Console.WriteLine(questionsJournal[randNum]);

            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();

            string answer = Console.ReadLine();
            entry = dateText + "    " + questionsJournal[randNum] + "\n" + "Answer: " + answer;
            Console.WriteLine(entry);

            return entry;
        

    }
}