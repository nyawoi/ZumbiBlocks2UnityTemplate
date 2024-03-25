using System;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureDatabase : MonoBehaviour
{
	public enum VegType : byte
	{
		Tree1 = 0,
		Tree2 = 1,
		DeadTree1 = 2,
		DeadTree2 = 3,
		TirePile = 4,
		PipePile = 5,
		Barrel = 6
	}

	public static FurnitureDatabase instance;

	public GameObject furnitureSet;

	public FurnitureSuperGroup[] superGroupSettings;

	[Header("Furniture propriamente dita")]
	public Furniture[] allFurniture;

	public List<FurnitureGroup> furniGroup;

	[Header("Vegetation")]
	public GameObject[] vegetation;

	public VegType[] liveTrees;

	public VegType[] deadTrees;

	[Header("Interaction")]
	public int baseDMGDivider;

	public void Init()
	{
	}

	public void PrepareFullList()
	{
	}

	public void PrepareGroups()
	{
	}

	public bool IDExists(Furniture.ID id)
	{
		return false;
	}

	public FurnitureGroup GetGroup(Furniture.Group g)
	{
		return null;
	}

	public Furniture GetRandomByGroup(Furniture.Group g, System.Random rand)
	{
		return null;
	}

	public Furniture GetRandomByGroup(Furniture.SuperGroup g, System.Random rand)
	{
		return null;
	}

	public VegType GetRandomTree(System.Random rand, bool alive)
	{
		return default(VegType);
	}

	public Furniture GetFurniturePrefab(Furniture.ID id)
	{
		return null;
	}

	public Furniture GetDefaultDoor()
	{
		return null;
	}

	public Furniture GetDefaultStair()
	{
		return null;
	}

	public Furniture GetMainStair()
	{
		return null;
	}

	public Furniture GetDefaultWindow()
	{
		return null;
	}
}
