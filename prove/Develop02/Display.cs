using System;

using System.Collections.Generic;

//System.DateTime;


public class Display
{
    

    public void addToList(string entry)
    {
            //string[] list;
            //list.add(entry);

            //DateTime theCurrentTime = DateTime.Now;
            //string dateText = theCurrentTime.ToShortDateString();

            //DateTime dateTime = DateTime.Now;
            Console.WriteLine("entry function");

            
        
    }

     public void display(string[] list)
     {
        for (int i=0; i<list.Length; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}
