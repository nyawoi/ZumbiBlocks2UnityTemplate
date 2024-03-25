using TMPro;
using UnityEngine;

public class MapRendering : MonoBehaviour
{
	public class CellRendering
	{
		public GameObject terrainObject;

		public GameObject buildingObject;

		public void Clear()
		{
		}
	}

	public static MapRendering instance;

	public InterestPointController interestPoints;

	public GameObject mapCellTerrainPrefab;

	public GameObject mapCellBuildingPrefab;

	public Camera mapCamera;

	public RectTransform mapBGTransform;

	public Transform waterReference;

	public float minCameraSize;

	public float maxCameraSize;

	public float scrollSpeed;

	[Header("Runtime")]
	public IntVec2 curArraySize;

	private CellRendering[,] renderArray;

	private GameObject gapMeshObject;

	public bool dragging;

	public Vector3 lastMousePos;

	public bool focusedOnPlayer;

	[Header("Cam pos")]
	public Vector2 mapBL;

	public Vector2 mapTR;

	public float camSize;

	[Header("Limits")]
	public float padding;

	public Vector2 limitBL;

	public Vector2 limitTR;

	[Header("UI")]
	public float camZoom;

	public TMP_Text zoomText;

	public void Init()
	{
	}

	public void Update()
	{
	}

	public void AllocateCells(IntVec2 size)
	{
	}

	public void GenerateGapMesh()
	{
	}

	public void CellGenerated(HashCell cell)
	{
	}

	public void OnClickedMap()
	{
	}

	public void OnReleasedMap()
	{
	}

	public void SetActive(bool b)
	{
	}

	public void CleanUp()
	{
	}
}
