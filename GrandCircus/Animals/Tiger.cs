using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircus.Animals
{
    class Tiger : AnimalBase
    {
        public Tiger(string name) : base(name)
        {
            SpeciesName = "Tiger";
        }

        public override string MakeSound()
        {
            return "Growl!";
        }
    }
}
