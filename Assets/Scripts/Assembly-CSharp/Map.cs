using System.Threading;
using UnityEngine;

public class Map : MonoBehaviour
{
	public static Map instance;

	[Header("Setting options")]
	public IntVec2 defMapSize;

	[Header("Cur Settings")]
	public MapSizeSettings sizeSettings;

	public float width;

	public float height;

	[Header("Components")]
	public MapGeneration generation;

	public MapHash hash;

	public VaultHash vaultHash;

	public MapGraph graph;

	public LODController lod;

	public RoomTypeColors roomTypeColor;

	public AuxiliarMapObjects auxObjs;

	[Header("Map gen thread")]
	public bool waitingForMapgen;

	private Thread mapGenThread;

	public long timeToGenTerrain;

	public long timeToGenHousing;

	public long timeToGenHash;

	public long timeToGenGraph;

	public long timeToGen;

	[Header("Debug Generation Config")]
	public bool genOnStart;

	public bool genAllMeshes;

	public static bool Generated => false;

	public void Init()
	{
	}

	public void CleanUp()
	{
	}

	public void Update()
	{
	}

	private void GenerateAll()
	{
	}

	private long GenMapHash()
	{
		return 0L;
	}

	private long GenMapGraph()
	{
		return 0L;
	}

	public void GenMapWithThread()
	{
	}

	public void StartMapGeneration()
	{
	}
}
