using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_I.Solution
{
    public class Program
    {
        public static void Main()
        {
            BurguerOrderService service = new BurguerOrderService();
            service.OrderBurguer(2);
        }
    }
}
