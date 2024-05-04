namespace AbstractFactoryMethodDP;

public class LuxuryCar : Car
{
	public LuxuryCar(Location location) : base(CarType.LUXURY, location)
	{
		Construct();
	}

	public override void Construct()
	{
		Console.WriteLine("Connecting to luxury car");
	}
}
