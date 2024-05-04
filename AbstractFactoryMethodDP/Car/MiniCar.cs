namespace AbstractFactoryMethodDP;

public class MiniCar : Car
{
	public MiniCar(Location location) : base(CarType.MINI, location)
	{
		Construct();
	}

	public override void Construct()
	{
		Console.WriteLine("Connecting to Mini car");
	}
}