using UnityEngine;

public class BossAttackSetBase : MonoBehaviour
{
	public static BossAttackSetBase instance;

	public BossAttackSet[] sets;

	public void Init()
	{
	}

	public BossAttackSet GetSet(Zombie.Type zType)
	{
		return null;
	}

	public BossAction GetAction(Zombie.Type zType, int actionIndex)
	{
		return null;
	}
}
