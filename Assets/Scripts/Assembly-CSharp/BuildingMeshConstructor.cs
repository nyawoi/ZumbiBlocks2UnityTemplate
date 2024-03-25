using UnityEngine;

public class BuildingMeshConstructor
{
	public enum WallType
	{
		Wall = 0,
		Door = 1,
		Window = 2,
		MainDoor = 3,
		BalconyWall = 4
	}

	private static GenericMeshGenerator meshGen;

	private static BuildingBlueprint building;

	public const float wallHeight = 3.5f;

	public const float wallWidth = 0.15f;

	public const float roofThickness = 0.2f;

	public const float RightFeet = 3.7f;

	public const float doorSize = 1.5f;

	public const float doorHeight = 2.2f;

	public const float windowHeight = 0.8f;

	public const float windowSize = 1.9f;

	public const float balconyWallHeight = 0.8f;

	public const float floorHeight = 0.05f;

	public static void GeneratePolygonBuilding(Polygon poly_, GenericMeshGenerator meshGen_, bool genRoof = true)
	{
	}

	private static void GenerateWalls()
	{
	}

	private static void GenerateRoomFloors()
	{
	}

	private static void GenerateFoundationAndRooftop(bool genRoof, Polygon poly_)
	{
	}

	private static bool IsBalcony(int group)
	{
		return false;
	}

	private static WallType ConvertToBalcony(WallType t, int group1, int group2)
	{
		return default(WallType);
	}

	private static bool ExtendWall(int groupSide, int groupDiag)
	{
		return false;
	}

	private static void GenWall(int myGroup, int[] surrondingGroups, int dir, Vector3 bot1, Vector3 bot2, WallType wallType, bool isRooftop, byte color)
	{
	}

	private static WallType GetWallType(IntVec2 first, IntVec2 second, int floorIndex)
	{
		return default(WallType);
	}

	private static bool HasDoor(IntVec2 first, IntVec2 second, out Furniture.ID doorID, int floorIndex)
	{
		doorID = default(Furniture.ID);
		return false;
	}

	private static bool HasWindow(IntVec2 first, IntVec2 second, int floorIndex)
	{
		return false;
	}

	private static int GetGrouping(int x, int y, int floorIndex)
	{
		return 0;
	}
}
