using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircus.Animals
{
    class Snake : AnimalBase
    {
        public Snake(string name) : base(name)
        {
            SpeciesName = "Snake";
        }

        public override string MakeSound()
        {
            return "Ssssssssssss";
        }
    }
}
