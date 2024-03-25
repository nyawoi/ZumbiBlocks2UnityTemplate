using UnityEngine;

public class DebugLabels3D : MonoBehaviour
{
	public static DebugLabels3D Instance;

	public GameObject labelPrefab;

	private void Start()
	{
	}

	public void SpawnLabel(Vector3 position, string msg, Color color, float scale = 0.01f)
	{
	}
}
