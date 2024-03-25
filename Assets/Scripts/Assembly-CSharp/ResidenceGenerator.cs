public class ResidenceGenerator : BuildingGenerator
{
	private int bedroomStock;

	private IntVec2Couple entryDoorCandidate;

	private int entryDoorDistance;

	private int entryDoorIDEval;

	public override bool GeneratePolygonContent(Polygon polygon)
	{
		return false;
	}

	public override bool IsTooSmall(ResidenceRoom room)
	{
		return false;
	}

	public override bool IsTooBig(ResidenceRoom room)
	{
		return false;
	}

	protected override void FindEntryRoom()
	{
	}

	protected override void GenerateRoomTypes()
	{
	}

	private void AddKitchenAndLivingRoom()
	{
	}

	private void DefineBedroomsAndBathrooms(ResidenceRoom curRoom)
	{
	}

	private void SetRoomType(ResidenceRoom curRoom, ResidenceRoom.Type t)
	{
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
