using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Scripture scripture = new Scripture();
        scripture.SetScriptureReference("John 3:16");
        scripture.SetScriptureText("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        Console.WriteLine(scripture.GetScriptureReference());
        Console.WriteLine(scripture.GetScriptureText());

        scripture.Clear();
        
    }
}