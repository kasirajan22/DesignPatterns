namespace AbstractFactoryMethodDP;

public class DefaultCarFactory
{
	public static Car? BuildCar(CarType model)
	{
		switch (model)
		{
			case CarType.MICRO:
				return new MicroCar(Location.DEFAULT);

			case CarType.MINI:
				return new MiniCar(Location.DEFAULT);

			case CarType.LUXURY:
				return new LuxuryCar(Location.DEFAULT);

			default:
				return null;
		}
	}
}