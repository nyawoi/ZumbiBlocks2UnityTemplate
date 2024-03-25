using System;

[Serializable]
public class LootDistribution
{
	public TierLootDistribution[] tier;

	public InventoryItem.ID GetLootID(int t)
	{
		return default(InventoryItem.ID);
	}
}
