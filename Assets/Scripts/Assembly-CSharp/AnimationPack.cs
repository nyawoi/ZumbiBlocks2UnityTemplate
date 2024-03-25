using System;
using UnityEngine;

[Serializable]
public class AnimationPack
{
	public string name;

	[Header("Movement")]
	public AnimationCurve xCurve;

	public AnimationCurve yCurve;

	public AnimationCurve zCurve;

	public float movementMultiplier;

	[Header("Events")]
	public float timeout;
}
