using UnityEngine;

public class FurnitureDamageCollider : MonoBehaviour, DamageTaker
{
	public InteractableFurniture targetFurniture;

	public DamageTarget GetTarget()
	{
		return null;
	}

	public float GetDamageMultiplier()
	{
		return 0f;
	}
}
