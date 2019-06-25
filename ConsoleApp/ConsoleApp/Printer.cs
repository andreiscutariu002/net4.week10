using System;

namespace ConsoleApp
{
    public class Printer
    {
        public void Print(Student s)
        {
            Console.WriteLine(s);
        }

        public void Print(Worker w)
        {
            Console.WriteLine(w);
        }
    }
}
