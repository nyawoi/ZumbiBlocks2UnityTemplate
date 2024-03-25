using System;
using System.Collections.Generic;

[Serializable]
public class SmoothedFloat
{
	public List<float> list;

	public int smoothness;

	public SmoothedFloat(int smoothness)
	{
	}

	public void AddValue(float val)
	{
	}

	public float MinMaxAvg()
	{
		return 0f;
	}

	public float GetAvgValue()
	{
		return 0f;
	}

	internal void Clear()
	{
	}
}
