using UnityEngine;

public class LaserController : MonoBehaviour
{
	[Header("Settings")]
	public ParticleSystem particles;

	public GameObject hitEffect;

	public float emmisionMultiplier;

	public float scaleDivider;

	public float scaleSpeed;

	public LayerMask raycastmask;

	[Header("Runtime")]
	public float curLength;

	public float targetLength;

	[HideInInspector]
	public Vector3? lastHitPoint;

	[HideInInspector]
	public Vector3? curHitPoint;

	public void Start()
	{
	}

	public void ResetLaser()
	{
	}

	public void UpdateLaser(bool reset = false)
	{
	}
}
