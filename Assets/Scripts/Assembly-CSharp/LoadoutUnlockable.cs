using System;
using UnityEngine;

public class LoadoutUnlockable : MonoBehaviour
{
	public enum Type
	{
		Equipment = 0,
		Resources = 1,
		Skin = 2
	}

	[Serializable]
	public class LoadoutResources
	{
		public string customName;

		public Sprite customSprite;

		public ResourcePack[] resources;

		public string GetCustomName => null;
	}

	[Serializable]
	public class ResourcePack
	{
		public InventoryItem.ID itemID;

		public int itemQuantity;
	}

	public enum ID
	{
		Welrod = 0,
		Type26 = 1,
		GreaseGun = 2,
		M1Carbine = 3,
		ConsumablesT1 = 4,
		PistolAmmoT1 = 5,
		RifleAmmoT1 = 6,
		SniperAmmoT1 = 7,
		ShotgunAmmoT1 = 8,
		SVT40 = 9,
		Terminator = 10,
		KnifeAk47 = 11,
		WoodenClub = 12,
		Shuriken = 13,
		Luger = 14,
		C96 = 15,
		Pipe = 16,
		Shovel = 17,
		Cleaver = 18,
		PPSH = 19,
		Beretta38 = 20,
		DeLisle = 21,
		Stg44 = 22,
		Ultimax = 23,
		LeeEnfield = 24,
		M1Garand = 25,
		TrenchShotgun = 26,
		ConsumablesT2 = 27,
		Stun = 28,
		Frag = 29
	}

	public ID id;

	[Header("Equipment")]
	public InventoryItem.ID equipmentID;

	[Header("Resources")]
	public LoadoutResources resources;

	public new Type GetType()
	{
		return default(Type);
	}

	public string GetName()
	{
		return null;
	}

	public Sprite GetSprite()
	{
		return null;
	}

	public InventoryItem.ID GetPropID()
	{
		return default(InventoryItem.ID);
	}
}
