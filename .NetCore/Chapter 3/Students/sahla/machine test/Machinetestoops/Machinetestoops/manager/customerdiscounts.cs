using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machinetestoops.Interface;

namespace Machinetestoops.manager
{
    public class CustomerDiscounts
    {
        public class RegularCustDiscount:Machinetestoops.Interface.IDiscounts
        {
            public decimal ApplyDiscount(decimal amount) => amount * 0.95m;
        }
        public class PremiumCustDiscount:Machinetestoops.Interface.IDiscounts
        {
            public decimal ApplyDiscount(decimal amount) => amount * 0.90m;
        }
        public class FirstTimeCustDiscount:Machinetestoops.Interface.IDiscounts
        {
            public decimal ApplyDiscount(decimal amount) => amount * 0.85m;
        }
    }
}
