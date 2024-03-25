using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MapHash : MonoBehaviour
{
	public static MapHash instance;

	[Header("Settings")]
	public float defaultCellSize;

	public float cellSize;

	[Header("Generation settings")]
	public bool genTerrainMesh;

	public bool genBuildingMesh;

	[Header("Runtime")]
	public int width;

	public int height;

	private HashCell[,] cells;

	public bool hashGenerated;

	[Header("Debug")]
	public bool drawCells;

	public bool drawCellsCollision;

	public bool drawCellsGen;

	public bool isCreated => false;

	public void CleanUp()
	{
	}

	public void BakeCellData()
	{
	}

	public void Init()
	{
	}

	public void AllocateCells()
	{
	}

	public void CreateHash(float extX, float extZ, List<Polygon> allPolys, List<GridEdge> allEdges, MapGeneration mapGen)
	{
	}

	public void GenCell(HashCell cell)
	{
	}

	public void OnDrawGizmos()
	{
	}

	public bool IsHashSyncing()
	{
		return false;
	}

	public void DumpHashDebugLog()
	{
	}

	public void DumpHasContent()
	{
	}

	public Vector2 GetCellCenter(IntVec2 v)
	{
		return default(Vector2);
	}

	public HashCell GetCell(IntVec2 v)
	{
		return null;
	}

	public HashCell GetCell(int x, int y)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool ContainsCell(IntVec2 v)
	{
		return false;
	}

	public HashCell GetCell(Vector3 pos)
	{
		return null;
	}

	public HashCell GetCellNotEmpty(Vector3 pos)
	{
		return null;
	}

	public IntVec2 GetHashCoord(Vector3 pos)
	{
		return default(IntVec2);
	}

	public IntVec2 GetHashCoord(Vector2 pos)
	{
		return default(IntVec2);
	}
}
