using System;
using UnityEngine;

[Serializable]
public class BossSettings
{
	public Zombie.Type zType;

	public Sprite headSprite;

	public float topSpeed;

	public float maxHealth;

	public ZombieDeathAnimation deathAnim;

	public string nameTag;

	public string descTag;

	public int tier;

	public float introCamDistance;
}
