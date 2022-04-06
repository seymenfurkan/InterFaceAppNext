using InterFaceAppNext.LoggerService;
using System;
using System.Collections.Generic;

namespace InterFaceAppNext
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager esnafKrediManger = new EsnafKrediManager();
            IKrediManager ciftciKrediManager = new CiftciKrediManager();

            ILoggerService mailLoggerService = new MailLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            List<IKrediManager> krediList = new List<IKrediManager> {tasitKrediManager};
            List<ILoggerService> loggerList = new List<ILoggerService>() {mailLoggerService, smsLoggerService,databaseLoggerService };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(krediList,loggerList);
        }
    }
}
