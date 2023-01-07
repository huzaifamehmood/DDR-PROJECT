using System;
using System.Collections.Generic;
using System.Text;

namespace DDR_Project.Implementation.Order
{
    public interface IOrderAggregate
    {
        void DiscountByAmount(double amount);
        double GetTotalDiscounts();
        double GetOrderTotal();
    }
}
