using UnityEngine;

public class BossLaserModifier : BossActionModifier
{
	[Header("Laser")]
	public AnimationCurve laserCurve;

	public int index;

	public float laserDistance;

	public float laserRadius;

	public float dmg;

	public override void RunEvent(Zombie targetZombie, float time)
	{
	}
}
