namespace AbstractFactoryMethodDP;

public class MicroCar : Car
{
	public MicroCar(Location location) : base(CarType.MICRO, location)
	{
		Construct();
	}

	public override void Construct()
	{
		Console.WriteLine("Connecting to Micro Car ");
	}
}