using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLID._1_O.Solution.ReportingService;

namespace SOLID._1_O.Solution
{
    public class Program
    {
        public static void Main()
        {
            List<Order> orders = new List<Order>();
            ReportingService service = new ReportingService(new ReportGeneratorPDF());
            service.GenerateReport(orders);
        }
    }
}
