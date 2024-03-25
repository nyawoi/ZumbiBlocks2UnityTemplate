using System;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{
	private class TrimPolygon
	{
		public Vector2 center;

		public List<Vector2> points;

		public float minRadius;

		public float maxRadius;

		public TrimPolygon(MapSizeSettings sizeSettings, System.Random rand)
		{
		}

		public bool IsInsidePolygon(Vector2 pos)
		{
			return false;
		}
	}

	public enum HouseGenOptions
	{
		All = 0,
		First = 1,
		Random = 2,
		SpecificContent = 3
	}

	public static MapGeneration instance;

	[Header("USE THREAD")]
	public bool useThread;

	[Header("References")]
	public MapConstructor mapConstructor;

	public LotConstructor lotConstructor;

	public MapHash maphash;

	[Header("Buildings generation")]
	public BuildingInteriorGenerator interiorGenerator;

	public ParkGenerator parkGenerator;

	public ResidenceGenerator residenceGenerator;

	public PoliceGenerator policeGenerator;

	public FactoryGenerator factoryGenerator;

	[HideInInspector]
	public MapSizeSettings sizeSettings;

	[Header("Position Perlin Settings")]
	[Range(0.01f, 0.99f)]
	public float posPerlinFreq;

	public float posPerlinMagnitude;

	public Vector2 posPerlinStartHorizontal;

	public Vector2 posPerlinStartVertical;

	[Header("Height settings")]
	public bool flattenBeaches;

	public float baseTerrainHeight;

	[Range(0.01f, 0.99f)]
	public float hPerlinFreq;

	public float hPerlinMagnitude;

	public Vector2 hPerlinStart;

	[Header("Poly group Settings")]
	public int minPolyGroupSize;

	public int maxPolyGroupSize;

	[Header("Runtime")]
	public int largestDistanceFromBeach;

	public bool mapIsGenerated;

	private List<Polygon> closedPolygons;

	private List<Polygon> openPolygons;

	private List<GridEdge> edges;

	[HideInInspector]
	public GridNode[,] nodes;

	private TrimPolygon trim;

	private List<IntVec2> cutNodes;

	private int curGroup;

	[Header("Silhoutte data")]
	public List<IntVec2> initialPolygonPoints;

	public List<Vector3> silhouette3D;

	public Vector3 silhouetteAvg;

	[Header("Aux")]
	public System.Random rand;

	public float sandY;

	public float waterY;

	[Header("House generation options")]
	public HouseGenOptions houseGenOptions;

	public Polygon.ContentType houseGenContent;

	[Header("Debug draw")]
	public bool drawExpanded;

	[Header("Debug draw types")]
	public bool drawGrid;

	public bool drawPolys;

	public bool drawNodeGraph;

	public bool drawEdges;

	public List<Polygon> OpenPolygons => null;

	public List<GridEdge> Edges => null;

	public void Init()
	{
	}

	public void CleanUp()
	{
	}

	public void GenerateSilhouettePoints()
	{
	}

	public long GenerateMapBlueprint(MapSizeSettings sizeSet)
	{
		return 0L;
	}

	private void BakePolygonTriangles()
	{
	}

	public long GenHousingBlueprint()
	{
		return 0L;
	}

	public void GeneratePolygonContent(Polygon poly)
	{
	}

	private void AllocateNodes()
	{
	}

	private void TrimNodes()
	{
	}

	private void CreatePolygons()
	{
	}

	private void AddSpecialContent(List<Polygon> auxList, Polygon.ContentType cType, int cAmount, Vector2 areaRange, IntVec2 boundRange)
	{
	}

	private void SubdvidePolygons()
	{
	}

	private Polygon PickPolygonByArea(float targArea, List<Polygon> sourcePolys)
	{
		return null;
	}

	private List<Polygon> GetPolygonsInRange(Vector2 areaRange, IntVec2 boundRange, List<Polygon> source)
	{
		return null;
	}

	private void PreStashPolygons(int breakDownSize, List<Polygon> sourceList, List<Polygon> targetList)
	{
	}

	private void SubdivideAPolygon(float diagProb, int breakDownSize, List<Polygon> sourceList, List<Polygon> targetList)
	{
	}

	private bool TryStashPolygon(Polygon poly, int breakdownSize, List<Polygon> sourceList, List<Polygon> targetList)
	{
		return false;
	}

	private void StashPolygon(Polygon poly, List<Polygon> sourceList, List<Polygon> targetList)
	{
	}

	private void BeachFlood()
	{
	}

	private void CalculatePolygonPoints()
	{
	}

	private void GeneratePolygonFencing()
	{
	}

	private void ConstructEdges()
	{
	}

	private void GroupPolygons()
	{
	}

	private void PaintRoads()
	{
	}

	private void BakeRoadLefts()
	{
	}

	private void CalculateNodePoints()
	{
	}

	private void CalculateRoadPoints()
	{
	}

	private void CreateNodePolyNeighbourhood()
	{
	}

	private void CreateEdgeNodeNeighbourhood()
	{
	}

	private void ApplyGridNoise()
	{
	}

	private void CalculateBeachNodes()
	{
	}

	private bool IsDirectionToTheLeft(int a, int b)
	{
		return false;
	}

	private bool IsDirectionToTheRight(int a, int b)
	{
		return false;
	}

	private bool IsToTheLeft(IntVec2 vec, int dir)
	{
		return false;
	}

	private bool IsToTheRight(IntVec2 vec, int dir)
	{
		return false;
	}

	private bool IsInFront(IntVec2 vec, int dir)
	{
		return false;
	}

	private bool IsInsideGrid(IntVec2 v)
	{
		return false;
	}

	private Vector3 GetGridPosition(int x, int y)
	{
		return default(Vector3);
	}

	private bool IsInsideBounds(IntVec2 p, IntVec2 min, IntVec2 max)
	{
		return false;
	}

	private GridEdge GetEdge(IntVec2 v1, IntVec2 v2)
	{
		return null;
	}

	private void OnDrawGizmos()
	{
	}
}
