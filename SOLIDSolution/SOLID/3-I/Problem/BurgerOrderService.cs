using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_I.Problem
{
    internal class BurgerOrderService : IFoodOrderService
    {
        public void OrderBurger(int quantity)
        {
            
        }

        public void OrderSalad(int quantity)
        {
            throw new NotImplementedException("Can't order salad from this service");
        }

        public void OrderSteak(int quantity)
        {
            throw new NotImplementedException("Can't order steak from this service");
        }
    }
}
