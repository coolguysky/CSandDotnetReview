using System;

namespace CSOOPReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car myCar = new Car(2001); // wont work with abstract class
            //myCar.Make = "Honda";

            //myCar.Run(65);
            //Console.WriteLine($"My car is - {myCar.Year} {myCar.Make}.");

            //Inheritance
            ManualTransmission manCar = new ManualTransmission(2002);
            manCar.Make = "Honda";

            manCar.Run(65); //overridden 
            Console.WriteLine($"My car make is - {manCar.Year} {manCar.Make}.");

            //abstraction 
            //Car car;
            //car.ChangeGear();
            ManualTransmission manCarTwo = new ManualTransmission(2003);
            manCarTwo.Make = "Honda";

            manCarTwo.Run(65); //overridden 
            manCarTwo.ChangeGear();
            Console.WriteLine($"My car make is - {manCarTwo.Year} {manCarTwo.Make}.");

            //Polymorphism

            Car car; //both car and manula constructors will be called
            Console.WriteLine("1 or 2");
            
            bool check = true;
            while (check)
            {
                int enteredValue = Convert.ToInt32(Console.ReadLine());
                if (enteredValue == 1)
                {
                    car = new ManualTransmission();
                    check = false;
                }
                else
                {
                    Console.WriteLine("just enter 1");
                }
            }
            


        }
    }
}
