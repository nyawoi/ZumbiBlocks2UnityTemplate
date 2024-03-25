using UnityEngine;

public class EntityLocator : MonoBehaviour
{
	public static EntityLocator instance;

	public bool scanNeighbourCells;

	public void Init()
	{
	}

	public void UpdateLocations()
	{
	}

	public void UpdateLocation(EntityLocation location, Vector3 realPos, bool forceRecalc = true)
	{
	}

	private void UpdateIndoorLocationData(EntityLocation location)
	{
	}

	private void UpdateLocationByNeighbours(EntityLocation location)
	{
	}

	private void RecalculateLocation(EntityLocation location)
	{
	}

	private TerrainFeature FindCellFeature(EntityLocation location, HashCell cell)
	{
		return null;
	}
}
