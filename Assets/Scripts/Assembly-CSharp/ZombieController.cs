using UnityEngine;

public class ZombieController : MonoBehaviour
{
	public static ZombieController instance;

	[Header("Population settings")]
	public int maxZombieCountGlobal;

	public int maxActiveZombies;

	public int maxZombieDolls;

	[Range(0f, 1f)]
	public float initialSpawnAmountMultiplier;

	[Range(0f, 1f)]
	public float indoorZombieRate;

	public int factoryZombieCount;

	[Header("Population timer")]
	public float zombieRespawnCounter;

	public float zombiePopulationTimer;

	public int totalInactiveZombies;

	public int totalActiveZombies;

	[Header("Difficulty")]
	public float refreshLevelTimer;

	public float refreshLevelFreq;

	[Header("Refs")]
	public ZombieDistanceMatrix distMatrix;

	public ZombieAISettings aiSettings;

	public Pathfinding pathfinding;

	public ZombieLoader zombieLoader;

	public ZombieNetSyncs zombieSync;

	public StaggerDatabase staggerDB;

	[Header("Skins")]
	public ZombieSkins skins;

	[Header("Misc animations")]
	public AnimationPack climbAnimation;

	public ZombieDeathAnimation[] zombieDeaths;

	public ZombieAttack[] zombieAttacks;

	public LayerMask defaultAttackLayerMask;

	[Header("Debug")]
	public Zombie.Type defaultZombie;

	public bool disableZombies;

	public bool disablePosSnapping;

	public bool disableFactoryZombies;

	public bool disableVisualAggro;

	public bool disableNoiseAgro;

	public int testZombieLevelMin;

	public int testZombieLevelMax;

	[Header("Boss flags")]
	public bool respawningBossExists;

	public bool activeBossExists;

	public bool DisableZombies => false;

	public void CleanUp()
	{
	}

	public int GetIndexOf(ZombieAttack za)
	{
		return 0;
	}

	public bool CanActivateMoreZombies()
	{
		return false;
	}

	public void OnZombieRemoved(int id)
	{
	}

	public void OnZombieUnloaded(int id)
	{
	}

	public void AggroZombiesByNoiseRange(PlayerMain targetPlayer, float noiseRange)
	{
	}

	public void Init()
	{
	}

	private int CalculateMaxZombieCount()
	{
		return 0;
	}

	public void CalculateCellZombieCount(HashCell cell)
	{
	}

	public void InitZombies()
	{
	}

	public void RecalculateMaxZombiesPerCell()
	{
	}

	public void GenerateZombiePositions()
	{
	}

	public void GenerateBosses()
	{
	}

	public void GenerateAllFactoriesZombies()
	{
	}

	public void GenerateFactoryZombies(Polygon factoryPolygon)
	{
	}

	public void SpawnBoss(BossRespawn respawn, bool sync = false)
	{
	}

	private static Vector3 GetBossSpawnPosition(Zombie.Type zombieType, BuildingBlueprint building)
	{
		return default(Vector3);
	}

	private bool NearActiveBoss(Vector3 pos)
	{
		return false;
	}

	private UnloadedZombie SpawnFactoryZombie(BuildingBlueprint factoryBuilding)
	{
		return null;
	}

	private UnloadedZombie SpawnZombieForCell(HashCell cell, bool skipSpawnAnimation)
	{
		return null;
	}

	public UnloadedZombie SpawnBasicZombie(bool skipSpawnAnimation, Vector3 spawnPosition, Zombie.SubClass subClass)
	{
		return null;
	}

	public void UpdateZombies()
	{
	}

	private void CountDownZombieRespawns()
	{
	}

	private void RespawnZombiesForCell(HashCell cell)
	{
	}

	private void UpdateBossFlags()
	{
	}

	private void UpdateZombiesAI()
	{
	}

	private static bool ShouldSnapZombiePosition(Zombie curZombie)
	{
		return false;
	}

	private void SpawnLootForZombie(Zombie zombie)
	{
	}

	public void RealizeDeathClientSide(int zombieID, bool useDoll)
	{
	}

	public ZombieDeathAnimation GetDeathAnim(Zombie.Type zType, int i = -1)
	{
		return null;
	}
}
