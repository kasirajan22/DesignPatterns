namespace AbstractFactoryMethodDP;

public class USACarFactory
{
	public static Car? BuildCar(CarType model)
	{
		switch (model)
		{
			case CarType.MICRO:
				return new MicroCar(Location.USA);

			case CarType.MINI:
				return new MiniCar(Location.USA);

			case CarType.LUXURY:
				return new LuxuryCar(Location.USA);

			default:
				return null;
		}
	}
}