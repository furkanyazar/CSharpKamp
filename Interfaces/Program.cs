using System;

namespace Interfaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // INTRO
            //PersonManager personManager = new PersonManager();
            //personManager.Add(new Customer { Id = 1, FirstName = "Doğukan", LastName = "Yazar", Address = "Zoğopa" });
            //personManager.Add(new Student { Id = 2, FirstName = "Furkan", LastName = "Yazar", Department = "Yazılım" });

            // DEMO
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new OracleCustomerDal());

            // DEMO 2
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var item in customerDals)
            {
                item.Add();
            }
        }
    }

    internal interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    internal class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    internal class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    internal class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
