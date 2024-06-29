using FacadeMethodDP;

// The Facade Pattern hides the complexities of the engine and lights subsystems, 
// offering a straightforward way to interact with the car. 
// It’s like having a user-friendly control panel, making the car operation more accessible and user-friendly.
class Program
{
	static void Main()
	{
		Car car = new Car();
		car.StartCar();
		car.StopCar();
	}
}
