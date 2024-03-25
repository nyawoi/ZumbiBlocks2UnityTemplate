using System.Collections.Generic;
using UnityEngine;

public class TerrainFeatureNode
{
	public TerrainFeature feature;

	public List<GraphNeighbour> neighbours;

	public bool passed;

	public TerrainFeatureNode(TerrainFeature f)
	{
	}

	public Vector3 GetCenter()
	{
		return default(Vector3);
	}
}
