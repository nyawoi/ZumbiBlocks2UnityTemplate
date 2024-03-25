using System.Collections.Generic;
using UnityEngine;

public class ItemsBase : MonoBehaviour
{
	public static ItemsBase instance;

	public List<DatabaseItem> item;

	[Header("Ammo Lists")]
	public InventoryItem.ID[] ammoList;

	public int[] baseAmmoCount;

	public InventoryItem GetRandomAmmo(float baseMulti)
	{
		return null;
	}

	public void Init()
	{
	}

	public DatabaseItem GetItem(InventoryItem.ID id)
	{
		return null;
	}

	public DatabaseItem GetRandomItem(DatabaseItem.SubType subType)
	{
		return null;
	}
}
