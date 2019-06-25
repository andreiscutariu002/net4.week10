namespace ConsoleApp
{
    public class Student : IPrintable
    {
        public string Name { get; set; }

        public void Print()
        {
            System.Console.WriteLine($"Student {this.Name}");
        }

        public override string ToString()
        {
            return $"Student {this.Name}";
        }
    }
}
