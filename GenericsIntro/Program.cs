﻿using System;

namespace GenericsIntro
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();

            isimler.Add("Engin");
            Console.WriteLine(isimler.Length);

            isimler.Add("Kerem");
            Console.WriteLine(isimler.Length);

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
