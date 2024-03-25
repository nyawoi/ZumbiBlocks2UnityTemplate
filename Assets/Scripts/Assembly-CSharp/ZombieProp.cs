using UnityEngine;

public class ZombieProp : MonoBehaviour
{
	[Header("Settings")]
	public Renderer render;

	[Header("Runtime")]
	public ZombieIdentity identity;

	public bool skipSpawnAnimation;

	public ZombieTransform Transform => default(ZombieTransform);

	public void SetZombie(ZombieIdentity identity, bool ssa)
	{
	}
}
