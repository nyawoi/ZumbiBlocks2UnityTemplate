using UnityEngine;

public class TerrainMesh : MonoBehaviour
{
	[Header("Mesh generation")]
	public MeshFilter meshFilter;

	public MeshCollider meshCol;

	[Header("LOD")]
	public LODTarget lodTarget;
}
