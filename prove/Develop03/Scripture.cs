using System;

public class Scripture
{
private string _scriptureReference;
private string _scriptureText;

public string GetScriptureReference()
{
    return _scriptureReference;
}
public void SetScriptureReference(string scriptureReference)
{
    _scriptureReference = scriptureReference;
}
public string GetScriptureText()
{
    return _scriptureText;
}
public void SetScriptureText(string scriptureText)
{
    _scriptureText = scriptureText;
}

public void Clear()
{
    string action = "";
    Console.Write("Press enter to start or type quit to exit: ");
    action = Console.ReadLine();



    while (action != "exit")
    {
        Console.Clear();

        string script = "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life.";
        string[] words = script.Split(",");
        foreach (var word in words)
        {
            //System.Console.WriteLine($"{word}");
        

        Console.WriteLine("John 3:16");
        System.Console.WriteLine($"{word}");
        string scriptReplace = script.Replace("o", "_");
        Console.WriteLine(scriptReplace);

        //Console.WriteLine("For ___ so loved the world, ____ he gave his ____ begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Console.WriteLine("Press enter to start or type quit to exit: ");
        action = Console.ReadLine();  
        }
            
    }
    Console.WriteLine("bye");
}

}
