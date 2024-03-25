using System.Collections.Generic;
using UnityEngine;

public class MapGraph : MonoBehaviour
{
	public static MapGraph instance;

	public List<TerrainFeatureNode> nodes;

	public List<BuildingGraph> buildingGraphs;

	private byte[,] buildGraphGrid;

	private IntVec2 buildGraphGridSize;

	[Header("Count")]
	public int nodeCount;

	public int neigCount;

	[Header("Debug")]
	public bool drawGraph;

	public bool drawBuildingGraph;

	public int debugNeigs;

	public void Init()
	{
	}

	public void CleanUp()
	{
	}

	public void BakeBuildingGraphs()
	{
	}

	private void CreateBuildingCollisionLines(BuildingGraph bGraph)
	{
	}

	private void CreateBuildingGraph(BuildingGraph bGraph)
	{
	}

	private void FindNextGraphNode(IntVec2 pos, out IntVec2? nextPos)
	{
		nextPos = null;
	}

	private bool IsInsideBuildingGraphGrid(IntVec2 pos)
	{
		return false;
	}

	public void BakeGraph()
	{
	}

	private void InsertFeatures()
	{
	}

	private void BakeNeighbourhood()
	{
	}

	private void Count()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
