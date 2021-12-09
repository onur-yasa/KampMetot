using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            //ıhtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediBaseManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            
            IKrediBaseManager tasitKrediManager = new TasitKrediManager();   ///------>  Yazım Tekniği
         
            IKrediBaseManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseloggerService = new DatabaseLoggerService(); //--------->Yazım Tekniği -> basvuruManager.BasvuruYap(ıhtiyacKrediManager,new DatabaseLoggerService());
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ıhtiyacKrediManager,databaseloggerService );

            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() {ıhtiyacKrediManager,tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
          
        }
    }
}
