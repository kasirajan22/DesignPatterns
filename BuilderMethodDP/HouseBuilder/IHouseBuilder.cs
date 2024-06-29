namespace BuilderMethodDP;

public interface IHouseBuilder
{
	void BuildBasement();
	void BuildStructure();
	void BuildRoof();
	void BuildInterior();
	HousePlan GetHouse();
}