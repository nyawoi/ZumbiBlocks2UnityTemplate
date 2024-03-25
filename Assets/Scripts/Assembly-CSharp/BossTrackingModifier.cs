using UnityEngine;

public class BossTrackingModifier : BossActionModifier
{
	public AnimationCurve trackSpeed;

	public float speedMulti;

	public override void RunEvent(Zombie targetZombie, float time)
	{
	}
}
