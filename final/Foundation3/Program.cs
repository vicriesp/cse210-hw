using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Lectures lectures = new Lectures("Harry Potter", "Cience and Majic", "October 22, 2023",
         "3:30pm", "State Street, Provo.", "Lecture", "John R.", "200 people");
        Console.WriteLine(" ");
        Console.WriteLine("**LECTURE EVENT**");
        Console.WriteLine(" ");
        Console.WriteLine("1. Standard Details:");
        Console.WriteLine(lectures.GetSumary());
        Console.WriteLine(" ");
        Console.WriteLine("2. Full Details:");
        Console.WriteLine(lectures.GetSumary());
        Console.WriteLine(lectures.GetSpeakerCapacity());
        Console.WriteLine(" ");
        Console.WriteLine("3. Short Description:");
        Console.WriteLine(lectures.GetShortDetails());
        Console.WriteLine(" ");
        Console.WriteLine("---------------------------------------------------------------");

        Receptions receptions = new Receptions("Rivera's", "Wedding", "July 23, 2023",
        "6:00pm", "300 S. 960 E. Provo", "Receptions", "rsvp@events.com");
        Console.WriteLine(" ");
        Console.WriteLine("**RECEPTION EVENT**");
        Console.WriteLine(" ");
        Console.WriteLine("1. Standard Details:");
        Console.WriteLine(receptions.GetSumary());
        Console.WriteLine(" ");
        Console.WriteLine("2. Full Details:");
        Console.WriteLine(receptions.GetSumary());
        Console.WriteLine(receptions.GetEmail());
        Console.WriteLine(" ");
        Console.WriteLine("3. Short Description:");
        Console.WriteLine(receptions.GetShortDetails());
        Console.WriteLine(" ");
        Console.WriteLine("---------------------------------------------------------------");

        Outdoor outdoor = new Outdoor("Concert", "Smooth Jazz",
        "January 15, 2024", "6:30pm", "Viviant Park", "Outdoor", "70deg, Sunny");
        Console.WriteLine(" ");
        Console.WriteLine("**OUTDOOR EVENT**");
        Console.WriteLine(" ");
        Console.WriteLine("1. Standard Details:");
        Console.WriteLine(outdoor.GetSumary());
        Console.WriteLine(" ");
        Console.WriteLine("2. Full Details:");
        Console.WriteLine(outdoor.GetSumary());
        Console.WriteLine(outdoor.GetWeather());
        Console.WriteLine(" ");
        Console.WriteLine("3. Short Description:");
        Console.WriteLine(outdoor.GetShortDetails());
        Console.WriteLine(" ");
    }
}