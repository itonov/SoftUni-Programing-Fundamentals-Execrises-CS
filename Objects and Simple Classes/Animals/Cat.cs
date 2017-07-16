using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat
    {
        public string name { get; set; }

        public int age { get; set; }

        public int intelligenceQuotient { get; set; }

        public string produceSound()
        {
            return $"I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.";
        }
    }
}
