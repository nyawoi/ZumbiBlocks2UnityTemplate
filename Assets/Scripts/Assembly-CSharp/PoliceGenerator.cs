public class PoliceGenerator : BuildingGenerator
{
	private int entryDoorDistance;

	private IntVec2 bestEntryDoorP1;

	private IntVec2 bestEntryDoorP2;

	private int entryDoorDirection;

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

	private void GenerateExternalDecor(Polygon poly)
	{
	}

	private void AddFlags(Polygon poly)
	{
	}

	private void AddParkingSpots(Polygon poly)
	{
	}

	private void AddParkingSpots(Polygon poly, int x, int y, bool reverse)
	{
	}

	private bool HasOpenCells(IntVec2 pos, int w, int h, IntVec2 forward)
	{
		return false;
	}

	protected override void GenerateRoomTypes()
	{
	}

	private void FindCellRoom()
	{
	}

	private bool CanBeCells(IntVec2 size)
	{
		return false;
	}

	private void FindArmory()
	{
	}

	private void AddBathroomsAndOffices()
	{
	}

	private void AddDetectives()
	{
	}

	private void AddArchives()
	{
	}

	private void AddRoomsOfType(ResidenceRoom.Type t, int minSize, float ratio)
	{
	}

	private void GenerateCells()
	{
	}

	private IntVec2 GetCellsStart(ResidenceRoom room, int dir)
	{
		return default(IntVec2);
	}

	private int CalculateCellDirection(ResidenceRoom room)
	{
		return 0;
	}

	protected override void FindEntryRoom()
	{
	}

	private void SetEntryRoom(ResidenceRoom selectedRoom)
	{
	}

	public void TrySelectEntryDoor(IntVec2 p1, IntVec2 p2, int dir)
	{
	}

	protected override void AddEntryDoor()
	{
	}
}
