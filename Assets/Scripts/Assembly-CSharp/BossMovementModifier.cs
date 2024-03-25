using UnityEngine;

public class BossMovementModifier : BossActionModifier
{
	public AnimationCurve zSpeed;

	public bool isStrafe;

	public float speedMulti;

	public float transitionSpeed;

	public override void RunEvent(Zombie targetZombie, float time)
	{
	}
}
