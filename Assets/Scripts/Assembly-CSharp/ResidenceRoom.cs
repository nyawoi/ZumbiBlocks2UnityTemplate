using System.Collections.Generic;

public class ResidenceRoom
{
	public enum Type : byte
	{
		Corridor = 0,
		Bathroom = 1,
		Bedroom = 2,
		Kitchen = 3,
		LivingRoom = 4,
		PoliceReception = 5,
		PoliceArmory = 6,
		PoliceCells = 7,
		PoliceDetectives = 8,
		PoliceOffice = 9,
		PoliceArchives = 10,
		Cell = 11,
		PoliceCorridor = 12,
		PoliceBathroom = 13,
		FactoryCorridor = 14,
		Balcony = 15,
		StairWellEntry = 16,
		StairWell = 17,
		Downstairs = 18,
		DownstairEntry = 19,
		DefaultFactoryRoom = 20,
		CNCRoom = 21,
		Metalworks = 22,
		FactoryStorage = 23
	}

	public static readonly byte[] floorColorID;

	public byte id;

	public Type type;

	public IntVec2 bottomLeft;

	public IntVec2 topRight;

	public int outdoorTouchCount;

	public bool visited;

	public bool isSuiteBathroom;

	public bool isEdgeRoom;

	public bool originalFoundation;

	public List<ResidenceRoom> neighbourRooms;

	public List<IntVec2Couple> neigDoor;

	public List<IntVec2Couple> realDoors;

	public List<ResidenceRoom> navChild;

	public List<IntVec2Couple> childDoor;

	public List<IntVec2Couple> cellPositions;

	public CorridorGroup myCorridorGroup;

	public List<byte> accessedCorridorGroup;

	public bool IsLeafRoom => false;

	public int Area => 0;

	public IntVec2 Size => default(IntVec2);

	public bool IsThin()
	{
		return false;
	}

	public float Longness()
	{
		return 0f;
	}

	public bool IsInsideRoom(IntVec2 pos)
	{
		return false;
	}

	public ResidenceRoom(byte id_, IntVec2 pos)
	{
	}

	public ResidenceRoom(byte id_, bool foundation, Type t, IntVec2 bl, IntVec2 tr)
	{
	}

	public ResidenceRoom(byte id_)
	{
	}
}
