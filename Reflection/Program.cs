using System;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla());
            //Console.WriteLine(dortIslem.Topla(3, 4));

            var tip = typeof(DortIslem);

            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip, 2, 3);
            //Console.WriteLine(dortIslem.Topla());
            //Console.WriteLine(dortIslem.Topla(3, 4));

            //var instance = Activator.CreateInstance(tip, 2, 3);
            //MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            //Console.WriteLine(methodInfo.Invoke(instance, null));

            var metodlar = tip.GetMethods();

            foreach (var info in metodlar)
            {
                Console.WriteLine("Metod adı: " + info.Name);

                foreach (var parameter in info.GetParameters())
                {
                    Console.WriteLine("\tParametre " + (parameter.Position + 1) + ": " + parameter.Name);
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("\tAttribute adı: " + attribute.GetType().Name);
                }
            }
        }
    }

    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem()
        {
        }

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MetodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }

    public class MetodNameAttribute : Attribute
    {
        public MetodNameAttribute(string name)
        {
        }
    }
}
