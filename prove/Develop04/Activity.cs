
public class Activity
{
    private string _startingMessage;
    private string _welcomeMessage;
    //private string _timeForSession;
    //private string _getReady;
    // private string _endingMessage;
    

    public Activity(
    string startingMessage,
    string welcomeMessage
    )
    {
        _startingMessage = startingMessage;
        _welcomeMessage = welcomeMessage;
        //_timeForSession = timeForSession;
        //_getReady = getReady;
        // _endingMessage = endingMessage;
        
    }
    public string GetStartingMessage()
    {
        return _startingMessage;
    }
    public string GetWelcomeMessage()
    {
        return _welcomeMessage;
    }
    //public string GetGetReady()
    //{
        //return _getReady;
    //}
    //public void GetTimeForSession()
    //{
        //Console.WriteLine("How long, inseconds, would you like for your session? ");
        //var seconds = Convert.ToInt32(Console.ReadLine());
        
        // Console.Clear();
        // Console.WriteLine(" ");
        // Console.WriteLine("Get ready!");

        // Console.Write(".");
        // Thread.Sleep(1000);
        // Console.Write("\b \b");

        // Console.Write(" .");
        // Thread.Sleep(1000);
        // Console.Write("\b \b");

        // Console.Write("  .");
        // Thread.Sleep(1000);
        // Console.Write("\b \b");

        // Console.Write(".");
        // Thread.Sleep(1000);
        // Console.Write("\b \b");

        // Console.Write(" .");
        // Thread.Sleep(1000);
        // Console.Write("\b \b");

        // Console.Write("  .");
        // Thread.Sleep(1000);
        // Console.Write("\b \b");

        // Console.Clear();

        // for(var i = seconds - 1; i <= seconds; i--)
        // {
        //    Thread.Sleep(1000);
        //    Console.Write("\rSeconds: " + i);
        //    if(i == 1)
        //    {
        //    Console.Write("\rTime has finished.");
        //    Console.ReadLine();
        //    Environment.Exit(0);
        //    }
        //}    
    //}
    // public void GetSpinerAnimation()
    // {
    //     Console.Write(".");
    //     Thread.Sleep(500);

    //     Console.Write("\b \b");
    //     Console.Write(" .");
        
    //     Thread.Sleep(500);
    //     Console.Write("\b \b");
    //     Console.Write("  .");
    // }
}