using System;
using UnityEngine;

[Serializable]
public class BossRespawn
{
	[HideInInspector]
	public Polygon targetPolygon;

	public Zombie.Type zombieType;

	public float respawnTimer;

	public int zombieID;

	public BossRespawn(Polygon p, Zombie.Type t)
	{
	}

	public void Update(float defaultRespawnTime)
	{
	}
}
