using System.Collections.Generic;

namespace GameDemo.Entities
{
    internal class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<Campaign> Campaigns { get; set; }
    }
}