using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._0_S.Solution
{
    public interface ILoggerService
    {
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);
    }
    public class LoggerService : ILoggerService
    {
        public LoggerService()
        {
                
        }
        public void Debug(string info)
        {
            
        }

        public void Error(string message, Exception ex)
        {
            
        }

        public void Info(string info)
        {
            
        }
    }
}
