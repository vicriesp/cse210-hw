using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        MathAssignment mathAssignment = new MathAssignment("Victor", "Math", "7.3", "8-19");
        string studentName = mathAssignment.GetSummaryName();
        string topic = mathAssignment.GetSummaryTopic();
        Console.WriteLine(studentName + " - " + topic);

        
        string textbookSection = mathAssignment.GetHomeworkListSection();
        string problems = mathAssignment.GetHomeworkListProblems();
        Console.WriteLine("Section: " + textbookSection + " - " + "Problem: " + problems);

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetWritingInformation());
        
    }
}