using UnityEngine;

public abstract class BossActionModifier : MonoBehaviour
{
	[Header("Modifier")]
	public float eventStart;

	public float eventEnd;

	public abstract void RunEvent(Zombie targetZombie, float time);

	public void SphereCastDamage(Zombie targetZombie, Vector3 origin, float radius, Vector3 dir, float distance, int layerMask, float dmg)
	{
	}

	public void DealDamage(Zombie targetZombie, DamageTaker dmgTaker, Vector3 hitPoint, Vector3 dir, float dmg, float permanency = 0.5f)
	{
	}
}
