using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_O.Solution
{
    public class ReportingService
    {
        private readonly IReportGenerator reportGenerator;
        public ReportingService(IReportGenerator _reportGenerator)
        {
            this.reportGenerator = _reportGenerator;
        }

        public void GenerateReport(List<Order> orders)
        {
            this.reportGenerator.CreateReport(orders);
        }

        public class Order
        {
            public string Name { get; set; }
        }
    }
}
