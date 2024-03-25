using System;
using UnityEngine;

[Serializable]
public struct Line3D
{
	public Vector3 p1;

	public Vector3 p2;

	public Line3D(Vector3 p1_, Vector3 p2_)
	{
		p1 = p1_;
		p2 = p2_;
	}

	public Vector3 RandomPoint()
	{
		return default(Vector3);
	}
}
