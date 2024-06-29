namespace BuilderMethodDP;

public class TipiHouseBuilder : IHouseBuilder
{
	private HousePlan house;

	public TipiHouseBuilder()
	{
		this.house = new HousePlan();
	}

	public void BuildBasement()
	{
		house.SetBasement("Wooden Poles");
	}

	public void BuildStructure()
	{
		house.SetStructure("Wood and Ice");
	}

	public void BuildRoof()
	{
		house.SetRoof("Wood, caribou and seal skins");
	}

	public void BuildInterior()
	{
		house.SetInterior("Fire Wood");
	}

	public HousePlan GetHouse()
	{
		return house;
	}
}
