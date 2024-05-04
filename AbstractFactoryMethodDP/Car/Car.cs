namespace AbstractFactoryMethodDP;

public abstract class Car
{
	protected Car(CarType model, Location location)
	{
		Model = model;
		Location = location;
	}

	public CarType Model { get; }
	public Location Location { get; }

	public abstract void Construct();

	public override string ToString()
	{
		return $"CarModel - {Model} located in {Location}";
	}
}