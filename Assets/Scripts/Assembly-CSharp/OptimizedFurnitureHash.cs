using System.Collections.Generic;
using UnityEngine;

public class OptimizedFurnitureHash : MonoBehaviour
{
	public class Cell
	{
		public IntVec2 coord;

		public List<InteractableFurniture> furnitures;

		public Cell(int x, int y)
		{
		}
	}

	public static OptimizedFurnitureHash instance;

	[Header("Optmized Hash")]
	public float preferredCellSize;

	public float furniMaxRadius;

	[Header("Runtime")]
	public float cellSize;

	public int width;

	public int height;

	public Cell[,] cells;

	public void Init()
	{
	}

	public void CleanUp()
	{
	}

	public void CreateHash(float extX, float extZ)
	{
	}

	public List<InteractableFurniture> GetFurniture(Vector3 pos)
	{
		return null;
	}

	public void AddFurniture(InteractableFurniture furni)
	{
	}

	private IntVec2 GetCoordinate(Vector3 pos)
	{
		return default(IntVec2);
	}

	private Vector3 GetCellStart(int x, int y)
	{
		return default(Vector3);
	}

	private bool WithinBounds(int x, int y)
	{
		return false;
	}
}
