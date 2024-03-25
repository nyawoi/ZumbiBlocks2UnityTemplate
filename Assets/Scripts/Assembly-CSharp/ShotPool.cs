using System.Collections.Generic;
using UnityEngine;

public class ShotPool : MonoBehaviour
{
	public static ShotPool instance;

	public GameObject shotPrefab;

	private List<GameObject> shotpool;

	private Transform shotHolder;

	public GameObject InstantiateShot(Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	public void DestroyShot(GameObject shot)
	{
	}

	public void Init()
	{
	}
}
