using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
	public enum EquippedID
	{
		PrimaryGun = 0,
		SecondaryGun = 1,
		Melee = 2,
		Throwable = 3,
		Consumable = 4,
		Tool = 5,
		Healing = 6,
		COUNT = 7
	}

	[Header("Settings")]
	public PlayerMain playerMain;

	public bool randomizeOnStart;

	public InventoryItem.ID forcedPrimary;

	public InventoryItem.ID forcedSecondary;

	public InventoryItem.ID forcedThrowable;

	[Header("Storage")]
	public ItemContainer storage;

	public InventoryItem[] equippedItem;

	[Header("Runtime")]
	public EquippedProp[] spawnedEquipment;

	public Transform[] WeaponPivot => null;

	public void Init()
	{
	}

	private void Randomize()
	{
	}

	public void DiscardEquipmentStack(int index)
	{
	}

	public bool HasAmmoOfType(InventoryItem.ID ammoID)
	{
		return false;
	}

	public int AmmoCountOfType(InventoryItem.ID ammoID)
	{
		return 0;
	}

	public int PullAmmoOfType(InventoryItem.ID ammoID, int maxAmount)
	{
		return 0;
	}

	public InventoryItem GetEquipment(int index)
	{
		return null;
	}

	public InventoryItem RemoveEquippedItem(int index)
	{
		return null;
	}

	public void SetEquipment(InventoryItem item, int index)
	{
	}

	public static bool ProcessItemStacking(InventoryItem item1, InventoryItem item2)
	{
		return false;
	}

	public InventoryItem TryAddEquipment(InventoryItem item, int index)
	{
		return null;
	}

	public void DropAllLoot()
	{
	}

	public void OnEquipmentChanged()
	{
	}

	public static bool CanDropEquipment(InventoryItem item, int index)
	{
		return false;
	}

	public void EnsurePropExistence()
	{
	}

	public static void AttachEquipmentTo(EquippedProp sourceProp, Transform target, bool isHolster, bool changePosition = true)
	{
	}

	public void DropLoot(InventoryItem item)
	{
	}

	public LootTargetPosition FindPlaceFor(InventoryItem.ID targetItemID, int itemStackCount, bool considerStacking, bool considerEquipment)
	{
		return null;
	}

	public void GetDovesCake()
	{
	}

	public bool ItemExists(InventoryItem item, bool remove)
	{
		return false;
	}
}
