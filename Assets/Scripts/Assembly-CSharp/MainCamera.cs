using UnityEngine;

public class MainCamera : MonoBehaviour
{
	public static MainCamera instance;

	public float defaultFOV;

	public Camera cam;

	public DynamicDepthOfField dynDOF;

	public FOVController fovController;

	public void Init()
	{
	}

	public void DebugDrawCameraLine(float distance, Color color, float time)
	{
	}
}
