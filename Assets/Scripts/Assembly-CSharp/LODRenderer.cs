using System;
using UnityEngine;

[Serializable]
public class LODRenderer
{
	public bool rendering;

	public Renderer render;

	public GameObject obj;

	[Header("Misc")]
	public Cloth cloth;

	[Header("IFurniture")]
	public InteractableFurniture interactableFurniture;

	public void SetRendering(bool b, bool forceSet = false)
	{
	}
}
