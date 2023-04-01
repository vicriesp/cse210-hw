public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public string _comment1;
    public string _comment2;
    public string _comment3;
    public string _name;

    public void Display()
    {
        Console.WriteLine(" ");
        Console.WriteLine($"Title: {_title} \nAuthor: {_author} \nLength: {_length}sec");
        Console.WriteLine($"Commentor Name: {_name}");
        Console.WriteLine($"Comments: \n1.{_comment1} \n2.{_comment2} \n3.{_comment3}");
        Console.WriteLine(" ");
    }
}