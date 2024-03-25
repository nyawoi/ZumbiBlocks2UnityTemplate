using System.Collections.Generic;
using UnityEngine;

public class BuildingBlueprint
{
	public class FoundationRoom
	{
		public byte id;

		public IntVec2 bottomLeft;

		public IntVec2 topRight;
	}

	public class BuildingRoom
	{
		public IntVec2 bottomLeft;

		public IntVec2 topRight;

		public byte floorColor;
	}

	public class Floor
	{
		public List<BuildingRoom> rooms;

		public byte[,] buildingGrid;

		public int stairwellFoundationID;

		public IntVec2 stairwellBL;

		public IntVec2 stairwellTR;

		public IntVec2 stairwellEntryCell;

		public IntVec2 stairwellDirection;

		public List<Furniture.WallInstance> doors;

		public List<Furniture.WallInstance> windows;

		public List<Furniture.Instance> furniture;
	}

	public Polygon myPolygon;

	public byte outsideWallColor;

	public byte insideWallColor;

	public byte rooftopColor;

	public IntVec2 buildingGridSize;

	public List<FoundationRoom> foundation;

	public Vector3 buildingStartPos;

	public Vector3 buildingLocalForward;

	public Vector3 buildingLocalRight;

	public List<Furniture.YardDecor> yardDecor;

	public BuildingFurnitureSet furnitureSet;

	public Floor[] floor;

	public List<(Vector2, int)> lootSpawnPoints;

	public Vector3 entryRoomCenter;

	public Floor GroundFloor => null;

	public Floor TopFLoor => null;

	public bool MultiFloor => false;

	public int FloorCount => 0;

	public bool IsRooftop(int floorIndex)
	{
		return false;
	}

	public BuildingBlueprint(Polygon poly, int floorCount)
	{
	}

	public Vector3 RandomLootSpawnPoint()
	{
		return default(Vector3);
	}

	public Vector3 LocalVector(float x, float y)
	{
		return default(Vector3);
	}

	public Vector3 LocalVector(Vector2 vec2)
	{
		return default(Vector3);
	}

	public Vector3 LocalVector(IntVec2 vec2)
	{
		return default(Vector3);
	}

	public Vector3 GetBuildingCenter()
	{
		return default(Vector3);
	}

	public Vector3 GetRandomFoundationCenter(bool subtract1Cell)
	{
		return default(Vector3);
	}

	public float GetBuildingRadius()
	{
		return 0f;
	}

	public Vector3 GetPointInBuildingSpace(Vector3 pos)
	{
		return default(Vector3);
	}

	public IntVec2 GetCellCoord(Vector3 worldPos)
	{
		return default(IntVec2);
	}

	public byte GetCellID(IntVec2 pos, int floorIndex)
	{
		return 0;
	}

	public bool IsInBuildingGrid(IntVec2 pos)
	{
		return false;
	}

	public Vector3 FloorStartingPosition(int floorIndex)
	{
		return default(Vector3);
	}

	public Vector3 GetGridCellCenter(int x, int y, int floorIndex = 0)
	{
		return default(Vector3);
	}

	public Vector3 GetFurnitureCellCenter(int x, int y, int floorIndex = 0)
	{
		return default(Vector3);
	}

	public Vector3 GetGridCellStart(int x, int y, int floorIndex = 0)
	{
		return default(Vector3);
	}

	public IntVec2? GetExitDoorPos(IntVec2 pos, bool considerWindow)
	{
		return null;
	}

	public bool HasDoor(IntVec2Couple couple, int floorIndex)
	{
		return false;
	}
}
