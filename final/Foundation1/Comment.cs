using System;

public class Comment
{
    public string _name;
    public string _text;

    public List<Video> _videos = new List<Video>();

    public void Display()
    {
        //Console.WriteLine($"Name: {_name}");
        //Console.WriteLine($"Comments: {_text}");

        foreach (Video video in _videos)
        {
            //Console.Clear();
            //Console.WriteLine($"Name: {_name1}");
            video.Display();
        }
    }
}