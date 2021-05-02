using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {


            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLogerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
            List<ILoggerService> loggerServices = new List<ILoggerService>() { databaseLogerService, fileLogerService };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, loggerServices);

            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
