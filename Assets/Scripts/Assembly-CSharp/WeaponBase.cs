using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : MonoBehaviour
{
	public static WeaponBase instance;

	public PlayerCamera playerCamera;

	public float precisionMultiplier;

	public float gunSway;

	public float noiseMultiplier;

	public float[] chokeMultiplier;

	[Header("Default muzzle light")]
	public PhysicalGun.MuzzleLight[] defaultMuzzleLight;

	[Header("Base")]
	public DatabaseGun[] guns;

	public List<InventoryItem.ID> forbiddenGuns;

	[Header("Audio")]
	public AudioPack dryFireDefault;

	public AnimationCurve audioRangeCurve;

	[Header("Debug")]
	public bool calculateOtherStats;

	public bool printOtherStats;

	public void Init()
	{
	}

	private void PrintOtherStats()
	{
	}

	public DatabaseGun GetGunOfID(InventoryItem.ID itemID)
	{
		return null;
	}

	public float GetChoke(DatabaseGun.Choke choke)
	{
		return 0f;
	}

	public float AudioSourceRange(DatabaseGun gun)
	{
		return 0f;
	}

	public static float GetGunNoiseRange(DatabaseGun gun)
	{
		return 0f;
	}
}
