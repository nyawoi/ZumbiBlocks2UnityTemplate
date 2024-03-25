using System.Collections.Generic;
using UnityEngine;

public class BuildingPathfinding : MonoBehaviour
{
	private class PathingNode
	{
		public IntVec2 pos;

		public PathingNode parent;

		public PathingNode(IntVec2 p, PathingNode par)
		{
		}
	}

	[Header("Grid")]
	public int stdGridSize;

	public int gridW;

	public int gridH;

	public byte gridBlockedCellValue;

	public bool gridIsDirty;

	private byte[,] grid;

	private List<PathingNode> openNodes;

	[Header("Debug")]
	public bool drawSearchTree;

	public void Init()
	{
	}

	public void ResizeGridIfNecessary(IntVec2 targetSize)
	{
	}

	private void ReallocGrid()
	{
	}

	public void ClearGrid()
	{
	}

	public void PrepareGridForPathfinding(IntVec2 buildSize)
	{
	}

	private void OpenNode(IntVec2 cell, PathingNode parent, bool blockCell = true)
	{
	}

	private void BuildPathThroughBackTracking(PathingNode lastNode, YardPath targetPath, BuildingBlueprint building)
	{
	}

	public void IndoorPathing(IntVec2 startCell, IntVec2 endCell, int floorIndex, BuildingBlueprint building, YardPath targetPath, bool considerWindows, bool lookingForExit = false)
	{
	}
}
