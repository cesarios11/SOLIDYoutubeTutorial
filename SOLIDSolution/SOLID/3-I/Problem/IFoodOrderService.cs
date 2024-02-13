using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_I.Problem
{
    public interface IFoodOrderService
    {
        void OrderBurger(int quantity);
        void OrderSteak(int quantity);
        void OrderSalad(int quantity);
    }
}
