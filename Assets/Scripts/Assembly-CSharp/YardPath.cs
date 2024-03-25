using System.Collections.Generic;
using UnityEngine;

public class YardPath
{
	public enum TargetType
	{
		LocalTarget = 0,
		Doorway = 1,
		ObstacleAvoidance = 2
	}

	public List<Vector2> nodes;

	public BuildingGraph targetGraph;

	public TargetType targetType;

	public bool indoors;

	public int floorDirection;

	public void Clear()
	{
	}
}
