using System;

namespace GenericComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student("s1", 10);
            var s2 = new Student("s2", 14);
            var s3 = new Student("s3", 12);

            var w1 = new Worker("w1", 123);
            var w2 = new Worker("w2", 12);
            var w3 = new Worker("w3", 1234);

            var genericComparer = new GenericComparer<Worker>();
            var min = genericComparer.GetMin(w1, w2, w3);

            var genericComparerForStudents = new GenericComparer<Student>();
            var minStudent = genericComparerForStudents.GetMin(s1, s2, s3);
        }
    }

    public class GenericComparer<T> where T : IComparable 
    {
        public T GetMin(T a1, T a2, T a3)
        {
            if(a1.CompareTo(a2) < 0)
            {
                if(a1.CompareTo(a3) < 0)
                {
                    return a1;
                }
                else
                {
                    return a3;
                }
            }
            else
            {
                if(a2.CompareTo(a3) < 0)
                {
                    return a2;
                }
                {
                    return a3;
                }
            }
        }
    }
}
