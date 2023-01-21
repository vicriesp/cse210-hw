using System;

public class Save
{
    public string _inputFileName;
    public List<Write> _userEntry = new List<Write>();

    public avoid Display()
    {
        Console.WriteLine($"{_userEntry}");
    }
}