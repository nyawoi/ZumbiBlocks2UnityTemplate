using System;
using UnityEngine;

[Serializable]
public class ZombieAttack
{
	public string animationName;

	public AnimationCurve forwardCurve;

	public float topSpeed;

	public float arcRange;

	public float arcDistance;

	public float hitTime;

	public float attackDistance;

	public float attackDot;

	public AudioPack audioPack;
}
