namespace FactoryMethodDP;

public interface IVehicleFactory
{
	Vehicle? Build(VehicleType vehicleType);
}
