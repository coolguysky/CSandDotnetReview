using System;
using System.Collections.Generic;
using System.Text;

namespace CSOOPReview
{
    class ManualTransmission  : Car
    {
        //both constructors are called
        // can use :base(type value)
        public override void Run(int Speed)
        {
            base.Run(75);
            Console.WriteLine("Manual");

        }
    }
}
