using UnityEngine;

public class BossSpherecastDmgModifier : BossActionModifier
{
	[Header("Spherecast")]
	public float dmg;

	public Vector3 origin;

	public Vector3 direction;

	public float radius;

	public float distance;

	public override void RunEvent(Zombie targetZombie, float time)
	{
	}
}
