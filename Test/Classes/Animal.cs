using Test.Interfaces;

namespace Test.Classes
{
    public class Animal : IAnimal
    {
        private string _name;
        private string _category;

        public Animal(string name, string category)
        {
            _name = name;
            _category = category;
        }

        public void SetNameAndCategory(string inputName, string inputCategory)
        {
            _name = inputName;
            _category = inputCategory;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {_name}, Category: {_category}");
        }

        public string GetName()
        {
            return _name;
        }

        public string GetCategory()
        {
            return _category;
        }
    };
}
