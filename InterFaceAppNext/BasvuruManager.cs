using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceAppNext
{
    class BasvuruManager
    {
        public void BasvuruYap (List<IKrediManager> krediManagers, List<ILoggerService> loggerServices)
        {
            foreach (var krediManager in krediManagers)
            {
                krediManager.HesapYap();
            }
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
    }
}
