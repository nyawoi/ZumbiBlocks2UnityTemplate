using System.Collections.Generic;
using UnityEngine;

public class GlobalInteractionController : MonoBehaviour
{
	public class GICPolygon
	{
		public Polygon targetPolygon;

		public List<InteractableFurniture> interFurni;

		public GICPolygon(Polygon p)
		{
		}
	}

	public class GICCell
	{
		public HashCell targetCell;

		public IntVec2 coord;

		public List<GICPolygon> polys;

		public GICCell(HashCell hashCell)
		{
		}
	}

	public static GlobalInteractionController instance;

	public static GlobalInteractionController furnitureInteraction;

	public OptimizedFurnitureHash optFurnitureHash;

	public GICCell[,] cell;

	public int idPool;

	public int width;

	public int height;

	[Header("Runtime")]
	public List<InteractableFurniture> dynamicFurniture;

	public void Init()
	{
	}

	public void CleanUp()
	{
	}

	public int PullID()
	{
		return 0;
	}

	public void Allocate()
	{
	}

	public void OnCellGenerated(HashCell hashcell)
	{
	}

	public void UpdateDynamicFurniture()
	{
	}

	public void AddDynamicFurniture(InteractableFurniture interactableFurniture)
	{
	}

	public void RemoveDynamicFurniture(InteractableFurniture interactableFurniture)
	{
	}

	public void InteractedWith(InteractableFurniture interactableFurniture, byte forcedState = byte.MaxValue)
	{
	}

	public void InteractedWith(InteractableFurniture interactableFurniture, Vector3 pos, Vector3 moveDirection)
	{
	}

	private void InteractedWith(InteractableFurniture interactableFurniture, Vector3 pos, Vector3 moveDirection, byte targetState)
	{
	}

	public void OnFurnitureData(int cellX, int cellY, int id, byte state, byte health)
	{
	}

	public void OnFurnitureAudio(int cellX, int cellY, int id, byte index)
	{
	}

	public void OnSyncInteraction(int cellX, int cellY, int id, byte targetState)
	{
	}

	public void OnSyncFurniDamage(int cellX, int cellY, int id, float amount)
	{
	}

	public InteractableFurniture GetFurnitureFromCell(GICCell c, int id)
	{
		return null;
	}

	public InteractableFurniture GetFurniture(int cellX, int cellY, int id)
	{
		return null;
	}
}
