using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCOk
{
    public class Menu
    {
        public virtual double getOffer(double TotalPrice)
        {
            return TotalPrice;
        }
    }

    class Menu1 : Menu
    {
        public override double getOffer(double TotalPrice)
        {
            return base.getOffer(TotalPrice) - 3;
        }
    }
}
