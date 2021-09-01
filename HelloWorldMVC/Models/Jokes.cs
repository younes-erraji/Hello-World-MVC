using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMVC.Models
{
    public class Jokes
    {
        // prop
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }
        // ctor
        public Jokes()
        {
            
        }
        // cw
        // Console.WriteLine();
    }
}
