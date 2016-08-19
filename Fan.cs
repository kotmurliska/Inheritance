using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Fan
    {
        public Fan(DateTime birthdate, Address birthplace, params )
            : base(birthdate, birthplace)
        { }
        public Band[] Groups { get; set; }
        public void Shout()
        { }
    }
}
