using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLID._1_O.Solution.ReportingService;

namespace SOLID._1_O.Solution
{
    public interface IReportGenerator
    {
        void CreateReport(List<Order> orders);
    }
}
