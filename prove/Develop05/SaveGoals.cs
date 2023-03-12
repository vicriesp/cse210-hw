//using System.IO;

//using System.Text;

public class SaveGoals
{
    public void GetSaveFile()
    {
    Console.WriteLine("What is the filename for the goal file? ");
    string fileName = Console.ReadLine();

    //using (FileStream fs = File.Create(fileName));
    
    string path = @"/Users/victorrivera/Desktop/BYU Idaho/CSE-210/cse210-hw/prove/Develop05\goals.txt";
    File.Create(path);
        
    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
        // ListGoals lg = new ListGoals();
        // string data = lg.displayGoals();
        // outputFile.WriteLine(data);
    }
    }
}