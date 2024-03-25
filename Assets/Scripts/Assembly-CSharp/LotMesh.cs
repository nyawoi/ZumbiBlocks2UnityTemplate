using UnityEngine;

public class LotMesh : MonoBehaviour
{
	[Header("Mesh generation")]
	public MeshFilter meshFilter;

	public MeshCollider meshCol;

	[Header("LOD")]
	public LODTarget lodTarget;
}
