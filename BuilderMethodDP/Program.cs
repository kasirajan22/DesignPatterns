using BuilderMethodDP;

class Builder
{
	public static void Main(string[] args)
	{
		IHouseBuilder builder = new TipiHouseBuilder();
		CivilEngineer engineer = new CivilEngineer(builder);

		engineer.ConstructHouse();

		HousePlan house = engineer.GetHouse();

		Console.WriteLine("Builder constructed: " + house);
	}
}
