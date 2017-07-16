using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise
    {
        public string topic { set; get; }

        public string courseName { get; set; }

        public string judgeContestLink { get; set; }

        public List<string> problems { get; set; }
    }
}
