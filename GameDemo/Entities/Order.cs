using System.Collections.Generic;

namespace GameDemo.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public Gamer Gamer { get; set; }
        public List<Game> Games { get; set; }
    }
}
