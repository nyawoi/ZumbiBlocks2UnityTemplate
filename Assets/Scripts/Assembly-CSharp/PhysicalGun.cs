using System;
using UnityEngine;

public class PhysicalGun : MonoBehaviour
{
	[Serializable]
	public struct MuzzleLight
	{
		public DatabaseGun.GunClass gunClass;

		public float intensity;

		public Color color;

		public float range;
	}

	public enum TriggerState
	{
		Released = 0,
		Cocked = 1,
		DroppedHammer = 2
	}

	[Header("Settings")]
	public EquippedProp prop;

	public Transform barrel;

	public CustomGunBehaviour customBehaviour;

	[Header("ADS")]
	public Transform sightPivot;

	public float eyeRelief;

	public float eyeReliefShotExtra;

	public float zoomLevel;

	[Header("Ejection")]
	public Transform ejectorPort;

	public FXProp.ID casingID;

	public bool autoEjectCasing;

	[Header("Muzzle stuff")]
	public FXProp.ID muzzleSmokeID;

	public FXProp.ID muzzleFlashID;

	public string shootAnimation;

	public bool hasADSShot;

	public GunAnimationController gunPropAnim;

	[Header("Melee")]
	public bool hasCustomMelee;

	public PlayerMeleeAttack.ID customMeleeID;

	public float meleeRange;

	[Header("Audio")]
	public AudioPack audioPack;

	public AudioPack dryFirePack;

	[Header("Runtime")]
	public float cdTimer;

	[HideInInspector]
	public DatabaseGun dbRef;

	public int bufferedBurst;

	public TriggerState triggerState;

	public void SetTriggerPull(bool press)
	{
	}

	public void Shoot(PlayerMain playerShooter, int layerMask, Vector3 bulletOrigin, Vector3 tracerOrigin, Vector3 convergingOrigin, Vector3 convergingDirection, bool shootForEffect, DatabaseGun customDbGun = null)
	{
	}

	private void SpawnMuzzleFlashAndSmoke(PlayerMain playerShooter)
	{
	}

	private void ShootSingleProjectile(PlayerMain playerShooter, int layerMask, Vector3 bulletOrigin, Vector3 tracerOrigin, Vector3 convergingOrigin, Vector3 convergingDirection, bool shootForEffect, bool bossShot, bool spawnParticle)
	{
	}

	private Vector3 GetShotDirectionWithSpread(Vector3 convergingDirection)
	{
		return default(Vector3);
	}

	private void SetShotDamage(PlayerMain playerShooter, bool bossShot, Shot shot)
	{
	}

	public void EjectCasing()
	{
	}

	public void EjectCasing(FXProp.ID propID)
	{
	}

	public bool IsCoolingDown()
	{
		return false;
	}

	public void ResetCooldown(bool resetTrigger)
	{
	}

	public void Update_()
	{
	}

	public void SetTriggerState(TriggerState s)
	{
	}

	public void Init()
	{
	}

	public void ResetProp()
	{
	}

	public void PlayGunShotAt(AudioPlayer audioPlayer, DatabaseGun customDbGun = null)
	{
	}
}
