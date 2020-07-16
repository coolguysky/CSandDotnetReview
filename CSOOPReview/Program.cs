using System;

namespace CSOOPReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Honda";

            myCar.Run(65);
            Console.WriteLine($"My car make is - {myCar.Make}.");

            //Inheritance
            ManualTransmission manCar = new ManualTransmission();
            manCar.Make = "Honda";

            manCar.Run(65);
            Console.WriteLine($"My car make is - {manCar.Make}.");

        }
    }
}
