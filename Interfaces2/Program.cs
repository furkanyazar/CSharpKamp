using System;

namespace Interfaces2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());
        }

        private interface IPersonManager
        {
            void Add();

            void Update();
        }

        private class CustomerManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Müşteri eklendi");
            }

            public void Update()
            {
                Console.WriteLine("Müşteri güncellendi");
            }
        }

        private class InternManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Stajyer eklendi");
            }

            public void Update()
            {
                Console.WriteLine("Stajyer güncellendi");
            }
        }

        private class EmployeeManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Personel eklendi");
            }

            public void Update()
            {
                Console.WriteLine("Personel güncellendi");
            }
        }

        private class ProjectManager
        {
            public void Add(IPersonManager personManager)
            {
                personManager.Add();
            }

            public void Update(IPersonManager personManager)
            {
                personManager.Update();
            }
        }
    }
}