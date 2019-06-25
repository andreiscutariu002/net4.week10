using System;

namespace GenericComparer
{
    public class Student : IComparable
    {
        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }

        public string Name { get; set; }

        public int Grade { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new NullReferenceException();
            }

            var student = obj as Student;

            if (student == null)
            {
                throw new InvalidCastException();
            }

            if (this.Grade < student.Grade)
            {
                return -1;
            }

            if (this.Grade == student.Grade)
            {
                return 0;
            }

            return 1;
        }
    }
}
