using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_D.Solution
{
    public class OrderService
    {
        private readonly IEventNotificationService eventNotificationService;

        public OrderService(IEventNotificationService _eventNotificationService)
        {
            this.eventNotificationService = _eventNotificationService;
        }

        public void GenerateOrder(Order order)
        {
            //Code to create order.

            //Send notification to datalog.
            this.eventNotificationService.LogEvent("The order was successfully created!");
        }
    }

    public class Order
    {
    }
}
