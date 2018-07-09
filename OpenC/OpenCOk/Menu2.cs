using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCOk
{
    class Menu2 : Menu1
    {
        public override double getOffer(double TotalPrice)
        {
            return base.getOffer(TotalPrice) - 5;
        }
    }
}
