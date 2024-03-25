using System;
using UnityEngine;

[Serializable]
public class ClientSpeaker
{
	public Buffer sendBuffer;

	private IPacketTransmissionAdapter packetTransmission;

	public void SendHandshake()
	{
	}

	public void SendAuth(string playerName)
	{
	}

	public void SyncReady(int lobbyID, bool isReady)
	{
	}

	private void SendBuffer(ServerController.PacketReliability reliability)
	{
	}

	private byte[] CloneSendBufferContent()
	{
		return null;
	}

	public void RequestCellData(int lobbyID, IntVec2 coord)
	{
	}

	public void SendPlayerPosition(Vector3 pos, float angle, byte camAngle, byte fightMode, byte spineControl)
	{
	}

	public void SendPing(int requestID)
	{
	}

	public void SendPlayerAnimation(bool isArms, byte mode, byte animationIndex, byte param)
	{
	}

	public void SendRollVector(byte dirIndex)
	{
	}

	public void SendEquipment(PlayerInventory inventory, PlayerArms arms)
	{
	}

	public void RequestLoot(int lootID)
	{
	}

	public void SyncShot(int playerlobbyID, Vector3 shotVector)
	{
	}

	public void SyncPlayerHealth(int playerlobbyID, PlayerMain.HealthState health)
	{
	}

	public void SendZombieDamage(Damage dmg, int zombieID)
	{
	}

	public void RequestRespawn(int playerlobbyID)
	{
	}

	public void DropItem(InventoryItem item, Vector3 pos)
	{
	}

	public void SyncFXPropPos(FXProp.ID id, Vector3 pos)
	{
	}

	public void SyncMatchState(MatchController.MatchState state)
	{
	}

	public void SyncLobbyLoadout(int lobbyID, InventoryItem.ID[] itemID)
	{
	}

	public void SyncLobbyLoadoutRequest(int lobbyID)
	{
	}

	public void RequestZombiePropStage(int zombieID)
	{
	}

	public void SyncSkin(int lobbyID, SkinDatabase.SkinID skinID, SkinDatabase.Gender gender, int color)
	{
	}

	public void SyncFurnitureInteraction(IntVec2 coord, int cellID, byte targetState = byte.MaxValue)
	{
	}

	public void SyncUtilitySpawn(int itemID, int localUtilityID, Vector3 pos, Quaternion rot)
	{
	}

	public void SyncUtilityDespawn(int lobbyID, int localUtilityID)
	{
	}

	public void SyncUtilityPos(int lobbyID, int localUtilityID, Vector3 pos, Quaternion rot)
	{
	}

	public void SyncExplosion(int playerLobbyID, Vector3 origin, Explosion.ID id, bool isZombieExplosion)
	{
	}

	public void SyncFurnitureDamage(IntVec2 coord, int cellID, float dmg)
	{
	}

	public void SyncPlayerCoreAudio(int playerID, byte audioID)
	{
	}

	public void SyncPlayerMeleeAudio(int playerID, byte audioID)
	{
	}

	public void SyncImpactSFX(Vector3 pos, byte id)
	{
	}

	public void SyncPlayerName(string newName)
	{
	}

	public void SyncPlayerRevive(int playerID)
	{
	}

	public void SyncGenericAggroSound(float range)
	{
	}
}
