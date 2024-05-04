namespace AbstractFactoryMethodDP;

// The Below code provides an abstract base class Car and concrete implementations for each type of car. 
// There are also separate factory classes for different locations (INDIACarFactory, USACarFactory, and DefaultCarFactory). 
// The CarFactory class acts as an abstract factory that decides which concrete factory to use based on the specified location.



class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine(CarFactory.BuildCar(CarType.MICRO));
		Console.WriteLine(CarFactory.BuildCar(CarType.MINI));
		Console.WriteLine(CarFactory.BuildCar(CarType.LUXURY));
	}
}
