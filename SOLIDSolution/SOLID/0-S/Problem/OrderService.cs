using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._0_S.Problem
{
	internal class OrderService
	{
		public void SaveOrder(Order order)
		{
			try
			{
				this.InsertOrder(order);
				var invoice = this.CreateInvoice(order);
				this.Equals(invoice);
				File.WriteAllText(@"c:\InfoLog.txt", "The order has been complete");
			}
			catch (Exception ex)
			{
                File.WriteAllText(@"c:\ErrorLog.txt", ex.Message);
            }
		}

		public bool InsertOrder(Order order)
		{
			return true;
		}

		public Invoice CreateInvoice(Order order)
		{
			return new Invoice();

        }
			
    }

	public class Order
	{
	}

	public class Invoice
	{
	}
}
