using System;
using System.Collections.Generic;
using System.Text;

namespace CSOOPReview
{
    public abstract class Car
    {
        public Car()
        {
            Console.WriteLine("This is the constructor");
        }

        public Car(int year)
        {
            Console.WriteLine("This is the param constructor");
            _year = year;
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

        public abstract void ChangeGear();
        //abstract means no objects of class

       



    }
}
