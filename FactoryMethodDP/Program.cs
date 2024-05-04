namespace FactoryMethodDP;

// The Factory Method is a creational design pattern in C# that offers a way to create objects without directly calling their constructors. 

// Open/Closed Principle
class Program
{
	static void Main(string[] args)
	{
		Client client = new Client();

		client.BuildVehicle(VehicleType.TwoWheeler);
		client.GetVehicle()?.PrintVehicleInfo();

		client.BuildVehicle(VehicleType.ThreeWheeler);
		client.GetVehicle()?.PrintVehicleInfo();

		client.BuildVehicle(VehicleType.FourWheeler);
		client.GetVehicle()?.PrintVehicleInfo();
	}
}
