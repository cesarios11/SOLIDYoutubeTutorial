using SOLID._0_S.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._0_S.Solution
{
    public interface IInvoiceService
    {
        Invoice CreateInvoice(Order order);
    }
    public class InvoiceService : IInvoiceService
    {
        public Invoice CreateInvoice(Order order)
        {
            return new Invoice();
        }
    }
}
