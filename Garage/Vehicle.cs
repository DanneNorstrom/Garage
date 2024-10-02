using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Vehicle
    {
        private int price = 0;

        public void Setprice(int p) { price = p; }
        public int GetPrice() { return price; }
    }
}

