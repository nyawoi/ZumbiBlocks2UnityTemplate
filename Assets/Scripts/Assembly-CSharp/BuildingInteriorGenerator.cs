using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BuildingInteriorGenerator : MonoBehaviour
{
	public class FurniturePosition
	{
		public IntVec2 pos;

		public int dir;

		public FurniturePosition(IntVec2 p, int d)
		{
		}
	}

	public static BuildingInteriorGenerator instance;

	private const int LOW = 0;

	private const int HIGH = 1;

	public IntVec2 cap;

	public IntVec2 curSize;

	public bool[,,] occupied;

	public List<(Vector2, int)> allLootSpawnPoints;

	public List<(Vector2, int)> fallBackSpawnPoints;

	public List<FurniturePosition> edgePositions;

	public List<FurniturePosition> edgeWholePositions;

	public List<FurniturePosition> cornerPositions;

	public System.Random rand;

	private BuildingGenerator targetGenerator;

	private List<Furniture.Instance> targetFurnitureList;

	private ResidenceRoom targetRoom;

	private Furniture.ID targetWindowID;

	private readonly List<ResidenceRoom.Type> forbiddenLootRoomTypes;

	private int returnOffset;

	public void Init()
	{
	}

	public void GenerateFurnitureForRoom(int floorIndex, ResidenceRoom room)
	{
	}

	private void AllocateForRoom(ResidenceRoom room)
	{
	}

	public void BlockDoorsForRoom(ResidenceRoom room)
	{
	}

	public void BlockDoorOrWindow(IntVec2 buildpos, IntVec2 dir)
	{
	}

	public void BlockWholeSquare(IntVec2 cellPos)
	{
	}

	public void GenerateFurnitureFor(BuildingGenerator targetGenerator_, int floorIndex, List<ResidenceRoom> rooms, List<Furniture.Instance> furnitureList, List<(Vector2, int)> lootSpawns, Furniture.ID windowID)
	{
	}

	public static IntVec2 RotatePositionAroundWholeCell(IntVec2 pos, int dir)
	{
		return default(IntVec2);
	}

	private bool FurnitureFits(Furniture furni, IntVec2 pos, int dir)
	{
		return false;
	}

	private bool FurnitureFits(IntVec2 size, bool occupylow, bool occupyHigh, IntVec2 pos, int dir)
	{
		return false;
	}

	private void BuildCornerPositions()
	{
	}

	private void BuildEdgePositions()
	{
	}

	private void BuildEdgeWholePositions()
	{
	}

	private void BuildEdgePositionsForCorridor(int floorIndex)
	{
	}

	public void AddLootPointsForRoom(int floorIndex)
	{
	}

	private void GenerateFurnitureByType(int floorIndex)
	{
	}

	private void AddDecor(Furniture.SuperGroup decorSuperGroup, int count)
	{
	}

	private void AddDecor(Furniture.Group decorGroup, int count)
	{
	}

	private void TryAddGroupOnEdges(Furniture.Group groupID, int offset = -1, float probability = float.PositiveInfinity)
	{
	}

	private bool TryAddFurnitureOnCorners(Furniture.Group groupID, int offset = -1)
	{
		return false;
	}

	private bool TryAddFurnitureOnEdges(Furniture.Group groupID, int offset = -1)
	{
		return false;
	}

	private bool TryAddFurnitureOnCorners(Furniture.ID furniID, int offset = -1)
	{
		return false;
	}

	private bool TryAddFurnitureOnEdges(Furniture.ID furniID, int offset = -1)
	{
		return false;
	}

	private bool TryAddFurnitureOnCorners(Furniture furni, int offset = -1)
	{
		return false;
	}

	private bool TryAddFurnitureOnEdges(Furniture furni, int offset = -1)
	{
		return false;
	}

	private bool TryAddFurnitureOnCells(Furniture.ID furniID)
	{
		return false;
	}

	private bool TryAddFurnitureOnCells(Furniture furni)
	{
		return false;
	}

	private bool TryAddOnCorners(Furniture furni, int offset = -1)
	{
		return false;
	}

	private bool TryAddOnList(Furniture furni, List<FurniturePosition> posList, int offset = -1)
	{
		return false;
	}

	private bool TryAddWindow(int floorIndex, int offset = -1)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void AddFurniture(Furniture furni, FurniturePosition pos)
	{
	}

	private void AddFurniture(Furniture furni, IntVec2 pos, int dir)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private bool IsInsideGrid(int x, int y)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public IntVec2 LocalPos(IntVec2 pos)
	{
		return default(IntVec2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void BlockPosition(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void BlockPosition(IntVec2 pos)
	{
	}

	public void DrawGrid(bool low)
	{
	}

	private void DrawGridX(int x, int y, Color c)
	{
	}

	private Vector3 GetCellPosition(int x, int y)
	{
		return default(Vector3);
	}

	private Vector3 GetCellCenter(int x, int y)
	{
		return default(Vector3);
	}

	private void GenerateFactoryCorridor(int floorIndex)
	{
	}

	private void GenerateCNCRoom(int floorIndex)
	{
	}

	private void GenerateMetalworks(int floorIndex)
	{
	}

	private void GenerateFactoryStorage(int floorIndex)
	{
	}

	private void GeneratePoliceCorridor()
	{
	}

	private void GeneratePoliceBathroom()
	{
	}

	private void GeneratePoliceReception()
	{
	}

	private void GeneratePoliceArmory()
	{
	}

	private void GeneratePoliceDetectives()
	{
	}

	private void GeneratePoliceOffice()
	{
	}

	private void GeneratePoliceArchives()
	{
	}

	private void GeneratePoliceCells()
	{
	}

	private void GenerateBathroom()
	{
	}

	private void GenerateBedroom(int floorIndex)
	{
	}

	private void GenerateKitchen(int floorIndex)
	{
	}

	private void GenerateLivingRoom(int floorIndex)
	{
	}

	private void GenerateCorridor(int floorIndex)
	{
	}
}
