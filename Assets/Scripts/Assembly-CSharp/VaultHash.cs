using System.Collections.Generic;
using UnityEngine;

public class VaultHash : MonoBehaviour
{
	public class VaultSpot
	{
		public enum ID
		{
			Fence = 0,
			Window = 1
		}

		public ID id;

		public Vector3 p1;

		public Vector3 p2;

		public Line2D line;

		public GameObject destroyFurniture;

		public VaultSpot(ID id_, Vector3 v1, Vector3 v2, GameObject dFurniture)
		{
		}
	}

	public static VaultHash instance;

	public float preferredCellSize;

	public int width;

	public int height;

	public List<VaultSpot>[,] cells;

	public float cellSize;

	private IntVec2 GetCoordinate(Vector3 pos)
	{
		return default(IntVec2);
	}

	private bool WithinBounds(IntVec2 coord)
	{
		return false;
	}

	public VaultSpot IntersectCells(Vector3 pos, Vector3 dirVector, out Vector3 intersection, VaultSpot.ID? specificID = null)
	{
		intersection = default(Vector3);
		return null;
	}

	public void TryAddSpot(VaultSpot spot)
	{
	}

	public void CreateHash(float extX, float extZ)
	{
	}
}
