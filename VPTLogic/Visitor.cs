using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPTLogic
{
    public class Visitor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Signup { get; set; }
        public DateTime Birthday { get; set; }
        public int age { get { return DateTime.Today.Year - Birthday.Year; } }    
    }
}
