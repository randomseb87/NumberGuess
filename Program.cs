using System;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                 Console.Write("Please pick a number: ");
            
                 int number = int.Parse(Console.ReadLine());

                   const int correctNumber = 42;
            
                 if (correctNumber == number)
                  {
                      Console.WriteLine("Congratulations, your number is correct.");
                           break;
                  }
                 else if (correctNumber > number)
                  {
                      Console.WriteLine("I'm sorry, your number is to low.");
                  }
                  else if (correctNumber < number)
                  {
                      Console.WriteLine("I'm sorry, your number is to high.");
                  }

            }
            Console.ReadLine();
        }
    }
}
