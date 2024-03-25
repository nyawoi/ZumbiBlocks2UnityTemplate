using System.Collections.Generic;
using UnityEngine;

public class ZombieLimbsPhysicsController : MonoBehaviour
{
	private const float ExtraShotDuration = 0.03f;

	private const int ExtraFrameDuration = 2;

	private const float CloseDistanceToCollide = 2.5f;

	public static ZombieLimbsPhysicsController instance;

	[SerializeField]
	private List<ZombieLimbColliders> limbs;

	public void Initialize()
	{
	}

	public void UpdateTimers()
	{
	}

	public void OnLimbsSpawned(ZombieLimbColliders zombie)
	{
	}

	public void OnLimbsDespawned(ZombieLimbColliders zombie)
	{
	}

	public void OnPlayerShot(Vector3 origin, Vector3 direction, float shotDuration, float shotSpeed)
	{
	}

	private bool ZombieShotIntersection(Vector2 shotOrigin, Vector2 shotEnd, Vector2 zombiePosition, float radius, out float tFactor)
	{
		tFactor = default(float);
		return false;
	}

	public static void LimbsSpawned(ZombieLimbColliders zombie)
	{
	}

	public static void LimbsDespawned(ZombieLimbColliders zombie)
	{
	}

	public static void PlayerShot(Vector3 origin, Vector3 direction, float shotDuration, float shotSpeed)
	{
	}
}
