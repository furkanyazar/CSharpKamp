using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    class Order
    {
        public int Id { get; set; }
        public Gamer Gamer { get; set; }
        public List<Game> Games { get; set; }
    }
}
