using System;

// Interface for the prototype
public interface IGraphicElement
{
	IGraphicElement Clone();
	void Display();
	// Other methods for customization can be added here
}

// Concrete prototype representing a graphic element
public class Logo : IGraphicElement
{
	private string name;
	private string color;

	public Logo(string name, string color)
	{
		this.name = name;
		this.color = color;
	}

	public IGraphicElement Clone()
	{
		// Create a shallow copy of the object
		return (IGraphicElement)MemberwiseClone();
	}

	public void Display()
	{
		Console.WriteLine($"Logo: {name}, Color: {color}");
	}

	// Additional methods for customization can be added here
}

// Client code demonstrating the use of the Prototype pattern
class Program
{
	static void Main()
	{
		// Create an initial logo prototype
		IGraphicElement originalLogo = new Logo("OriginalLogo", "Blue");
		
		// Clone the original logo to create a new customized logo
		IGraphicElement customizedLogo = originalLogo.Clone();
		
		// Display the original and customized logos
		Console.WriteLine("Original Logo:");
		originalLogo.Display();

		Console.WriteLine("\nCustomized Logo:");
		customizedLogo.Display();
	}
}
