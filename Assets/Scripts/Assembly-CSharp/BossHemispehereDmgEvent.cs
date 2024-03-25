using UnityEngine;

public class BossHemispehereDmgEvent : BossActionEvent
{
	public float dmg;

	public Vector3 refPos;

	public Vector3 dir;

	public float range;

	public float minDot;

	public override void RunEvent(Zombie targetZombie)
	{
	}

	private void TestDamage(DamageTarget target, float dmgAmount, Vector3 dmgPos, Vector3 vector, Vector3 localDir, float extrarange = 0f)
	{
	}
}
