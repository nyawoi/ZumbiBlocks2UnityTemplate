using System;
using UnityEngine;

[Serializable]
public class Explosion
{
	public enum ID
	{
		None = 0,
		BossFlash = 1,
		ToxBall = 2,
		Frag = 3,
		Stun = 4
	}

	public ID id;

	[Header("Flash")]
	public float flashDuration;

	public float flashRange;

	[Header("Dmg")]
	public float dmgMin;

	public float dmgMax;

	public float dmgRange;

	public StaggerPack.ID dmgStagger;

	[Header("Status Effect")]
	public StatusEffect.ID seID;

	public float seAmount;
}
