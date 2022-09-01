using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal interface ICar
    {
        int GetPrice(string name);
    }

    class Hyundai : ICar
    {
        public int Getprice(string name)
        {
            if (name == "Creta")
                return 1800000;
            else if (name == "Venue")
                return 1200000;
            else
                return 100000;
        }

        public int GetPrice(string name)
        {
            throw new NotImplementedException();
        }
    }
}
