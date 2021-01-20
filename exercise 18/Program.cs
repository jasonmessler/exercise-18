using System;

namespace exercise_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string yesOrNo;


            do
            {
                int answer = 0;
                Console.Write("Please enter a number  ");  //resets answer to 0, takes and parses user input
                var userInput = Console.ReadLine();
                var input = double.Parse(userInput);

                for (i = 0; i <= input; i++) // nested loop
                {
                    answer = answer + i;
                    Console.WriteLine(answer);
                       
                }
                Console.WriteLine();  // continue option and return to do/while loop
                Console.Write("Would you like to continue (y/n)?  ");  
                yesOrNo = Console.ReadLine();


            } while (yesOrNo == "y");

            Console.WriteLine("Goodbye");    
            Console.ReadLine();

        }
    }
}
