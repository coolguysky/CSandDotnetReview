using System;
using System.Text;

namespace CSReview
{
    public struct Customer
    {
        public int Age;
        public string Name;
        public bool IsEmployee;
    }
    class Program
    {
        static void Main(string[] args)
        {



            /////////////////////////////////////////////////////////////

            //char charA = 'a';
            //char bigA = char.ToUpper(charA);
            //char smallA = char.ToLower(bigA);

            //escape
            //  '\n' -- new line
            //  '\t' -- new tab

            //string empty = string.Empty; //length of zero
            //empty.Length; if null, will retrn null reference error

            //string sentence = "Gregg";
            //bool result = sentence.Contains("Gregg"); // result will be true

            //string sentence = "Gregg";
            //bool result = sentence.EndsWith("G"); // result will be true

            //string sentence = "Gregg";
            //int result = sentence.IndexOf("Gregg"); // result will be 0 , -1 if not there

            //string sentence = "Gregg";
            //int result = sentence.LastIndexOf("Gregg"); // result will be 0 , -1 if not there

            //string sentence = "Gregg";
            //string result = sentence.Substring(0, 4); // result will be Greg

            //string sentence = "Gregg";
            //string result = sentence.Insert(0, "Mr. "); // result will be Mr. Gregg

            //string sentence = "Gregg";
            //string result = sentence.Remove(0, 3); // result will be gg

            //string sentence = "Gregg";
            //string result = sentence.Replace("gg", "at"); // result will be Great

            //string sentence = "Gregg";
            //string sentenceAdd = sentence + sentence; // result will be new GreggGregg a lot of mem

            //string sentence = "Gregg";
            //StringBuilder sb = new StringBuilder();
            //sb.Append(sentence);
            //sb.Append(sentence); // result will be new GreggGregg

            //Console.WriteLine("What is your age?");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(string.Format("You are {0} years old", age));

            //decimal price = 2.5m;
            //Console.WriteLine(string.Format("Currency format: {0:C2}", price));

            //DateTime todaysDate = DateTime.Now;
            //Console.WriteLine(string.Format("Today's date {0:d} at {0:t}", todaysDate));

            //interpolation 
            //Console.WriteLine("What is your age?");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(string.Format($"You are {age} years old"));

            //decimal price = 2.5m;
            //Console.WriteLine($"Currency format: {price:C2}"); //sometimes works without?

            //DateTime todaysDate = DateTime.Now;
            //Console.WriteLine(string.Format($"Today's date {todaysDate:d} at {todaysDate:t}"));

            ////Console.WriteLine();
            ///

            /////////////////////////////////////////////////////////////////

            //Console.WriteLine("Hello world!");
            //string name = Console.ReadLine();
            //Console.WriteLine(name);

            //int age = 28;
            //string employeeName = "Gregg Reed";
            //bool isEmployee = true;
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine(employeeName + " is " + age + " old.");
            //Console.WriteLine("Is he an employee? " + (isEmployee ? "yes" : "no"));

            //Customer cust;
            //cust.Age = 28;
            //cust.Name = "Gregg Reed";
            //cust.IsEmployee = true;

            //////////////////////////////////////////

            //int firstOperand = 15;
            //int secondOperand = 3;
            //int dumbReview = firstOperand + secondOperand;

            ///////////////////////////////////////////


        }
    }
}
