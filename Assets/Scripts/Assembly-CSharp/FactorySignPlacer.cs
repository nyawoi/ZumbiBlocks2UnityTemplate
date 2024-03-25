public class FactorySignPlacer
{
	private BuildingGenerator generator;

	private bool foundPosition;

	private IntVec2 bestPosition;

	private int bestRotation;

	private int bestDistance;

	private int bestFloor;

	public FactorySignPlacer(BuildingGenerator generator)
	{
	}

	public (bool found, IntVec2 position, int rotation, int floor) FindSignPosition(IntVec2 entryPosition)
	{
		return default((bool, IntVec2, int, int));
	}

	private void IterateFloor(IntVec2 entryPosition, int floorIndex, int searchRange)
	{
	}

	private bool SignFits(IntVec2 basePos, int directionIndex, int floorIndex)
	{
		return false;
	}
}
