using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
	private const float raycastExtension = 1.1f;

	public const float MaxShotDuration = 0.5f;

	[Header("Settings")]
	public TrailRenderer trail;

	public float speed;

	[Header("Settings")]
	public int mask;

	public bool isFriendly;

	public Damage curDamage;

	public float headShotMulti;

	public float pierceAcc;

	[Header("Runtime")]
	public float effectiveSpeed;

	public float timer;

	public bool shootForEffect;

	public bool spawnParticle;

	public int hitCount;

	public List<Transform> alreadyHitTransform;

	public List<DamageTarget> alreadyHitTarget;

	public bool hitWater;

	[Header("Convergence")]
	public float tracerConvergingSpeed;

	private Vector3 bulletPosition;

	private Vector3 convergingOrigin;

	private Vector3 convergingDirection;

	private Vector3 tracerDirection;

	private bool bulletConverged;

	private float tracerConvergenceTimer;

	public void Reset()
	{
	}

	public static FXProp.ID GetBloodID(float dmg)
	{
		return default(FXProp.ID);
	}

	public void SetupFirstStep(bool friendly, Damage dmg)
	{
	}

	public void SetupCoordinates(Vector3 bulletOrigin, Vector3 convergingOrigin, Vector3 convergingDirection)
	{
	}

	public void SetupFinalStep(int mask_, float headShotMulti, float pierceAmount)
	{
	}

	private List<RaycastHit> GetHitList(Vector3 p1, Vector3 p2)
	{
		return null;
	}

	private void TestHit(Vector3 p1, Vector3 p2)
	{
	}

	public void Update()
	{
	}

	private void ConvergeTracer(Vector3 nextPosition)
	{
	}

	private void ProcessWaterHit()
	{
	}

	private void TryEndShotByTimer()
	{
	}
}
