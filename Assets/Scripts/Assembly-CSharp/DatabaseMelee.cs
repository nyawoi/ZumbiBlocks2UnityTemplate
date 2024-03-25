using UnityEngine;

public class DatabaseMelee : DatabaseItem
{
	[Header("Melee")]
	public GameObject meleePrefab;

	public int baseDmg;

	public override SubType GetSubType()
	{
		return default(SubType);
	}

	public override GameObject GetEquippedProp()
	{
		return null;
	}
}
