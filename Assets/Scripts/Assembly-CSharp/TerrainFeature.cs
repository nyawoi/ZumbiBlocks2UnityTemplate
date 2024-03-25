using System;

public abstract class TerrainFeature
{
	[NonSerialized]
	public TerrainFeatureNode graphNode;

	public new abstract TerrainFeatureType GetType();

	public abstract GridNode GetNode();

	public abstract GridEdge GetEdge();

	public abstract Polygon GetPolygon();
}
