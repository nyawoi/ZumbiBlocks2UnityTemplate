using UnityEngine;

public class PhysicsRateAdapter : MonoBehaviour
{
	[SerializeField]
	private bool useFixedTimeAdapting;

	[SerializeField]
	private float maximumPhysicsRate;

	[SerializeField]
	private float minimumPhysicsRate;

	[SerializeField]
	private float minimumZombies;

	[SerializeField]
	private float maximumZombies;

	[SerializeField]
	private AnimationCurve curve;

	[SerializeField]
	private float updateFrequency;

	private float updateTimer;

	public void UpdateRate()
	{
	}

	private void AdaptRate()
	{
	}
}
