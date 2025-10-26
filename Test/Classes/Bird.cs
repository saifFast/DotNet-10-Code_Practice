using Test.Interfaces;

namespace Test.Classes
{
    public class Bird : Animal, IFlyingAnimal
    {
        private int MaxFlyingHeight;

        public Bird(string name, string category, int height) : base(name, category)
        {
            MaxFlyingHeight = height;
        }

        public void SetMaxFlyingHeight(int height)
        {
            MaxFlyingHeight = height;
        }
        public int GetMaxFlyingHeight()
        {
            return MaxFlyingHeight;
        }

        public void Fly()
        {
            Console.WriteLine("I am flying at " + MaxFlyingHeight);
        }
    }
}
