using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLID._1_O.Problem.ReportingService;

namespace SOLID._1_O.Problem
{
    public class Program
    {
        public static void Main()
        {
            List<Order> orders = new List<Order>();
            ReportingService service = new ReportingService();
            service.GenerateReportType(orders, ReportType.PDF);            
        }
    }

    public enum ReportType
    {
        PDF,
        EXCEL
    }
}
