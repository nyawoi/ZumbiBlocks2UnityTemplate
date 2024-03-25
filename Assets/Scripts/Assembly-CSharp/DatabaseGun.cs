using System;
using UnityEngine;

public class DatabaseGun : DatabaseItem
{
	public enum GunClass
	{
		Pistol = 0,
		Revolver = 1,
		MachinePistol = 2,
		SMG = 3,
		Carbine = 4,
		AssaultRifle = 5,
		BattleRifle = 6,
		DMR = 7,
		PrecisionRifle = 8,
		LMG = 9,
		HMG = 10,
		Shotgun = 11
	}

	public enum Supression
	{
		Unsuppressed = 0,
		Suppressed = 1,
		IntegrallySuppressed = 2
	}

	public enum Choke
	{
		None = 0,
		BaseShotgunChoke = 1,
		DuckbillChoke = 2
	}

	[Serializable]
	public class OtherStats
	{
		public float burstDPS;

		public float magDMG;

		public float ammoEfficiency;

		public float feltRecoil;

		public float noiseRange;

		public float accuracy;

		public float SortStat => 0f;
	}

	[Header("Gun")]
	public GameObject gunPrefab;

	public GunClass gunClass;

	public Supression supression;

	[Header("Damage Base")]
	public float dmg;

	public float rof;

	[Range(1f, 15f)]
	public int pelletCount;

	public bool fullAuto;

	public int burstCount;

	public int burstSpace;

	[Header("Damage Special")]
	[Range(1f, 2f)]
	public float hsMultiplier;

	[Range(0f, 6f)]
	public float pierce;

	public Choke choke;

	public bool crowdControl;

	[Header("Recoil")]
	public Vector2 recoil;

	[Range(0f, 1f)]
	public float recoilRandomness;

	[Range(0f, 10f)]
	public float recoilSpeedMultiplier;

	[Header("Accuracy")]
	[Range(1f, 150f)]
	public float spread;

	[Range(0.2f, 0.6f)]
	public float scopingFactor;

	[Range(6f, 20f)]
	public float adsSpeed;

	[Header("Animations")]
	public ReloadGunAnimation.ID reloadAnimation;

	[Header("Ammo")]
	public InventoryItem.ID ammoID;

	public int maxAmmo;

	public OtherStats otherStats;

	public bool IsBurst => false;

	public void CalculateOtherStats()
	{
	}

	public float GetDPS()
	{
		return 0f;
	}

	public override GameObject GetEquippedProp()
	{
		return null;
	}
}
