using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class BuildingGenerator : PolygonContentGenerator
{
	[Serializable]
	public class Floor
	{
		[Serializable]
		public class StairWellSettings
		{
			public ResidenceRoom stairRoom;

			public ResidenceRoom entryRoom;

			public ResidenceRoom downstairRoom;

			public ResidenceRoom downstairentryRoom;

			public int corner;

			public int sourceFoundationID;

			public IntVec2 stairDirection;

			public IntVec2 entryCell;
		}

		public byte curGroup;

		public List<ResidenceRoom> rooms;

		public List<Furniture.WallInstance> doors;

		public List<Furniture.WallInstance> windows;

		public List<Furniture.Instance> furniture;

		public StairWellSettings stairwell;

		public void AddRoom(ResidenceRoom room)
		{
		}

		public void RemoveRoom(byte id)
		{
		}
	}

	public Floor[] floor;

	public int floorCount;

	private List<IntVec2> neigNodes;

	private List<ResidenceRoom> openRooms;

	private List<CorridorGroup> corridorGroups;

	private byte corridorGroupIDpool;

	public List<byte> possibleNeigIDs;

	public List<IntVec2Couple> neighPossibleDoor;

	protected IntVec2? closestPointToGate;

	protected byte entryRoomID;

	protected List<ResidenceRoom> largerRooms;

	public Vector3 entryRoomCenter;

	public Floor GroundFloor => null;

	public bool HasDoor(IntVec2 pos, int floorIndex)
	{
		return false;
	}

	public bool HasWindow(IntVec2 pos, int floorIndex)
	{
		return false;
	}

	public bool HasWallFurniture(List<Furniture.WallInstance> wallFurni, IntVec2 pos, int floorIndex)
	{
		return false;
	}

	protected BuildingBlueprint AllocateBlueprint(Polygon poly, int floorC)
	{
		return null;
	}

	protected ResidenceRoom GetRoomByID(int floorIndex, byte ID)
	{
		return null;
	}

	protected void ConvertCorridors(ResidenceRoom.Type targetCorridor)
	{
	}

	private float FindBaseHeight(BuildingBlueprint building)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private float GetMaxHeight(BuildingBlueprint building, float h, int x, int y)
	{
		return 0f;
	}

	protected void FinalizeBuilding(BuildingBlueprint building)
	{
	}

	public void AbortGeneration(Polygon poly)
	{
	}

	protected void FindGatePoint()
	{
	}

	protected void GenerateNavigationStructure(int floorIndex)
	{
	}

	private void FindRoomNeighbours(int floorIndex, ResidenceRoom room)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void AddNeighID(ResidenceRoom room, byte id, IntVec2 outPoint, IntVec2 inPoint)
	{
	}

	private bool TryExpandRoom(int floorIndex, int maxExpandAttempts, ResidenceRoom room, int minArea)
	{
		return false;
	}

	protected ResidenceRoom GenerateOneBaseRoom(byte roomGroup, IntVec2 startCell, int minArea, int maxArea, int minRoomWidth)
	{
		return null;
	}

	protected void FindRoomNeigNodes(ResidenceRoom curRoom)
	{
	}

	protected bool GenerateTwoBaseRooms(int minArea, int maxArea, int minRoomWidth)
	{
		return false;
	}

	protected void CreateFoundationRooms(Polygon poly, int minArea, int maxArea, int minRoomWidth)
	{
	}

	protected void ClearFurniture()
	{
	}

	private byte GetFloorColor(ResidenceRoom.Type t)
	{
		return 0;
	}

	protected ResidenceRoom SplitRoom(ResidenceRoom room, int floorIndex, RoomCutSide roomCutSide, int cutAmount)
	{
		return null;
	}

	protected ResidenceRoom SplitRoom(ResidenceRoom room, int floorIndex, bool cutHorizontal, bool invertDirection, int cutPos)
	{
		return null;
	}

	private bool CanBreakdown(ResidenceRoom.Type t)
	{
		return false;
	}

	protected void BreakdownRooms(int bigRoomCount, int floorIndex)
	{
	}

	public static void ValidateRoomSize(ResidenceRoom room, string roomName)
	{
	}

	protected void PaintAllRoomIds(int floorIndex)
	{
	}

	protected void PaintRoomIDs(int floorIndex, ResidenceRoom room, byte id)
	{
	}

	protected void PaintSpecialRooms(int floorIndex)
	{
	}

	protected void UpdateFloorCurGroup(Floor floor)
	{
	}

	protected void DebugRepeatedIDRooms()
	{
	}

	private void GroupCorridors(int floorIndex)
	{
	}

	protected void AddDoors(int floorIndex, Furniture.ID doorID)
	{
	}

	private void VerifyIfAllDoorsExist(int floorIndex)
	{
	}

	public int EvaluateID(byte id)
	{
		return 0;
	}

	public override void AddWindow(Furniture.ID windowID, IntVec2 p1, IntVec2 p2, int floorIndex)
	{
	}

	protected void DrawGrid(int floorIndex)
	{
	}

	protected void DrawCorridorGroups(int floorIndex)
	{
	}

	protected void DrawRoomTypes(int floorIndex)
	{
	}

	protected void DrawRoomTypes(int floorIndex, Vector3 offset)
	{
	}

	protected void DrawRoomIsFoundation(int floorIndex, Vector3 offset)
	{
	}

	protected void DrawGridX(int x, int y, Color c)
	{
	}

	protected void DrawGridX(int x, int y, Color c, Vector3 offset)
	{
	}

	protected void DrawAllRooms(int floorIndex)
	{
	}

	protected void DrawAllRooms(int floorIndex, Vector3 offset)
	{
	}

	protected Vector3 GetRoomCenter(ResidenceRoom room)
	{
		return default(Vector3);
	}

	protected void DrawNeighbourHood(int floorIndex)
	{
	}

	protected void DrawNavTree(int floorIndex)
	{
	}

	protected void DrawNavTree(int floorIndex, Vector3 offset)
	{
	}

	protected void DrawDoors(int floorIndex)
	{
	}

	public abstract bool IsTooSmall(ResidenceRoom room);

	public abstract bool IsTooBig(ResidenceRoom room);

	protected virtual void FindEntryRoom()
	{
	}

	protected virtual void GenerateRoomTypes()
	{
	}

	protected virtual void AddEntryDoor()
	{
	}
}
