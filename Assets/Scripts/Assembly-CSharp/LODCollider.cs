using System;
using UnityEngine;

[Serializable]
public class LODCollider
{
	public bool colliding;

	public Collider col;

	public GameObject obj;

	[Header("IFurniture")]
	public InteractableFurniture interactableFurniture;

	public void SetColliding(bool b, bool forceSet = false)
	{
	}
}
