using UnityEngine;

public class MapConstructor : MonoBehaviour
{
	public enum TextureID : byte
	{
		DarkDirt = 8,
		Dirt = 9,
		DarkSand = 10,
		Sand = 11,
		Asphalt = 12,
		Concrete = 13,
		DarkConcrete = 14,
		Grass = 15
	}

	public static MapConstructor instance;

	[Header("References")]
	public MapGeneration mapGen;

	public GameObject terrainMeshPrefab;

	[Header("Settings")]
	public float sidewalkProportion;

	public float sidewalkHeight;

	[Header("Runtime")]
	public Transform meshHolder;

	public GenericMeshGenerator curMeshGen;

	public void Init()
	{
	}

	public void CleanUp()
	{
	}

	public void InstantiateTerrainMesh(HashCell cell)
	{
	}

	public void GenerateHashCellMesh(HashCell cell)
	{
	}

	public void GeneratePolygonMesh(Polygon poly)
	{
	}

	public void BakeTriangleMesh(Polygon poly)
	{
	}

	private Vector3 GetPositionFor(Polygon poly, IntVec2 v1)
	{
		return default(Vector3);
	}

	public Triangle GetTriangleFromGrid(Polygon poly, IntVec2 v1, IntVec2 v2, IntVec2 v3)
	{
		return null;
	}

	private byte GetGroundTexture(Polygon poly)
	{
		return 0;
	}

	private void GenerateEdgeRoadMesh(GridEdge edge)
	{
	}

	private void ConstructBeach(GridEdge edge)
	{
	}

	private void ConstructRoadCorner(GridNode node)
	{
	}

	private void MakeSidewalkCorner(Vector3 curPoint, Vector3 prevPoint, Vector3 nextPoint)
	{
	}
}
