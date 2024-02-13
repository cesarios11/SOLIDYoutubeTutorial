using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_D.Solution
{
    public class AnyOtherMonitoringService : IEventNotificationService
    {
        public void LogEvent(string message)
        {
            //Code to log event on this monitoring service app.
        }
    }
}
