using System;

[Serializable]
public class InventoryItem
{
	public enum ID
	{
		None = 0,
		HiPoint = 1,
		Luger = 2,
		JB1911 = 3,
		GreaseGun = 4,
		Mossberg590 = 5,
		Pipe = 6,
		Pickaxe = 7,
		Nodachi = 8,
		ShotgunAmmo = 9,
		SniperAmmo = 10,
		RifleAmmo = 11,
		PistolAmmo = 12,
		M1Carbine = 13,
		M1Garand = 14,
		P320 = 15,
		FAMAS = 16,
		FAL = 17,
		Painkiller = 18,
		SodaCan = 19,
		Syrup = 20,
		VSS = 21,
		UMP = 22,
		Welrod = 23,
		Bandage = 24,
		CandyBar = 25,
		WaterBottle = 26,
		Fruit = 27,
		C96 = 28,
		Type26 = 29,
		CoachShotgun = 30,
		Beretta38 = 31,
		Stg44 = 32,
		SVT40 = 33,
		Terminator = 34,
		KnifeAk47 = 35,
		WoodenClub = 36,
		BossFlash = 37,
		BossShield = 38,
		Shuriken = 39,
		KrissVector = 40,
		VectorTactical = 41,
		PPSH = 42,
		TrenchShotgun = 43,
		DeLisle = 44,
		LeeEnfield = 45,
		Barrett = 46,
		Ultimax100 = 47,
		Shovel = 48,
		Cleaver = 49,
		RiotShotgun = 50,
		DovesCake = 51,
		ThrowableCleaver = 52,
		Stun = 53,
		Grenade = 54,
		ToxBall = 55,
		QueensHammer = 56
	}

	public ID id;

	public IntVec2 pos;

	public bool rotated;

	public int stackCount;

	public int ammo;

	public bool IsNone => false;

	public static InventoryItem None => null;

	public InventoryItem(ID id_)
	{
	}

	public InventoryItem(ID id_, int stackCount)
	{
	}

	public InventoryItem Clone()
	{
		return null;
	}

	public void Clear()
	{
	}

	public DatabaseItem GetDBItem()
	{
		return null;
	}

	public int GetGenericNumericValue()
	{
		return 0;
	}

	public void SetGenericNumericValue(int val)
	{
	}

	public static ID GetRandomAmmoID()
	{
		return default(ID);
	}

	public static InventoryItem CreateInventoryItem(ID itemID, int numericValue)
	{
		return null;
	}
}
