using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GridNode : TerrainFeature
{
	public IntVec2 gridPos;

	public bool isInPolygon;

	public bool isBeach;

	public bool trimmed;

	public Vector3 pos3d;

	public int distanceFromBeach;

	[NonSerialized]
	public bool hasRoad;

	[NonSerialized]
	public List<IntVec2> neigNodes;

	[NonSerialized]
	public List<Polygon> neigPolys;

	[NonSerialized]
	public List<GridEdge> neigRoads;

	[NonSerialized]
	public List<NodeAndAngle> roadPoints;

	[NonSerialized]
	public List<Vector3> beachPoints;

	public GridEdge FindNeigRoad(IntVec2 v1, IntVec2 v2)
	{
		return null;
	}

	public void AddNeigNode(IntVec2 v)
	{
	}

	public void AddRoadPoint(Vector3 p)
	{
	}

	public bool HasSize()
	{
		return false;
	}

	public Vector3 GetCenter()
	{
		return default(Vector3);
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
