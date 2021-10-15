namespace GameDemo.Entities
{
    internal class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Discount { get; set; }
        public Game Game { get; set; }
    }
}