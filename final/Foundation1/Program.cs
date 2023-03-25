using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Video video1 = new Video();
        video1._name = "Hector";
        video1._title = "Happines";
        video1._author = "Jose Luis";
        video1._length = 20;
        video1._comment1 = "Excellent";
        video1._comment2 = "Expectacular";
        video1._comment3 = "Awesome";


        Video video2 = new Video();
        video2._name = "Victor";
        video2._title = "Sadness";
        video2._author = "El tuerto";
        video2._length = 30;
        video2._comment1 = "Excellent";
        video2._comment2 = "Expectacular";
        video2._comment3 = "Awesome";

        
        Video video3 = new Video();
        video3._name = "Hugo";
        video3._title = "Singing";
        video3._author = "Pedro Infante";
        video3._length = 10;
        video3._comment1 = "Excellent";
        video3._comment2 = "Expectacular";
        video3._comment3 = "Awesome";

        
        Video video4 = new Video();
        video4._name = "Alex";
        video4._title = "Action";
        video4._author = "Rocky";
        video4._length = 25;
        video4._comment1 = "Excellent";
        video4._comment2 = "Expectacular";
        video4._comment3 = "Awesome";

        Comment theComments = new Comment();
        //theComments._name = "Jasson";
        
        //theComments._text = "Good video";

        theComments._videos.Add(video1);
        theComments._videos.Add(video2);
        theComments._videos.Add(video3);
        theComments._videos.Add(video4);

        theComments.Display();

    }
}