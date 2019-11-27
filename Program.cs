using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }


        static void ThrowsException<ExceptionType>(Action action) where ExceptionType : Exception
        {
            bool threwException = false;

            try
            {
                action();
            }
            catch (ExceptionType)
            {
                threwException = true;
            }

            if (threwException)
            {
                Console.WriteLine("Threw exception");
            }
            else
            {
                Console.WriteLine("No exception thrown.");
            }
        }

    }
}
