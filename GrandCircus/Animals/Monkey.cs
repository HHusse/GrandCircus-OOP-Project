using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircus.Animals
{
    class Monkey : AnimalBase
    {
        public Monkey(string name) : base(name)
        {
            SpeciesName = "Monkey";
        }

        public override string MakeSound()
        {
            return "Ook-ook! Eeek-aak-eek!";
        }
    }
}
