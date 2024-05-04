namespace FactoryMethodDP;

public class Client
{
	private Vehicle? _pVehicle;

	public Client()
	{
		_pVehicle = null;
        Console.WriteLine("Client Object Created");
	}

	public void BuildVehicle(VehicleType vehicleType)
	{
		IVehicleFactory vf = new VehicleFactory();
		_pVehicle = vf.Build(vehicleType);
        Console.WriteLine($"{vehicleType} Object Created");
	}

	public Vehicle? GetVehicle()
	{
		return _pVehicle;
	}
}