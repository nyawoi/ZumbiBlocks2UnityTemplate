using System;
using System.Collections.Generic;
using UnityEngine;

public class Polygon : TerrainFeature
{
	public enum ContentType : byte
	{
		Park = 0,
		Residence = 1,
		PoliceDepartment = 2,
		Factory = 3
	}

	public struct VegetationInstance
	{
		public FurnitureDatabase.VegType vegType;

		public Vector3 pos;

		public byte angle;
	}

	[NonSerialized]
	[HideInInspector]
	public List<IntVec2> nodes;

	[NonSerialized]
	public Vector3[] node3d;

	public ContentType contentType;

	public List<Triangle> bakedTriangles;

	public byte fenceColor;

	public FenceType fenceType;

	public FenceMode[] fencing;

	[HideInInspector]
	public BuildingBlueprint building;

	public BuildingGraph buildingGraph;

	public List<VegetationInstance> vegetation;

	public List<LODTarget> vegetationObj;

	public List<Furniture> allInteractableFurniture;

	[HideInInspector]
	public List<Polygon> neigPoly;

	public Vector3 center;

	public float minH;

	public float maxH;

	public IntVec2 min;

	public IntVec2 max;

	public IntVec2 size;

	public Vector3 min3d;

	public Vector3 max3d;

	public Vector3 size3d;

	public float area;

	public float auxValue;

	public int group;

	public bool furnitureRendering;

	public bool furnitureRenderingInside;

	public bool HasBuilding => false;

	public void CalculateArea()
	{
	}

	public void CalculateBounds()
	{
	}

	public void CalculateBounds3D()
	{
	}

	public void CalcMinMax()
	{
	}

	public Vector3 FindCenter()
	{
		return default(Vector3);
	}

	public Vector2 FindCenterGrid()
	{
		return default(Vector2);
	}

	public float SampleHeight(float px, float pz)
	{
		return 0f;
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
