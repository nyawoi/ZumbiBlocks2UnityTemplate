using System;
using UnityEngine;

[Serializable]
public class ZombieHealth
{
	[Header("Settings")]
	public float max;

	public bool autoDie;

	public float finalizeWindow;

	[Header("Runtime")]
	public bool isAlive;

	public float amount;

	public float finalizeTimer;

	public ZombieHealth(float maxH, bool autoD)
	{
	}

	public bool Damage(Damage dmg)
	{
		return false;
	}
}
