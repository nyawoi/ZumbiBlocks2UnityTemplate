using UnityEngine;

public class ZombieDamageCollider : MonoBehaviour, DamageTaker
{
	public float dmgMultiplier;

	public ZombieObject targetObject;

	public DamageTarget GetTarget()
	{
		return null;
	}

	public float GetDamageMultiplier()
	{
		return 0f;
	}
}
