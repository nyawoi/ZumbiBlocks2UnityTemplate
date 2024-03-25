using System;

[Serializable]
public class StatusEffect
{
	public enum ID
	{
		Food = 0,
		Med = 1,
		Toxic = 2,
		Drink = 3
	}

	public ID id;

	public float maxValue;

	public float curValue;

	public float tier;
}
