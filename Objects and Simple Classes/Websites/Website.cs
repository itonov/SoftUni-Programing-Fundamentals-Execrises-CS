using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websites
{
    public class Website
    {
        public string host { get; set; }

        public string domain { get; set; }

        public List<string> queries { get; set; }
    }
}
