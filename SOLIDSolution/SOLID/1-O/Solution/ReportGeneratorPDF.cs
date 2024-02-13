using static SOLID._1_O.Solution.ReportingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_O.Solution
{
    public class ReportGeneratorPDF : IReportGenerator
    {
        public void CreateReport(List<Order> orders)
        {
            //Generate Report en PDF
        }
    }
}
