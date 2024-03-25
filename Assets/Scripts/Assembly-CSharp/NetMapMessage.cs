using UnityEngine;

public class NetMapMessage
{
	public enum SubType : byte
	{
		InitialMapInfo = 0,
		PlayerInstantiate = 1,
		CellMeshRequest = 2,
		CellMeshSync = 3,
		CellMeshVertex = 4,
		CellMeshUV = 5,
		BuildingBaseData = 6,
		BuildingDoorsAndWindows = 7,
		PolygonVegetation = 8,
		PolygonFencing = 9,
		CellLoot = 10,
		RemoveLoot = 11,
		CellSingleLoot = 12,
		ClientLootDrop = 13,
		PolyBakedTriangles = 14,
		BuildingFurnitureDecor = 15,
		BuildingFurnitureYard = 16,
		MapSilhouette = 17,
		InterFurnitureData = 18,
		ClientFurnitureInteraction = 19,
		ClientFurnitureDamage = 20,
		BuildingFloorGrid = 21,
		BuildingRooms = 22
	}

	public static void InitialMapInfo(Buffer buffer, int hashW, int hashH, float hashCellSize)
	{
	}

	public static void InstantiatePlayer(Buffer buffer, int lobbyID, Vector3 pos, float rotation, SkinDatabase.SkinID skinID, SkinDatabase.Gender skinGender, int skinColor)
	{
	}

	public static void CellMeshRequest(Buffer buffer, int lobbyID, int x, int y)
	{
	}

	public static void CellMeshSync(Buffer buffer, int x, int y, bool hasContent)
	{
	}

	public static void CellMeshVertex(Buffer buffer, int vertexCount)
	{
	}

	public static void CellMeshUV(Buffer buffer, int uvCount)
	{
	}

	public static void CellPolygonFencing(Buffer buffer, byte fenceType, byte fenceColor, int pointCount)
	{
	}

	public static void CellBuildingBaseData(Buffer buffer, byte floorCount, byte outwallColor, byte inwallColor, byte roofColor, byte buildType, Vector2 localForward, Vector3 startPos)
	{
	}

	public static void CellBuildingFloorGrid(Buffer buffer, int floorIndex, int stairwellFoundationID, IntVec2 stairWellBL, IntVec2 stairWellTR)
	{
	}

	public static void CellBuildingDoorsAndWindows(Buffer buffer, int floorIndex, int doorCount, int windowCount)
	{
	}

	public static void CellBuildingFurnitureDecor(Buffer buffer, int floorIndex, int count)
	{
	}

	public static void CellBuildingRooms(Buffer buffer, int floorIndex, int count)
	{
	}

	public static void CellBuildingFurnitureYard(Buffer buffer, int count)
	{
	}

	public static void CellPolygonVegetation(Buffer buffer, int vegCount)
	{
	}

	public static void CellPolygonBakedTriangles(Buffer buffer, int count)
	{
	}

	public static void CellLoot(Buffer buffer, int lootCount)
	{
	}

	public static void PushLootData(Buffer buffer, DroppedLoot loot)
	{
	}

	public static void PushLootData(Buffer buffer, int id, Vector3 pos, InventoryItem item)
	{
	}

	public static void CellSingleLoot(Buffer buffer, DroppedLoot droppedLoot)
	{
	}

	public static void RemoveLoot(Buffer buffer, int lootID)
	{
	}

	public static void ClientLootDrop(Buffer buffer, InventoryItem item, Vector3 pos)
	{
	}

	public static void SetArrayCount(Buffer buffer, byte count)
	{
	}

	public static void MapSilhouette(Buffer buffer)
	{
	}

	public static void InterFurnitureData(Buffer buffer, byte cellX, byte cellY, int id, byte state, byte health)
	{
	}

	public static void PushFurnitureID(Buffer buffer, IntVec2 cellCoord, int cellID)
	{
	}

	public static void ClientFurnitureInteraction(Buffer buffer, IntVec2 cellCoord, int cellID, byte targetState)
	{
	}

	public static void ClientFurnitureDamage(Buffer buffer, IntVec2 cellCoord, int cellID, float dmg)
	{
	}
}
