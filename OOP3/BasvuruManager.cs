using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
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
