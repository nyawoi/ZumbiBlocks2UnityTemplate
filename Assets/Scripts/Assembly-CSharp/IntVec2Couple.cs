using System;
using System.Collections.Generic;

[Serializable]
public class IntVec2Couple
{
	public IntVec2 first;

	public IntVec2 second;

	public IntVec2Couple(IntVec2 f, IntVec2 s)
	{
	}

	public bool Contains(IntVec2 vec2)
	{
		return false;
	}

	public IntVec2Couple Reverse()
	{
		return null;
	}

	public IntVec2? GetOther(IntVec2 vec2)
	{
		return null;
	}

	public bool LooseCompare(IntVec2Couple other)
	{
		return false;
	}

	public static bool CouplesContainLoose(IntVec2Couple testCouple, List<IntVec2Couple> couples)
	{
		return false;
	}

	public static bool CouplesContainLoose(IntVec2Couple testCouple, List<Furniture.WallInstance> furnitures, out Furniture.ID id)
	{
		id = default(Furniture.ID);
		return false;
	}

	public static bool CouplesContainLoose(IntVec2Couple testCouple, List<Furniture.WallInstance> couples)
	{
		return false;
	}
}
