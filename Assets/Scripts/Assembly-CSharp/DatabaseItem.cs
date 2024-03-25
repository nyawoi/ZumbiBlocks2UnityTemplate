using UnityEngine;

public class DatabaseItem : MonoBehaviour
{
	public enum SubType
	{
		PrimaryGun = 0,
		SecondaryGun = 1,
		Melee = 2,
		Throwable = 3,
		Food = 4,
		Tool = 5,
		Healing = 6,
		Misc = 7
	}

	public enum Tier
	{
		Tier1 = 0,
		Tier2 = 1,
		Tier3 = 2,
		Tier4 = 3,
		Tier5 = 4
	}

	[Header("Base item")]
	public InventoryItem.ID itemID;

	public string nameTag;

	public string descTag;

	public Tier tier;

	public GameObject simplePropPrefab;

	public Sprite sprite;

	public int stackMax;

	public IntVec2 size;

	public string GetName => null;

	public bool IsSmallItem => false;

	public bool IsNone => false;

	public IntVec2 Size(bool rot)
	{
		return default(IntVec2);
	}

	public virtual SubType GetSubType()
	{
		return default(SubType);
	}

	public virtual GameObject GetEquippedProp()
	{
		return null;
	}
}
