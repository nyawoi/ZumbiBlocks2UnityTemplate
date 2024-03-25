using System.Collections.Generic;
using UnityEngine;

public class Pathfinding : MonoBehaviour
{
	public static Pathfinding instance;

	[Header("Submodules")]
	public YardPathfinding yardPathing;

	public BuildingPathfinding buildingPathing;

	private List<PathingNode> openNodes;

	private List<PathingNode> closedNodes;

	private List<PathingNode> path;

	[Header("Debug")]
	public bool debugPath;

	public int debugPathStartNode;

	public int debugPathEndNode;

	public bool ignoreWeight;

	[Header("Debug res")]
	public float resTime;

	public float debugWeight;

	public void Init()
	{
	}

	private void Update()
	{
	}

	private void FindDebugPath()
	{
	}

	public void PushOpenNode(PathingNode node)
	{
	}

	public List<PathingNode> TraceBackPath(PathingNode lastNode)
	{
		return null;
	}

	public void PathingCleanUp()
	{
	}

	private int FindBestNode()
	{
		return 0;
	}

	public List<PathingNode> FindPath(TerrainFeatureNode node1, TerrainFeatureNode node2)
	{
		return null;
	}

	public List<PathingNode> FindPathByFlood(TerrainFeatureNode node1, TerrainFeatureNode node2)
	{
		return null;
	}
}
