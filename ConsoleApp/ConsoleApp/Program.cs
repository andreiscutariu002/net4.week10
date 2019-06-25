using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student { Name = "And" };
            var w = new Worker { Id = "123" };

            //Printer p = new Printer();
            //p.Print(s);
            //p.Print(w);

            //GenericPrinter<int> intPrinter = new GenericPrinter<int>();

            GenericPrinter<Student> studentPrinter = new GenericPrinter<Student>();
            studentPrinter.Print(s);

            GenericPrinter<Worker> workerPrinter = new GenericPrinter<Worker>();
            workerPrinter.Print(w);

            GenericPrinter2 genericPrinter2 = new GenericPrinter2();
            genericPrinter2.Print<Student>(s);
            genericPrinter2.Print<Worker>(w);

            ArrayList al = new ArrayList();

            al.Add(s);
            al.Add(s);

            List<Student> students = new List<Student>();
            students.Add(s);
        }
    }
}
