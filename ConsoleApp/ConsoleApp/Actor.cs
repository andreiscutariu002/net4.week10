namespace ConsoleApp
{
    public class Actor
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Actor {this.Id}, {this.Name}";
        }
    }
}
