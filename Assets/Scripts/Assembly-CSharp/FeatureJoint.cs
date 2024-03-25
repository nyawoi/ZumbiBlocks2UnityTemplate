public class FeatureJoint
{
	public static Line3D JointLine(TerrainFeature feature1, TerrainFeature feature2)
	{
		return default(Line3D);
	}

	private static Line3D JointPolyFeature(Polygon p1, TerrainFeature f2)
	{
		return default(Line3D);
	}

	private static Line3D JointEdgeFeature(GridEdge e1, TerrainFeature f2)
	{
		return default(Line3D);
	}

	private static Line3D JointPolygonPolygon(Polygon p1, Polygon p2)
	{
		return default(Line3D);
	}

	private static Line3D JointPolygonEdge(Polygon p1, GridEdge e2)
	{
		return default(Line3D);
	}

	private static Line3D JointEdgeEdge(GridEdge e1, GridEdge e2)
	{
		return default(Line3D);
	}

	private static Line3D JointEdgeNode(GridEdge e1, GridNode n2)
	{
		return default(Line3D);
	}
}
