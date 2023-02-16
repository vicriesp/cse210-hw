using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Assignement assignement = new Assignement("Victor", "Math");
        MathAssignment mathAssignment = new MathAssignment("Victor", "Math", "7.3", "8-19");
        string studentName = mathAssignment.GetSummaryName();
        string topic = mathAssignment.GetSummaryTopic();
        Console.WriteLine(studentName + " - " + topic);

        //MathAssignment mathAssignment = new MathAssignment("7.3", "8-19");
        string textbookSection = mathAssignment.GetHomeworkListSection();
        string problems = mathAssignment.GetHomeworkListProblems();
        Console.WriteLine("Section: " + textbookSection + " - " + "Problem: " + problems);

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        //string title = writingAssignment.GetWritingInformation();
        Console.WriteLine(writingAssignment.GetWritingInformation());
        
    }
}