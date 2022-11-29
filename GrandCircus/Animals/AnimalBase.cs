using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircus.Animals
{
    abstract class AnimalBase : IAnimal
    {
        public string Name { get; }
        public string SpeciesName { get; set; }
        public AnimalBase(string name)
        {
            if (name == null)
                throw new ArgumentNullException();
            else
                Name = name;

        }
        public abstract string MakeSound();
    }
}
