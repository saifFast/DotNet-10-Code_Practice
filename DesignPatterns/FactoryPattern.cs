namespace DesignPatterns
{
    public interface IShape
    {

        void Draw();

    };

    public class Circle : IShape
    {
        public void Draw() => Console.WriteLine("Drawing a Circle");
    }

    public class Rectangle : IShape
    {
        public void Draw() => Console.WriteLine("Drawing a Rectangle");
    }

    public abstract class ShapeFactory
    {
        public abstract IShape CreateShape();
    }

    public class CircleFactory : ShapeFactory
    {
        public override IShape CreateShape()
        {
            return new Circle();
        }
    }

}
