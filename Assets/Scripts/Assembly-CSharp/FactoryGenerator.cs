using System.Collections.Generic;

public class FactoryGenerator : BuildingGenerator
{
	private List<ResidenceRoom> originalFoundations;

	private List<ResidenceRoom> replaceRooms;

	private int deleteFoundationRoomID;

	private IntVec2Couple entryDoorCandidate;

	private int entryDoorDistance;

	private int entryDoorIDEval;

	public override bool GeneratePolygonContent(Polygon polygon)
	{
		return false;
	}

	private void JoinStairwellsAndEntries()
	{
	}

	private void GenerateAllFurniture(Polygon polygon)
	{
	}

	private void AddEntrySign(BuildingBlueprint building)
	{
	}

	private void PrintAllRoomsIds(Floor floor, string msg)
	{
	}

	private void PreProcessRoomsForStairWellPlacement()
	{
	}

	private void AddReplacementRoom(ResidenceRoom targetRoom)
	{
	}

	private void AddUpStairwell(int floorIndex)
	{
	}

	protected void GenerateRoomTypesByFloor(int floorIndex)
	{
	}

	private static void GenerateOtherRooms(Floor thisFloor, bool isGround)
	{
	}

	private static void GenerateBalconies(Floor thisFloor, bool isGround, bool isRooftop)
	{
	}

	protected override void FindEntryRoom()
	{
	}

	public override bool IsTooBig(ResidenceRoom room)
	{
		return false;
	}

	public override bool IsTooSmall(ResidenceRoom room)
	{
		return false;
	}

	protected override void AddEntryDoor()
	{
	}

	private void TrySelectEntryDoor(IntVec2 p1, IntVec2 p2)
	{
	}

	private void SetEntryDoor(IntVec2 p1, IntVec2 p2, byte id, int distance)
	{
	}
}
