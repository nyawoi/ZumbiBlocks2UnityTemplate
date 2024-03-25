using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GridEdge : TerrainFeature
{
	public enum RoadType
	{
		None = 0,
		Alley = 1,
		SingleLane = 2
	}

	public RoadType roadType;

	public IntVec2 edgeStart;

	public IntVec2 edgeEnd;

	[NonSerialized]
	public List<Polygon> neigPolys;

	[NonSerialized]
	public Vector3[] node3d;

	[NonSerialized]
	public Vector3 center;

	[NonSerialized]
	public Vector3 bakedLeft;

	[NonSerialized]
	public bool beachIsToTheLeft;

	public GridEdge(IntVec2 start, IntVec2 end, RoadType roadT = RoadType.None)
	{
	}

	public bool IsCoast()
	{
		return false;
	}

	public bool IntersectBeach(Vector3 pos3d)
	{
		return false;
	}

	public override TerrainFeatureType GetType()
	{
		return default(TerrainFeatureType);
	}

	public override GridNode GetNode()
	{
		return null;
	}

	public override GridEdge GetEdge()
	{
		return null;
	}

	public override Polygon GetPolygon()
	{
		return null;
	}
}
