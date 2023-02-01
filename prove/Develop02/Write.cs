using System;

public class Write
{
    public list<question> _question = new List<question>();

    public string _userEntry = " ";

    public void Display()
    {
        Console.WriteLine($"{_question}, {_userEntry}");
    }
}