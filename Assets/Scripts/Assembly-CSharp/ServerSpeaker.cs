using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ServerSpeaker
{
	public Buffer sendBuffer;

	private IPacketTransmissionAdapter packetTransmission;

	public byte sendError;

	public int hostID;

	public void SetID(int host)
	{
	}

	public void SendBuffer(ServerController.PacketReliability reliability, int connectionID)
	{
	}

	public void SendBuffer(ServerController.PacketReliability reliability, int connectionID, Buffer targetBuffer)
	{
	}

	public void BroadcastBuffer(ServerController.PacketReliability reliability, int ignoreConnID = -1)
	{
	}

	private byte[] CloneBufferContent(Buffer targetBuffer)
	{
		return null;
	}

	public void BroadCastOnCell(HashCell cell, ServerController.PacketReliability reliability, Buffer targetBuffer = null)
	{
	}

	public void BroadcastBufferIngame(ServerController.PacketReliability reliability, int ignoreLobbyID = -1)
	{
	}

	public void BroadcastBufferIngame(Buffer targetBuffer, ServerController.PacketReliability reliability, int ignoreLobbyID = -1, int ignoreConnectionID = -1)
	{
	}

	public void SendHandshake(int connectionID)
	{
	}

	public void AddLobbyPlayer(int lobbyID, int specificConnection = -1)
	{
	}

	public void RemoveLobbyPlayer(int lobbyID, bool b)
	{
	}

	public void SyncReady(int lobbyID, bool isReady)
	{
	}

	public void ConfirmClientEntry(int connectionID, int lobbyID)
	{
	}

	public void SendPing(int connectionID, int requestID)
	{
	}

	public void SendInitialMapInfo(int connectionID)
	{
	}

	public void SendMapSilhouette(int connectionID)
	{
	}

	public void SyncPlayerInstantiate(PlayerMain player, int lobbyID, int specificConnection = -1)
	{
	}

	private List<Buffer> CreateLootBuffers(HashCell cell)
	{
		return null;
	}

	public void FulfillCellRequests(HashCell cell)
	{
	}

	public void BroadCastPlayerPosition(int lobbyID, Vector3 pos, float angle, byte camAngle, byte fightMode, byte spineCorrectionInput)
	{
	}

	public void BroadCastPlayerAnimation(int lobbyID, bool isArms, byte mode, byte animationIndex, byte param)
	{
	}

	public void BroadCastZombieAnimation(int zombieID, byte mode, byte animationIndex, byte param)
	{
	}

	public void BroadCastBossAciton(int zombieID, Zombie.Type zType, int index)
	{
	}

	public void BroadCastRollVector(int lobbyID, byte dirIndex)
	{
	}

	public void BroadCastEquipment(int lobbyID, PlayerMain player)
	{
	}

	public void BroadCastSkin(int sourceConn, int lobbyID, SkinDatabase.SkinID skinID, SkinDatabase.Gender gender, int color)
	{
	}

	public void RequestPlayerEquipments()
	{
	}

	public void SyncPlayerDamage(Damage dmg, int connID)
	{
	}

	public void BroadcastLootRemoval(HashCell cell, int lootID)
	{
	}

	public void DeliverLoot(InventoryItem item, int connectionID)
	{
	}

	public void BroadcastShot(int lobbyID, Vector3 shotVector)
	{
	}

	public void BroadcastPlayerHealth(int playerlobbyID, PlayerMain.HealthState health)
	{
	}

	public void SyncPlayerRevive(int playerlobbyID)
	{
	}

	public void BroadcastZombieDeath(int zombieID, bool useRagdoll)
	{
	}

	public void SendRespawnPoint(Vector3 pos, int connectionID)
	{
	}

	public void SendSingleLootSpawn(DroppedLoot loot, HashCell cell)
	{
	}

	public void SyncSingleZombie(UnloadedZombie uz)
	{
	}

	public void SyncDaytime(float time, float diff, float gameTime)
	{
	}

	public void SyncMatchState()
	{
	}

	public void SyncMatchSettings()
	{
	}

	public void BroadcastFXPropPos(FXProp.ID id, Vector3 pos, int srcConn)
	{
	}

	public void SendDCMsg(int connectionID, DisconnectionReason id)
	{
	}

	public void BroadcastLobbyLoadout(int sourceConnID, int lobbyID, InventoryItem.ID[] itemID)
	{
	}

	public void TreatLobbyLoadoutRequest(int lobbyID)
	{
	}

	public void BroadcastBossPropStage(int zombieID, byte stage, byte propState)
	{
	}

	public void SyncBossPropStage(int connectionID, int zombieID, byte stage, byte propState)
	{
	}

	public void BroadcastIFurniture(int cellX, int cellY, int id, byte state, byte health)
	{
	}

	public void SendIFurniture(int cellX, int cellY, int id, byte state, byte health, int connID)
	{
	}

	public void BroadcastUtilitySpawn(int itemID, int lobbyID, int localUtilityID, Vector3 pos, Quaternion rot)
	{
	}

	public void BroadcastUtilityDespawn(int lobbyID, int localUtilityID)
	{
	}

	public void BroadcastUtilityPosSync(int lobbyID, int localUtilityID, Vector3 pos, Quaternion rot)
	{
	}

	public void BroadcastBossHealth(int zombieID, float health)
	{
	}

	public void SyncUnlockLoadout(int tier, int conn)
	{
	}

	public void BroadcastBossShot(int zombieID, Vector3 shotDir)
	{
	}

	public void BroadcastExplosion(Vector3 origin, Explosion.ID id, int callerLobbyID, bool isZombieExplosion)
	{
	}

	public void BroadcastZombieAudio(int zombieID, byte audioID)
	{
	}

	public void BroadcastZombieAttackAudio(int zombieID, byte attackIndex)
	{
	}

	public void BroadcastPlayerCoreAudio(int playerID, byte audioID)
	{
	}

	public void BroadcastPlayerMeleeAudio(int playerID, byte meleeIndex)
	{
	}

	public void SyncKillFeed(int conn)
	{
	}

	public void SyncKillBoss(int conn)
	{
	}

	public void BroadcastIFurniAudio(int cellX, int cellY, int id, byte soundIndex)
	{
	}

	public void BroadcastImpactSFX(Vector3 pos, byte sfxID, int conn)
	{
	}

	public void BroadcastPlayerName(int lobbyID, string newName)
	{
	}
}
