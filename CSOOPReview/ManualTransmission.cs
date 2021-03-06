﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSOOPReview
{
    class ManualTransmission  : Car, IConvertibleCar
    {

        public ManualTransmission()
        {
            Console.WriteLine("Manual car constructor");
        }

        public ManualTransmission(int year): base (year)
        {
            //this will call the parent param constructor
        }

        public override void ChangeGear() //implement abstract class
        {
            Console.WriteLine("Manual gear change");
        }

        public bool changeRoofTop()
        {
            Console.WriteLine("No roof");
            return true;
        }

        //both constructors are called
        // can use :base(type value)
        public override void Run(int Speed)
        {
            base.Run(75);
            Console.WriteLine("Manual");

        }
    }
}
