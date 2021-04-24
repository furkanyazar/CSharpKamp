﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Discount { get; set; }
        public Game Game { get; set; }
    }
}
