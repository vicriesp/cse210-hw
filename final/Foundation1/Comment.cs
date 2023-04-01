using System;

public class Comment
{
    public string _name;
    public string _text;

    public List<Video> _videos = new List<Video>();

    public void Display()
    {
        foreach (Video video in _videos)
        {
            video.Display();
        }
    }
}