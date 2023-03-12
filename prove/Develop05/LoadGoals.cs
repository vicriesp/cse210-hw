//using System.IO;
public class LoadGoals
{
    public void readFile()
    {
        Console.WriteLine("Name of you file? ");
        string fileName = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            
            Console.WriteLine(line);
            Console.ReadLine();

        }
    }
}