namespace DesignPatterns
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object _lock = new object();

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                        instance = new Singleton();
                    return instance;
                }
            }
        }

        public void PrintHello()
        {
            Console.WriteLine("Hi Hello");
        }
    }
}