using UnityEngine;

public class ZombieLimbColliders : MonoBehaviour
{
	[SerializeField]
	public float intersectionDistance;

	[SerializeField]
	private Collider[] colliders;

	private bool active;

	private float activeTimer;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDrawGizmos()
	{
	}

	public void CountdownTimer()
	{
	}

	public void StartColliding(float time)
	{
	}

	private void SetColliding(bool active)
	{
	}
}
