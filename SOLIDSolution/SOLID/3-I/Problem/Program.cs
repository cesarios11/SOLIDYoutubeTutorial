using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_I.Problem
{
    public class Program
    {
        public static void Main()
        {
            BurgerOrderService service = new BurgerOrderService();
            service.OrderBurger(2);
        }
    }
}
