using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
     public abstract class Vehicle
    {
        private string Year;
        private string Make;
        private string Model;
        public Vehicle()
        {
            Year = "2008";
            Make = "hyundai";
            Model = "Accent";
        }
        public virtual void DriveVirtual()
        {
            Console.WriteLine("drive virtual from vehicle class");

        }
    }
}
