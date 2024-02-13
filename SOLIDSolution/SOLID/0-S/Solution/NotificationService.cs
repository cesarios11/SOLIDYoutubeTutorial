using SOLID._0_S.Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._0_S.Solution
{
    public interface INotificationService
    {
        bool EmailInvoice(Invoice invoice);
    }
    public class NotificationService : INotificationService
    {
        public bool EmailInvoice(Invoice invoice)
        {
            return true;
        }
    }
}
