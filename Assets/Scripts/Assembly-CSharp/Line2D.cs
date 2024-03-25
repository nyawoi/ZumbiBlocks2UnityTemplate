using System;
using UnityEngine;

[Serializable]
public struct Line2D
{
	public Vector2 p1;

	public Vector2 p2;

	public Line2D(Vector2 p1_, Vector2 p2_)
	{
		p1 = p1_;
		p2 = p2_;
	}

	public Line2D(Line3D l3d)
	{
		p1 = l3d.p1;
		p2 = l3d.p2;
	}

	public Vector2 RandomPoint()
	{
		return default(Vector2);
	}
}
