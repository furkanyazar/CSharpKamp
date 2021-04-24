using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    class Gamer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdentityNumber { get; set; }
    }
}
