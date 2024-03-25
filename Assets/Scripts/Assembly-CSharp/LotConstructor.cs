using System.Collections.Generic;
using UnityEngine;

public class LotConstructor : MonoBehaviour
{
	public List<Furniture.ID> specialOutsideFurniture;

	public static LotConstructor instance;

	[Header("References")]
	public MapGeneration mapGen;

	public GameObject buildingMeshPrefab;

	[Header("Settings")]
	public bool genVegetation;

	public bool genFurniture;

	[Header("Runtime")]
	public Transform meshHolder;

	public Transform furniHolder;

	public Transform vegHolder;

	public GenericMeshGenerator curMeshGen;

	public void Init()
	{
	}

	public void CleanUp()
	{
	}

	public void GenerateHashCellBuildings(HashCell cell)
	{
	}

	private void GenerateVegetation(HashCell cell)
	{
	}

	private void GeneratePolygonFencing(Polygon poly)
	{
	}

	private void GenerateBuildingFurniture(BuildingBlueprint building)
	{
	}

	private void AddFurniture(GameObject obj, BuildingBlueprint building, bool isOutside)
	{
	}
}
