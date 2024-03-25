using System;
using UnityEngine;

[Serializable]
public class ZombieDeathAnimation
{
	public enum ID
	{
		Backwards = 0,
		RightKnee = 1,
		RiotDeath = 2,
		QueenDeath = 3
	}

	[Header("ID")]
	public ID myID;

	public string animationName;

	public float normalizedTimeout;

	[Header("Movement")]
	public AnimationCurve xVel;

	public AnimationCurve zVel;

	public float velocityMultiplier;

	public Vector3 deathForce;
}
