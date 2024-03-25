using UnityEngine;

public class NetCharacterMessage
{
	public enum SubType : byte
	{
		PlayerPosition = 0,
		PlayerAnimation = 1,
		RollVector = 2,
		ZombieSpawnBatch = 3,
		ZombieDeltaPosBatch = 4,
		ZombiePrecisePosBatch = 5,
		ZombieAnimation = 6,
		PlayerDamage = 7,
		PlayerEquipment = 8,
		RequestLoot = 9,
		DeliverLoot = 10,
		ShotEvent = 11,
		ZombieDamage = 12,
		ZombieDeath = 13,
		RequestRespawnPosition = 14,
		DeliverRespawnPosition = 15,
		ZombieSingleSpawn = 16,
		PlayerEquipmentRequest = 17,
		PlayerHealthState = 18,
		BossAction = 19,
		BossPropStage = 20,
		BossHealth = 21,
		BossShot = 22,
		Revive = 23,
		PlayerSkin = 24,
		GenericAggroSound = 25
	}

	public static void PlayerPosition(Buffer buffer, int lobbyID, Vector3 pos, float angle, byte camAngle, byte fightMode, byte spineControl)
	{
	}

	public static void PlayerAnimation(Buffer buffer, int lobbyID, bool isArms, byte mode, byte animationIndex, byte param)
	{
	}

	public static void ZombieAnimation(Buffer buffer, int zombieID, byte mode, byte animationIndex, byte param)
	{
	}

	public static void PlayerRollVector(Buffer buffer, int lobbyID, byte dirIndex)
	{
	}

	public static void PlayerDamage(Buffer buffer, Damage dmg)
	{
	}

	public static void ZombieDamage(Buffer buffer, int zombieID, Damage dmg)
	{
	}

	public static void PlayerEquipment(Buffer buffer, int lobbyID, PlayerInventory inventory, PlayerArms arms)
	{
	}

	public static void PlayerEquipmentRequest(Buffer buffer)
	{
	}

	public static void ZombieSpawnBatch(Buffer buffer)
	{
	}

	public static void PushZombieData(Buffer buffer, int id, byte zombieType, byte mesh, byte skinMaterial, Vector3 pos, byte bAngle)
	{
	}

	public static void PushZombieData(Buffer buffer, ZombieIdentity identity, ZombieTransform transform)
	{
	}

	public static void ZombieSingleSpawn(Buffer buffer, UnloadedZombie zombie)
	{
	}

	public static void ZombieDeltaPositions(Buffer buffer)
	{
	}

	public static void ZombiePrecisePositions(Buffer buffer)
	{
	}

	public static void LootRequest(Buffer buffer, int lootID)
	{
	}

	public static void LootDelivery(Buffer buffer, InventoryItem item)
	{
	}

	public static void ShotEvent(Buffer buffer, int lobbyID, Vector3 vector)
	{
	}

	public static void ZombieDeath(Buffer buffer, int zombieID, bool createRagDoll)
	{
	}

	public static void RequestRespawnPosition(Buffer buffer, int lobbyID)
	{
	}

	public static void DeliverRespawnPosition(Buffer buffer, Vector3 vec3)
	{
	}

	public static void PlayerHealthState(Buffer buffer, int playerlobbyID, PlayerMain.HealthState hState)
	{
	}

	public static void BossAction(Buffer buffer, int zombieID, byte zType, byte actionIndex)
	{
	}

	public static void BossPropStage(Buffer buffer, int zombieID, byte stage, byte propState)
	{
	}

	public static void BossHealth(Buffer buffer, int zombieID, float health)
	{
	}

	public static void BossShot(Buffer buffer, int zombieID, Vector3 shotDir)
	{
	}

	public static void PlayerRevive(Buffer buffer, int playerlobbyID)
	{
	}

	public static void PlayerSkin(Buffer buffer, int lobbyID, SkinDatabase.SkinID skinID, SkinDatabase.Gender gender, int color)
	{
	}

	public static void GenericAggroSound(Buffer buffer, float range)
	{
	}
}
