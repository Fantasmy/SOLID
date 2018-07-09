using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenC
{
    class Program
    {
        public class Menu
        {
            public int MenuType { get; set; }

            public double getOffer(double TotalPrice)
            {
                if (MenuType == 1)
                {
                    return TotalPrice - 3;
                }
                else
                {
                    return TotalPrice - 5;
                }
            }
        }
    }
}

