using System.Collections.Generic;
using UnityEngine;

public class FXPropsController : MonoBehaviour
{
	public static FXPropsController instance;

	public int maxProps;

	public FXProp[] propPrefab;

	public Transform holder;

	private List<FXProp> spawnedProp;

	public void Init()
	{
	}

	public void RegisterProp(FXProp fxProp)
	{
	}

	public void SpawnProp(FXProp.ID id, Vector3 pos, Quaternion rot, Transform attachransform = null, bool syncOnline = false)
	{
	}

	public void SpawnProp(FXProp.ID id, Vector3 pos, Quaternion rot, Vector3 startVelocity, Vector3 startAngularVelocity, Transform attachTransform = null, bool syncOnline = false)
	{
	}

	public void Update()
	{
	}
}
