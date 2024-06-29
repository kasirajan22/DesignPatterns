namespace BuilderMethodDP;

public class IglooHouseBuilder : IHouseBuilder
{
	private HousePlan house;

	public IglooHouseBuilder()
	{
		this.house = new HousePlan();
	}

	public void BuildBasement()
	{
		house.SetBasement("Ice Bars");
	}

	public void BuildStructure()
	{
		house.SetStructure("Ice Blocks");
	}

	public void BuildRoof()
	{
		house.SetRoof("Ice Dome");
	}

	public void BuildInterior()
	{
		house.SetInterior("Ice Carvings");
	}

	public HousePlan GetHouse()
	{
		return house;
	}
}
