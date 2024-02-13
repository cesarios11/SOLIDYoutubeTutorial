using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._0_S.Solution
{
    public class OrderService
    {
        private readonly IOrderRepository orderRepository;
        private readonly INotificationService notificationService;
        private readonly IInvoiceService invoiceService;
        private readonly ILoggerService loggerService;
        public OrderService(IOrderRepository _orderRepository, INotificationService _notificationService, IInvoiceService _invoiceService, ILoggerService _loggerService)
        {
            this.orderRepository = _orderRepository;
            this.notificationService = _notificationService;
            this.invoiceService = _invoiceService;
            this.loggerService = _loggerService;
        }

        public void SaveOrder(Order order)
        {
            try
            {
                this.orderRepository.InsertOrder(order);
                var invoice = this.invoiceService.CreateInvoice(order);
                this.notificationService.EmailInvoice(invoice);
                this.loggerService.Info("The order has been complete");
            }
            catch (Exception ex)
            {
                this.loggerService.Error(ex.Message, ex);
            }
        }
    }
}
