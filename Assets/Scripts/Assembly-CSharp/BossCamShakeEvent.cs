using UnityEngine;

public class BossCamShakeEvent : BossActionEvent
{
	public float range;

	public AnimationCurve curve;

	public float amplitude;

	public float duration;

	public float freq;

	public override void RunEvent(Zombie targetZombie)
	{
	}
}
