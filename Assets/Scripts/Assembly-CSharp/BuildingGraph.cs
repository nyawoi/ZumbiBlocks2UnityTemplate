using System.Collections.Generic;
using UnityEngine;

public class BuildingGraph
{
	public class Node
	{
		public Vector2 point;

		public IntVec2? door;

		public bool isWindow;

		public Node(Vector2 p, IntVec2? d, bool w)
		{
		}
	}

	public static readonly float inwardPointmultiplier;

	public static readonly float outwardPointmultiplier;

	public Polygon targetPolygon;

	public List<Node> nodes;

	public List<Line2D> collisionLines;

	public BuildingGraph(Polygon poly)
	{
	}

	public Vector2? IntersectLineClosest(Line2D line)
	{
		return null;
	}

	public int FindIndexClosestTo(Vector2 p)
	{
		return 0;
	}
}
