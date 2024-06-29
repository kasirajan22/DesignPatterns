﻿namespace BuilderMethodDP;

public class HousePlan : IHousePlan
{
	private string? basement;
	private string? structure;
	private string? roof;
	private string? interior;

	public void SetBasement(string basement)
	{
		this.basement = basement;
	}

	public void SetStructure(string structure)
	{
		this.structure = structure;
	}

	public void SetRoof(string roof)
	{
		this.roof = roof;
	}

	public void SetInterior(string interior)
	{
		this.interior = interior;
	}

	public override string ToString()
	{
		return $"Basement: {basement}, Structure: {structure}, Roof: {roof}, Interior: {interior}";
	}
}
