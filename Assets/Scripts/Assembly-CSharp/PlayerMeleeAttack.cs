using UnityEngine;

public class PlayerMeleeAttack : MonoBehaviour
{
	public enum ID
	{
		QuickBluntOneHand1 = 0,
		StrongBluntOneHand1 = 1,
		NodachiQuickStrike1 = 2,
		NodachiSlowStrike1 = 3,
		PickaxeSlowStrike1 = 4,
		PickaxeFastStrike1 = 5,
		KnifeStab = 6,
		Ak47Strike = 7,
		ClubStrike1 = 8,
		LegSweep = 9,
		LeftPunch = 10,
		RightPunch = 11,
		PistolButting = 12,
		RifleButting = 13,
		BayonetStab = 14,
		ShovelThrust = 15,
		ShovelBash = 16,
		CleaverThrow = 17,
		FrontKick = 18,
		BackFist = 19
	}

	public enum DamageType
	{
		Multiplier = 0,
		Absolute = 1
	}

	public enum RaycastSource
	{
		RightHand = 0,
		LeftHand = 1,
		RightFoot = 2
	}

	public ID id;

	[Header("Damaging")]
	public DamageType damageType;

	public float damageValue;

	public Stagger stagger;

	[Header("Throwing")]
	public InventoryItem.ID throwableID;

	[Header("Raycasting")]
	public RaycastSource raycastSource;

	public Vector3 localVector3;

	[Header("Animation")]
	public string animationName;

	[Range(0f, 1f)]
	public float hitStart;

	[Range(0f, 1f)]
	public float hitEnd;

	[Range(0f, 1f)]
	public float attackEnd;

	[Header("Movement")]
	public float moveSpeed;

	public AnimationCurve zSpeed;

	[Header("Audio")]
	public AudioPack soundFX;

	public AudioController.ImpactFXID impactFX;

	public bool Throwable => false;

	public float GetDamage(DatabaseMelee referenceItem)
	{
		return 0f;
	}
}
