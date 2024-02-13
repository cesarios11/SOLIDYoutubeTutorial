using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_O.Problem
{
    public class ReportingService
    {
        public void GenerateReportType(List<Order> orders, ReportType type)
        {
            if (type == ReportType.PDF)
            {
                CreatePDFReport(orders);
            }
            else if (type == ReportType.EXCEL)
            {
                CreateEXCELReport(orders);
            }
            else
            {
            }
        }

        public void CreatePDFReport(List<Order> orders)
        {
        }

        public void CreateEXCELReport(List<Order> orders)
        {
        }

        public class Order
        {
            public string Name { get; set; }
        }
    }
}
