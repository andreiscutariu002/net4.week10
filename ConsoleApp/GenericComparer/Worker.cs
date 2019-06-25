using System;

namespace GenericComparer
{
    public class Worker : IComparable
    {
        public Worker(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; }

        public int Salary { get; set; }

        public int CompareTo(object obj)
        {
            if(obj == null)
            {
                throw new NullReferenceException();
            }

            var worker = obj as Worker;

            if (worker == null)
            {
                throw new InvalidCastException();
            }

            if(this.Salary < worker.Salary)
            {
                return -1;
            }

            if (this.Salary == worker.Salary)
            {
                return 0;
            }

            return 1;
        }
    }
}
