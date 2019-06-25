namespace ConsoleApp
{
    public class Worker : IPrintable
    {
        public string Id { get; set; }

        public void Print()
        {
            System.Console.WriteLine($"Worker {this.Id}");
        }

        public override string ToString()
        {
            return $"Worker {this.Id}";
        }
    }
}
