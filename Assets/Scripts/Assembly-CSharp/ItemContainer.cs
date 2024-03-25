using System;
using System.Collections.Generic;

[Serializable]
public class ItemContainer
{
	public IntVec2 size;

	public List<InventoryItem> items;

	public void Randomize()
	{
	}

	private void AddRandomItem(InventoryItem.ID itemID)
	{
	}

	public void AddItem(InventoryItem item)
	{
	}

	public void RemoveItem(InventoryItem item)
	{
	}

	public InventoryItem RemoveItem(int index)
	{
		return null;
	}

	public bool ItemInsideBounds(IntVec2 pos, IntVec2 itemSize)
	{
		return false;
	}

	public bool ItemFits(IntVec2 pos, IntVec2 itemSize)
	{
		return false;
	}

	public InventoryItem GetSlottedItem(IntVec2 pos)
	{
		return null;
	}

	public static void PutLootIntoPlace(InventoryItem item, LootTargetPosition ltp, ItemContainer container)
	{
	}
}
