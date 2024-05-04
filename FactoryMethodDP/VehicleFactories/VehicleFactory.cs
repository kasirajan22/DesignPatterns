namespace FactoryMethodDP;

public class VehicleFactory : IVehicleFactory
{
	public Vehicle? Build(VehicleType vehicleType)
	{
		switch (vehicleType)
		{
			case VehicleType.TwoWheeler:
				return new TwoWheeler();
			case VehicleType.ThreeWheeler:
				return new ThreeWheeler();
			case VehicleType.FourWheeler:
				return new FourWheeler();
			default:
				return null;
		}
	}
}