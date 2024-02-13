using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._0_S.Solution
{
    public interface IOrderRepository
    {
        public bool InsertOrder(Order order);
    }

    public class OrderRepository : IOrderRepository
    {
        public bool InsertOrder(Order order)
        {
            return true;
        }
    }
}
