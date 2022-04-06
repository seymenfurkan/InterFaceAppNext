using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceAppNext.LoggerService
{
    class MailLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Mail Gönderildi");
        }
    }
}
