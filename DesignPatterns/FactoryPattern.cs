using Test.Interfaces;
using Test.Classes;

namespace DesignPatterns
{
    internal class FactoryPattern
    {
        public IAnimal GetAnimal(string category)
        {
            var newAnimal = new Animal();

            switch (category)
            {
                case "Bird":
                    newAnimal = new Bird("Penguin", "Mammal", 0);
                    break;
                default:
                    break;
            }

            return newAnimal;
        }
    }
}
