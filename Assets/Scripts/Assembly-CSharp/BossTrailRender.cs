using UnityEngine;

public class BossTrailRender : BossActionModifier
{
	[Header("Trail")]
	public AnimationCurve renderCurve;

	public int index;

	public override void RunEvent(Zombie targetZombie, float time)
	{
	}
}
