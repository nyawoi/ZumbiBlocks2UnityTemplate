using UnityEngine;

public class PhysicsController : MonoBehaviour
{
	public static PhysicsController instance;

	[SerializeField]
	private PhysicsRateAdapter physicsRate;

	[SerializeField]
	private ZombieLimbsPhysicsController zombieLimbs;

	public void Initiailize()
	{
	}

	public void Update()
	{
	}
}
