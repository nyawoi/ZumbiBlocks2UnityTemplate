using System;
using UnityEngine;

[Serializable]
public class EntityLocation
{
	public bool locationIsUnknown;

	public Vector3 pos3d;

	public TerrainFeature feature;

	public TerrainFeatureType debugType;

	public bool isOnBeach;

	public bool isIndoors;

	public IntVec2 indoorCell;

	public int indoorFloor;

	public void Clear()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
