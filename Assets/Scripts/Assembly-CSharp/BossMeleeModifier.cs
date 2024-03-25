using UnityEngine;

public class BossMeleeModifier : BossActionModifier
{
	[Header("Melee")]
	public int pivotIndex;

	public AnimationCurve meleeCurve;

	public Vector3 direction;

	public float meleeDistance;

	public float rayRadius;

	public LayerMask layerMask;

	public float dmg;

	public override void RunEvent(Zombie targetZombie, float time)
	{
	}
}
