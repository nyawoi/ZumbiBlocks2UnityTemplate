using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class DynamicDepthOfField : MonoBehaviour
{
	public int curMode;

	public float[] aperture;

	public float[] focalLength;

	public PostProcessVolume volume;

	private void Update()
	{
	}
}
