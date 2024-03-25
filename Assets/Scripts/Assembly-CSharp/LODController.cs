using UnityEngine;

public class LODController : MonoBehaviour
{
	public struct AuxCoord
	{
		public IntVec2 pos;

		public IntVec2 add;

		public Vector2 cellCenter;
	}

	public static LODController instance;

	[Header("Settings")]
	public float groundLevel;

	public float skyLevel;

	public LODLevel[] lodLevel;

	public float cameraFarMulti;

	public float skyDistanceMulti;

	[Header("Runtime")]
	public Transform lodTarget;

	public PlayerMain lodPlayer;

	public DrawDistanceLevels curDrawDistance;

	public float lodHeightCoef;

	public bool fogUpToDate;

	[Header("Debug")]
	public bool disableServerSideGeneration;

	public bool drawAll;

	public bool collideAll;

	private MapHash hash;

	private Vector3 lodPos;

	private LODLevel curLevel;

	public void Init()
	{
	}

	public void SetLodTarget(Transform t)
	{
	}

	public void CleanUp()
	{
	}

	private void Update()
	{
	}

	public AuxCoord GetAuxCoord(Vector2 pos)
	{
		return default(AuxCoord);
	}

	public void UpdatePhysics()
	{
	}

	private void UpdateLOD()
	{
	}

	public void RequestGenerationFor(HashCell cell, bool isClientRequest)
	{
	}

	private void LODForCell(HashCell cell, Vector2 cellCenter)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
