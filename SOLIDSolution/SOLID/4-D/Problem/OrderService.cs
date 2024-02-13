using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_D.Problem
{
    public class Order
    {
    }

    public class DataDogService
    {
        public void LogEvent(string message)
        {

        }
    }
    public class OrderService
    {
        private readonly DataDogService dataDogService;
        public OrderService(DataDogService _dataDogService)
        {
            this.dataDogService = _dataDogService;
        }

        public void GenerateOrder(Order order)
        {
            //Codigo para generar la orden

            //Se notifica a datadog para generar el evento. 
            this.dataDogService.LogEvent("The order was successsfully created");
        }
    }
}
