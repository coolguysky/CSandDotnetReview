using System;
using System.Security.Cryptography;

namespace DebugExceptionReview
{
    class Program
    {
        static void Main(string[] args)
        {
            // int number1;
            // number1 = 10;

            // string name = "Gregg Reed";

            // PrintMessage("This is the debugging demp app");

            //Console.ReadLine();

            //Exception Handling

            

            try
            {
                int number = 10;
                int result = number / 1; //0 for second catch

                int[] numbers = new int[3] { 4, 8, 10 };
                Console.WriteLine(numbers[3]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Index out of boundary");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch  (DivideByZeroException )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You can't devide by zero.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"An exception occured in app: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
                //Windows Events, log to files
            }
            finally //cleanup
            {
                Console.WriteLine("this is finally");
            }
            Console.WriteLine("hello world");
        }

        static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
