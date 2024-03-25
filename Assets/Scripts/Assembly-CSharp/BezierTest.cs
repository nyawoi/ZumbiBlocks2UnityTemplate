using System.Collections.Generic;
using UnityEngine;

public class BezierTest : MonoBehaviour
{
	public const float sqrt2Over2 = 0.70710677f;

	public List<Vector3> bezier;

	public float maxDist;

	public Vector3 launcherVector;

	[Range(-90f, 90f)]
	public float launchAngle;

	public Vector3 EvalBezier(List<Vector3> bezier, float t)
	{
		return default(Vector3);
	}

	public Vector3 LerpUnclamped(Vector3 v1, Vector3 v2, float t)
	{
		return default(Vector3);
	}

	public void OnDrawGizmos()
	{
	}
}
