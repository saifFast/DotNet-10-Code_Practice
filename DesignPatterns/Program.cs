using DesignPatterns;

//var factory = new FactoryPattern();
//factory.GetAnimal("Bird").DisplayInfo();

var singleton = Singleton.Instance;
singleton.PrintHello();