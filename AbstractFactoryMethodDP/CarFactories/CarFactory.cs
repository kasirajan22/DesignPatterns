﻿namespace AbstractFactoryMethodDP;

public class CarFactory
{
	private CarFactory()
	{
	}

	public static Car? BuildCar(CarType type)
	{
		Location location = Location.INDIA;

		switch (location)
		{
			case Location.USA:
				return USACarFactory.BuildCar(type);

			case Location.INDIA:
				return INDIACarFactory.BuildCar(type);

			default:
				return DefaultCarFactory.BuildCar(type);
		}
	}
}