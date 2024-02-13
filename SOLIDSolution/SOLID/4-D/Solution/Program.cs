using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_D.Solution
{
    public class Program
    {
        public static void Main()
        {
            Order order = new Order();
            OrderService service = new OrderService(new AnyOtherMonitoringService());
            service.GenerateOrder(order);
        }
    }
}
