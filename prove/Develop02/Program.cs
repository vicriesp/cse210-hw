using System;

partial class Program
{   
    static void Main(string[] args)
    {
        String[] list;
        Display display = new Display();
        Menu menu = new Menu();
        menu.numero1 = "1. Write";
        menu.numero2 = "2. Display";
        menu.numero3 = "3. Quit";

        Console.WriteLine("{0}\n{1}\n{2}", 
        menu.numero1, 
        menu.numero2, 
        menu.numero3);

        string answer = "";
        while (answer != "3")
        {
            Console.Write("Choose a number: ");
            answer = Console.ReadLine();

            
            if (answer == "1")
            {
                string entry="";
                Console.WriteLine("Write");
                Write write = new Write();
                entry = write.displayQuestions();
                list.Add(entry);
            }
            else if (answer == "2")
            {
                
                Console.WriteLine("C");
                
                display.displayList(list);
            }
            else
            {
                Console.WriteLine("Enter a valid answer");
            }

        }



        

    
        
        
    }
}    