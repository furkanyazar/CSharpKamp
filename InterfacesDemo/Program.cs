using System;

namespace InterfacesDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var item in workers)
            {
                item.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var item in eats)
            {
                item.Eat();
            }
        }
    }

    internal interface IWorker
    {
        void Work();
    }

    internal interface IEat
    {
        void Eat();
    }

    internal interface ISalary
    {
        void GetSalary();
    }

    internal class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    internal class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    internal class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}