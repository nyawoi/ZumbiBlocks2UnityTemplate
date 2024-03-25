using UnityEngine;

public class DatabaseConsumable : DatabaseItem
{
	[Header("Consumable")]
	public GameObject consumablePrefab;

	public ConsumableAnimation.ID animationID;

	public bool ishealing;

	[Header("Effect")]
	public StatusEffect.ID statusID;

	public float effectAmount;

	public override GameObject GetEquippedProp()
	{
		return null;
	}

	public override SubType GetSubType()
	{
		return default(SubType);
	}
}
