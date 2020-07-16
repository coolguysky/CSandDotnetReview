using System;
using System.Collections.Generic;
using System.Text;

namespace CSOOPReview
{
    class Car
    {
        public Car()
        {

        }
        private string _make;
        //encapsulation 
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }

        public virtual void Run(int speed)
        {
            Console.WriteLine($"Car is running at speed {speed} ");
        }

        //propfull 

        private int _year;

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

       



    }
}
