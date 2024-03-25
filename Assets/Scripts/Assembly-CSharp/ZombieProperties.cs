using System;

[Serializable]
public struct ZombieProperties
{
	public int mobility;

	public int strength;

	public int health;

	public int intelligence;

	public const int maxLevel = 30;

	public void SetZombieLevel(int zombieLevel)
	{
	}
}
