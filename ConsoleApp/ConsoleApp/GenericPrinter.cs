using System;

namespace ConsoleApp
{
    public interface IPrintable
    {
        void Print();
    }

    // generic type in class
    public class GenericPrinter<T> where T: class, IPrintable, new()
    {
        public void Print(T s)
        {
            s.Print();
        }

        public T NullState()
        {
            return null;
        }

        public T DefaultState()
        {
            return new T();
        }
    }

    // generic type in method
    public class GenericPrinter2
    {
        public void Print<T>(T s) where T: new()
        {
            Console.WriteLine(s);
        }
    }
}
