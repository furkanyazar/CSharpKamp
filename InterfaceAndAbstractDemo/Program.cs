using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Adapters;
using InterfaceAndAbstractDemo.Concrete;
using InterfaceAndAbstractDemo.Entities;
using System;

namespace InterfaceAndAbstractDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1990, 1, 1), FirstName = "Furkan", LastName = "Yazar", NationalityId = "12345678910" });
            Console.ReadLine();
        }
    }
}
