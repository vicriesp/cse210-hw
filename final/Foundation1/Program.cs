using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Video video1 = new Video();
        video1._name = "Hector H.";
        video1._title = "Happy Feet";
        video1._author = "Jose Luis";
        video1._length = 20;
        video1._comment1 = "Excellent Video";
        video1._comment2 = "Expectacular Performance";
        video1._comment3 = "Awesome Sound Track";


        Video video2 = new Video();
        video2._name = "Victor R.";
        video2._title = "Naco Libre";
        video2._author = "Hector H.";
        video2._length = 30;
        video2._comment1 = "I love it!!!";
        video2._comment2 = "So Funny";
        video2._comment3 = "Outstanding Jack Black Performance";

        
        Video video3 = new Video();
        video3._name = "Hugo P.";
        video3._title = "Spray";
        video3._author = "Jacon M.";
        video3._length = 10;
        video3._comment1 = "Good Musical";
        video3._comment2 = "Also Funny";
        video3._comment3 = "I Felt like Dancing too";

        
        Video video4 = new Video();
        video4._name = "Alex S.";
        video4._title = "The Martian";
        video4._author = "Cameron D.";
        video4._length = 25;
        video4._comment1 = "Love the Trama";
        video4._comment2 = "I want Potatos with catsup";
        video4._comment3 = "So sad they left him";

        Comment theComments = new Comment();

        theComments._videos.Add(video1);
        theComments._videos.Add(video2);
        theComments._videos.Add(video3);
        theComments._videos.Add(video4);

        theComments.Display();

    }
}