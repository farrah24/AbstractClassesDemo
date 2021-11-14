using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car: Vehicle
    {
        private bool HasTrunk;
        public Car()
        {
            HasTrunk = true;
        }
        public override void DriveVirtual()
        {
            base.DriveVirtual();
            //Console.WriteLine("Drive virtual from car");
        }
        void setHasTrunk(bool b)
        {
            HasTrunk = b;
        }
        bool getHasTrunk()
        {
            return HasTrunk;
        }
    }
}
