using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SmoothedVector3
{
	public List<Vector3> list;

	public int smoothness;

	public SmoothedVector3(int smoothness)
	{
	}

	public void AddValue(Vector3 val)
	{
	}

	public float GetFullDistance()
	{
		return 0f;
	}

	public Vector3 GetAvgValue()
	{
		return default(Vector3);
	}

	internal void Clear()
	{
	}
}
