using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle: Vehicle
    {
        private bool HasSideCart;
        public Motorcycle()
        {
            HasSideCart = true;
        }
        public override void DriveVirtual()
        {
            // base.DriveVirtual();
            Console.WriteLine("Drive virtual from motorcycle");
        }
        void setHasSideCart(bool c)
        {
            HasSideCart = c;
        }
        bool getHasSideCart()
        {
            return HasSideCart;
        }
    }
}
