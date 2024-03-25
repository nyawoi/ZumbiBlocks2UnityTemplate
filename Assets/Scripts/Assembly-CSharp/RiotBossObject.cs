using UnityEngine;

public class RiotBossObject : CustomZombieObject
{
	[Header("Props")]
	public Transform flashBang;

	public Transform flashBang2;

	public Transform shotgun;

	public Transform shield;

	[Header("Pivot")]
	public Transform shieldBackPivot;

	public Transform shieldHandPivot;

	public Transform shotgunBackPivot;

	public Transform shotgunHandPivot;

	[Header("Gun")]
	public PhysicalGun gun;

	public Animator gunAnimator;

	public LayerMask shotMask;

	public DatabaseGun customDBGun;

	public AudioPlayer gunAudioPlayer;

	public Transform gunBulletOrigin;

	public override void TreatPropState(int v)
	{
	}

	public override void EjectCasing()
	{
	}

	public override void ShootGun(Vector3? dir = null)
	{
	}

	public override void AnimateProp(string str)
	{
	}
}
