using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog
    {
        public string name { get; set; }

        public int age { get; set; }

        public int numberOfLegs { get; set; }

        public string produceSound()
        {
            return $"I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.";
        }
    }
}
