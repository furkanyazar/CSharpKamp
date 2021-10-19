using System.Collections.Generic;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            krediManager.Hesapla();

            foreach (var item in loggerServices)
            {
                item.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediManagers)
        {
            foreach (var item in krediManagers)
            {
                item.Hesapla();
            }
        }
    }
}
