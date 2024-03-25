using System;
using UnityEngine;

public class TierLootDistribution : MonoBehaviour
{
	[Serializable]
	public class LootChance
	{
		public InventoryItem.ID itemID;

		public int probability;
	}

	public float equipmentRarity;

	public LootChance[] resources;

	public LootChance[] equipment;

	public InventoryItem.ID GetLootID()
	{
		return default(InventoryItem.ID);
	}

	public InventoryItem.ID GetLootID(LootChance[] chances)
	{
		return default(InventoryItem.ID);
	}

	public static InventoryItem GetEquipment(InventoryItem.ID itemID)
	{
		return null;
	}
}
