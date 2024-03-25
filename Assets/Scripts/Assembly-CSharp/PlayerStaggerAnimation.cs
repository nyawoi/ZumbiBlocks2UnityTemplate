using System;
using UnityEngine;

[Serializable]
public class PlayerStaggerAnimation
{
	public string animationName;

	public AnimationCurve moveCurve;

	public Vector2 moveDirection;

	public float moveSpeedMultiplier;

	public float animationTimeout;
}
