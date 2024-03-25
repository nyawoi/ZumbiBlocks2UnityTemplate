using System;
using UnityEngine;

[Serializable]
public struct LODLevel
{
	[HideInInspector]
	public string tag;

	[Header("Distance settings")]
	public float terrainDist;

	public float outsideFurniDist;

	public float insideFurniDist;

	public float fogMulti;
}
