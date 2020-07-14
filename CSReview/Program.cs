using System;
using System.Text;
using System.Threading;

namespace CSReview
{
    class Program
    {
        static void Main(string[] args)
        {







            //Console.WriteLine("Enter the length of integer array.");
            //int length = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[length];
            //Console.WriteLine($"Enter the {length} values.");

            //for (int i = 0; i < length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach (var item in arr)
            //{

            //    Console.WriteLine(item.ToString());
            //}
            //Console.WriteLine($"array: { string.Join(",", arr)} ");
            

            //int[] sortedArray = new int[length];
            //Array.Copy(arr, sortedArray, arr.Length);
            //Array.Sort(sortedArray);
            //Console.WriteLine($"array with Array.sort : { string.Join(",", sortedArray)} ");

            //for (int i = 0; i < length; i++)
            //{
            //    for (int j = i + 1; j < length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            int temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }

            //    }
            //}
            //Console.WriteLine($"array with forxfor: { string.Join(",", arr)} ");
            

            /////////////////////////////////////////////////////////////

            //iteration - do/for/while loop i'm good
            // can put break or continue in for loop

            //bool nope = false;
            //Start:
            //do
            //{
            //  Console.WriteLine("hey");
            //} while (nope);

            //Console.WriteLine("Yes or no");


            //if (Console.ReadLine() == "yes")
            //{
            //  goto Start; //jump
            //}


            //foreach (var item in collection)
            //{
            //    
            //    
            //}

            /////////////////////////////////////////////////////////////

            //selection statements // i'm good
            //switch

            //string name = "Gregg";

            //switch (name)
            //{
            //    case "Greg":
            //        Console.WriteLine("Not name");
            //        break;
            //    case "Gregg":
            //        Console.WriteLine("is name");
            //        break;
            //    default:
            //        Console.WriteLine("what...");
            //        break;
            //}

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

            //public struct Customer
            //{
            //    public int Age;
            //    public string Name;
            //    public bool IsEmployee;
            //}

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
