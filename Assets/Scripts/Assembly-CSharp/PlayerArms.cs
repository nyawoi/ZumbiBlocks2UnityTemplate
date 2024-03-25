using System.Collections.Generic;
using UnityEngine;

public class PlayerArms : MonoBehaviour
{
	public enum State
	{
		Transition = 0,
		HipFireAim = 1,
		ADSAim = 2,
		Reload = 3,
		WeaponHolster = 4,
		WeaponPick = 5,
		Interact = 6,
		ConsumeItem = 7,
		ThrowItem = 8
	}

	public PlayerMain playerMain;

	public PlayerInputReader input;

	[Header("Settings")]
	public List<PlayerMovement.State> mutualLegState;

	public LayerMask shotLayerMask;

	[Header("State")]
	public State state;

	public State targetState;

	public bool legOverride;

	public bool ads;

	[Header("Runtime")]
	public int selectedWeapon;

	public int targetEquipment;

	public bool animationTrigger;

	public string expectedArmAnimation;

	public bool needWeaponSwap;

	[Header("Reloading")]
	public bool didReload;

	public int reloadState;

	private ReloadGunAnimation curReloadAnim;

	[Header("Interacting")]
	public List<State> nonInteracitonState;

	public InteractableObject objectToInteract;

	public string curInteractAnimation;

	public float interactionTime;

	[Header("Equipped stuff")]
	public GameObject grabbedMag;

	[HideInInspector]
	private EquippedProp equippedItem;

	[HideInInspector]
	private PhysicalGun equippedGun;

	[HideInInspector]
	private PhysicalMelee equippedMelee;

	[HideInInspector]
	private PhysicalConsumable equippedConsumable;

	[HideInInspector]
	private PhysicalThrowable equippedThrowable;

	public OffHandItemHandling offhandHandling;

	[Header("Animation")]
	public List<State> eventAllowedStates;

	public float fightModeCoef;

	public Animator PlayerAnimator => null;

	public Transform RightHandPivot => null;

	public Transform LeftHandPivot => null;

	public Transform RightFootPivot => null;

	public bool CanInteract => false;

	public Vector3 ShotConvergingDirection => default(Vector3);

	public Vector3 ShotTracerOrigin => default(Vector3);

	public EquippedProp EquippedItem => null;

	public PhysicalGun EquippedGun => null;

	public byte FightModeByte => 0;

	public Transform GetMeleeRaycastSource(PlayerMeleeAttack.RaycastSource source)
	{
		return null;
	}

	public Vector3 UnmodifiedShotVector()
	{
		return default(Vector3);
	}

	public State GetEffectiveState()
	{
		return default(State);
	}

	private void GoToStateAfterTransition(State s)
	{
	}

	private void UpdateSpineInput()
	{
	}

	private void FindLegOverride()
	{
	}

	private void UpdateCamera()
	{
	}

	public void UpdateArms()
	{
	}

	private void UpdateStates()
	{
	}

	public void UpdateEquippedItemPosition()
	{
	}

	private bool ShouldAim()
	{
		return false;
	}

	public void GoIdleInstant()
	{
	}

	public void GoIdle(bool testForAim = false)
	{
	}

	private bool TryInteract()
	{
		return false;
	}

	private void ConsumeItem()
	{
	}

	private void ThrowItem()
	{
	}

	private bool TrySwapWeapon()
	{
		return false;
	}

	public float GetMeleeReach()
	{
		return 0f;
	}

	public float GetMeleeDmg(PlayerMeleeAttack refAttack)
	{
		return 0f;
	}

	public bool IsWeaponMelee()
	{
		return false;
	}

	public float GetGunSpread()
	{
		return 0f;
	}

	private void ShootGun(InventoryItem equippedGunItem)
	{
	}

	private Vector3 GetConvergingOrigin(Vector3 tracerOrigin)
	{
		return default(Vector3);
	}

	private Vector3 GetConvergingOrigin()
	{
		return default(Vector3);
	}

	private Vector3 GetBulletOrigin()
	{
		return default(Vector3);
	}

	public void FakeShoot(Vector3 vector)
	{
	}

	public void PlayGunSound(PhysicalGun gun)
	{
	}

	public void PlayGunDrySound(PhysicalGun gun)
	{
	}

	private bool TryStartReload()
	{
		return false;
	}

	private bool GunNotFilled(InventoryItem ii, DatabaseGun dbGun)
	{
		return false;
	}

	private void ReloadGun(int reloadAmount = -1)
	{
	}

	public bool IsAimingGun()
	{
		return false;
	}

	public bool IsAimingGunAndNotHipFire()
	{
		return false;
	}

	public bool IsAimingThrowable()
	{
		return false;
	}

	public bool IsAimingMelee()
	{
		return false;
	}

	private void UpdateAnimation()
	{
	}

	public float GetADSSpeed()
	{
		return 0f;
	}

	private void CrossFadeInFixedTime(string animName, float fixedTime, string sendFakeAnim = null)
	{
	}

	private void CrossFade(string animName, float time)
	{
	}

	private void PlayAnimation(string animName, bool sync = true)
	{
	}

	public bool IsSwappingWeapons()
	{
		return false;
	}

	public void OnEquipmentChanged()
	{
	}

	private bool UpdateSelectedWeapon()
	{
		return false;
	}

	private string GetPickUpAnimation(int slot)
	{
		return null;
	}

	private void SwapWeapon()
	{
	}

	public void SetEquippedItem(EquippedProp prop)
	{
	}

	private void AttachEquipmentTo(EquippedProp prop, Transform target, bool isHolster, bool changePosition = true)
	{
	}

	private void PickUpEquipment()
	{
	}

	private void HolsterWeapon()
	{
	}

	private bool AnimationEventAllowed()
	{
		return false;
	}

	public void ResetPropState()
	{
	}

	public void PlayPropSound(int index)
	{
	}

	public void PlayGunAnim(string gunAnimationID)
	{
	}

	public void SetMagVisible(bool b)
	{
	}

	public void EjectMagFromGun()
	{
	}

	public void GrabMagFromGun(bool rightHand)
	{
	}

	public void DropHandMag()
	{
	}

	public void GrabFreshMag(bool rightHand)
	{
	}

	public void InsertMagIntoGun()
	{
	}

	public void EjectBullets(int count, bool hideMag)
	{
	}

	public void RemoveCurrentGrabbedMag(bool forced)
	{
	}

	public void SpawnHandMag(bool rightHand, bool basedOnGun)
	{
	}

	public void OnDrawGizmos()
	{
	}

	public void IdleAimSharedState()
	{
	}

	private void Butting()
	{
	}

	private void GunButting()
	{
	}

	public void HipFireAimState()
	{
	}

	public void ADSAimState()
	{
	}

	private void GunUnequippedBehaviour()
	{
	}

	private void GunEquippedBehaviour()
	{
	}

	private void FireGunBehaviour(InventoryItem equippedGunItem)
	{
	}

	public void IrteractionState()
	{
	}

	public void ReloadingState()
	{
	}

	public void SwappingWeaponsState()
	{
	}

	public void ConsumeItemState()
	{
	}

	public void ThrowItemState()
	{
	}

	public void ThrowHeldItem(DatabaseThrowable dbRef)
	{
	}
}
