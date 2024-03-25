using UnityEngine;

public class LightOverTime : MonoBehaviour
{
	public Light lSource;

	public AnimationCurve curve;

	public float intensity;

	public float duration;

	[Header("Runtime")]
	public float timer;

	public void Update()
	{
	}
}
