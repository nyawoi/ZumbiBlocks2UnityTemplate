using System.Collections.Generic;
using UnityEngine;

public class HashCell
{
	public enum Generated
	{
		Not = 0,
		Ongoing = 1,
		Done = 2
	}

	public IntVec2 coordinate;

	public Generated generated;

	public GenericMeshGenerator terrainMeshGenerator;

	public GenericMeshGenerator buildingMeshGenerator;

	public List<int> requestedLobbyIDs;

	public List<int> subscriberLobbyIDs;

	public HashCellDataBuffers dataBuffers;

	public bool hasContent;

	public Vector3 cellCenter;

	public List<Polygon> polygons;

	public List<GridEdge> edges;

	public List<GridNode> nodes;

	public List<BuildingBlueprint> allBuildings;

	public TerrainMesh terrainMesh;

	public LotMesh lotMesh;

	public List<GridNode> nodesWithSize;

	public List<string> clientDebugMsg;

	private static int debugMsgCount;

	public bool collisionActive;

	public bool newCollisionActive;

	public bool renderActive;

	public int maxLootCount;

	public GameObject lootHolder;

	public List<DroppedLoot> loot;

	public float baseZombieCount;

	public int curMaxZombies;

	public int curSpawnedZombies;

	public BuildingBlueprint RandomBuilding()
	{
		return null;
	}

	public void AddDebugMsg(string msg)
	{
	}

	public HashCell(IntVec2 coord)
	{
	}

	public bool HasPhysicalRoads()
	{
		return false;
	}

	public Vector3 GetRandomRoadPosition(float roadChance, float roadCentering = 0f)
	{
		return default(Vector3);
	}

	public static Vector3 GetRandomRoadPoint(GridEdge edgeRoad, float roadCentering)
	{
		return default(Vector3);
	}

	public void BakeRoadWithSize()
	{
	}

	public void VerifySubscribers()
	{
	}
}
