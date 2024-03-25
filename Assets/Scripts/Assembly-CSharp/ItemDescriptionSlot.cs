using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemDescriptionSlot : MonoBehaviour
{
	public enum ID
	{
		FireMode = 0,
		GunClass = 1,
		AmmoType = 2,
		CrowdControl = 3,
		Bayonet = 4,
		Duckbill = 5,
		HSMulti = 6,
		Pierce = 7,
		Damage = 8,
		FireRate = 9,
		MaxAmmo = 10,
		ADSSpeed = 11,
		Accuracy = 12,
		Recoil = 13,
		NoiseRange = 14,
		ReloadTime = 15,
		COUNT = 16
	}

	public enum MeleeID
	{
		MeleeDMG1 = 0,
		MeleeDMG2 = 1,
		Reach = 2,
		Stagger = 3,
		COUNT = 4
	}

	public TMP_Text textLeft;

	public TMP_Text textRight;

	public Image fillBar;
}
