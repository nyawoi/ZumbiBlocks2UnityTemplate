using System;
using UnityEngine;

[Serializable]
public struct MapSizeSettings
{
	[Header("Configurable")]
	public int sizeOptionIndex;

	public int gridW;

	public int gridH;

	[Header("Standard sizes")]
	public float nodeSize;

	public float roadWidth;

	[Header("Standard beach settings")]
	public AnimationCurve beachCurve;

	public float beachLength;

	public int beachNodeCount;
}
