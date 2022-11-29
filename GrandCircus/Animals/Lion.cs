using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircus.Animals
{
    class Lion : AnimalBase
    {
        public Lion(string name) : base(name)
        {
            SpeciesName = "Lion";
        }
        public override string MakeSound()
        {
            return "Raaww!";
        }
    }
}
