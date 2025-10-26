namespace Test.Interfaces
{
    public interface IAnimal
    {
        void SetNameAndCategory(string inputName, string inputCategory);
        void DisplayInfo();
        string GetName();
        string GetCategory();
    };
}
