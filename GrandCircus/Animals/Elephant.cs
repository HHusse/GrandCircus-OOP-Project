using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircus.Animals
{
    class Elephant : AnimalBase
    {
        public Elephant(string name) : base(name)
        {
            SpeciesName = "Elephant";
        }

        public override string MakeSound()
        {
            return "bahruuuuuuhhhhaaaaa";
        }
    }
}
