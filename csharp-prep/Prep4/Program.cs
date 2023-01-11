using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber !=0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished ");

            string userNumbers = Console.ReadLine();
            userNumber = int.Parse(userNumbers);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            int max = numbers[0];

            foreach (int number in  numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The max is: {max}");
        }

        


    }
}