using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<Campaign> Campaigns { get; set; }
    }
}
