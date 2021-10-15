﻿using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //GetAll();
            //GetProductsByCategory(1);
        }

        private static void GetAll()
        {
            NorthwindContext context = new NorthwindContext();

            foreach (var product in context.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext context = new NorthwindContext();

            var result = context.Products.Where(p => p.CategoryId == categoryId);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}