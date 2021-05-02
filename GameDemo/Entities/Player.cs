using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Player: Person
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Balance { get; set; }
    }
}
