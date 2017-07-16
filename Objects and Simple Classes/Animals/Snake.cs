using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Snake
    {
        public string name { get; set; }

        public int age { get; set; }

        public int crueltyCoefficient { get; set; }

        public string produceSound()
        {
            return $"I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home."; 
        }
    }
}
