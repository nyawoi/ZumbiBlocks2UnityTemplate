using System;
using UnityEngine;

[Serializable]
public struct ZombieTransform
{
	public Vector3 position;

	public float angle;

	public Quaternion Rotation => default(Quaternion);

	public ZombieTransform(Vector3 p, float ang)
	{
		position = p;
		angle = ang;
	}
}
