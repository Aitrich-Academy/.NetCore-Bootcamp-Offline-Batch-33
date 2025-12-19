using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machinetestoops.Interface;

namespace Machinetestoops.manager;

public class Order
{
    private IDiscounts _discounts;
    public Order(IDiscounts discounts)
    {
        _discounts = discounts;
    }
    public decimal CalculateTotal(decimal amount)
    {
        return _discounts.ApplyDiscount(amount);
    }

}
