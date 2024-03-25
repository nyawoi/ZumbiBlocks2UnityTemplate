using UnityEngine;

public class FOVController : MonoBehaviour
{
	public Camera cam;

	public float baseNear;

	public float minNear;

	public float baseFOV;

	[Header("Zoom Settings")]
	public float maxZoom;

	public float minZoom;

	public float lerpSpeed;

	[Header("State")]
	public float curZoom;

	private void Update()
	{
	}

	private float GetCurrentZoom(PlayerMain player)
	{
		return 0f;
	}
}
