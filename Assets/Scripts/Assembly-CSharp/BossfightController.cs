using System.Collections.Generic;
using UnityEngine;

public class BossfightController : MonoBehaviour
{
	public static BossfightController instance;

	public BossFightRespawns respawns;

	public BossfightCameraSequence camSequence;

	[Header("Status")]
	public int curBossTier;

	[Header("Settings")]
	public bool bossDamageOverridesDodge;

	public AnimationCurve dmgCurve;

	public float bossDmgMulti;

	public BossSettings[] settings;

	public BossSettings GetBossSettings(Zombie.Type zType)
	{
		return null;
	}

	public static bool IsBoss(Zombie.Type t)
	{
		return false;
	}

	public void GetBossLoot(List<InventoryItem> itemList, Zombie.Type zType)
	{
	}

	public void DisplayBossName(Zombie.Type zType, float duration)
	{
	}

	public void OnKilledBoss(Zombie.Type zType)
	{
	}

	public void MyUpdate()
	{
	}

	public void Init()
	{
	}

	public void CleanUp()
	{
	}

	public static float BossDMG(float baseDmg)
	{
		return 0f;
	}

	public float GetBossSpeed(Zombie.Type t)
	{
		return 0f;
	}

	public float GetBossHealth(Zombie.Type t)
	{
		return 0f;
	}

	public int GetBossTier(Zombie.Type t)
	{
		return 0;
	}

	public ZombieDeathAnimation GetDeathAnim(Zombie.Type t)
	{
		return null;
	}

	public string GetBossName(Zombie.Type t)
	{
		return null;
	}

	public Sprite GetBossHeadSprite(Zombie.Type t)
	{
		return null;
	}

	public string GetBossDesc(Zombie.Type t)
	{
		return null;
	}

	public float GetBossCameraDistance(Zombie.Type t)
	{
		return 0f;
	}
}
