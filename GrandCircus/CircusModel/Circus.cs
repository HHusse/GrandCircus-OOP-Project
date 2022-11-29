using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrandCircus.Animals;
using GrandCircus.Presentation;


namespace GrandCircus.CircusModel
{
    class Circus
    {
        List<IAnimal> animals = new List<IAnimal>();
        Arena arena;
        private string name;

        public Circus(Arena arena, string name)
        {
            if (arena == null)
                throw new ArgumentNullException();
            else
            {
                this.arena = arena;
                this.name = name;
                CircusAnimal();
            }
        }

        public void AddAnimal(AnimalBase a)
        {
            IAnimal animal = a;
            animals.Add(animal);

        }

        public void CircusAnimal()
        {
            AddAnimal(new Elephant("Bela"));
            AddAnimal(new Monkey("Mogli"));
            AddAnimal(new Snake("Daisy"));
        }

        public void Perform()
        {
            arena.PresentCircus(name);

            foreach (var animal in animals)
            {
                arena.AnnounceAnimal(animal.Name, animal.SpeciesName);
                arena.DisplayAnimalPerformance(animal.MakeSound());
            }


        }
    }
}
