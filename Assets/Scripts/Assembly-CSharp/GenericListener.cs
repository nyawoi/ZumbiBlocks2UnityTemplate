using UnityEngine;

public abstract class GenericListener
{
	private const bool LogSubTypes = false;

	protected Buffer readBuffer;

	private void LogSubType(string subType)
	{
	}

	private void OnDataEvent(int connectionID)
	{
	}

	private void OnAudioPacket(int connectionID)
	{
	}

	private void OnEntityPacket()
	{
	}

	private void OnMatchPacket(int connectionID)
	{
	}

	private void OnCharacterPacket(int connectionID)
	{
	}

	private void OnMapPacket()
	{
	}

	private void OnConnectionPacket(int connectionID)
	{
	}

	protected abstract bool IsClientListener();

	internal void OnPacketReceived(byte[] data, int connectionID)
	{
	}

	protected abstract void OnReceiveDaytime();

	private void OnFXPropPos(int connID)
	{
	}

	private void OnLobbyLoadout(int connID)
	{
	}

	protected abstract void TreatLobbyLoadout(int sourceConnID, int lobbyID, InventoryItem.ID[] items);

	private void OnLobbyLoadoutRequest()
	{
	}

	private void OnUnlockLoadout()
	{
	}

	private void OnPlayerSkin(int connID)
	{
	}

	protected abstract void TreatPlayerSkin(int sourceConnID, int lobbyID, SkinDatabase.SkinID skinID, SkinDatabase.Gender gender, int color);

	private void OnKilledBoss()
	{
	}

	protected abstract void TreatLobbyLoadoutRequest(int lobbyID);

	private void OnMatchState(int connectionID)
	{
	}

	protected abstract void OnMatchSettings();

	protected abstract void TreatFXPropPos(FXProp.ID propID, Vector3 pos, int srcConn);

	protected abstract void OnAddLobbyPlayer();

	protected abstract void OnRemoveLobbyPlayer();

	protected abstract void OnHandshakeEvent(int connectionID);

	protected abstract void OnClientAuthAttempt(int connectionID);

	protected abstract void OnClientEntryConfirmed();

	protected abstract void OnReceiveSingleLootSpawn();

	protected abstract void OnPing(int connectionID);

	protected abstract void OnDCMsg();

	private void OnPlayerName(int connectionID)
	{
	}

	private void OnSyncReady()
	{
	}

	protected abstract void TreatSyncReady(int lobbyID, bool isReady);

	private void OnUtilitySpawn()
	{
	}

	private void OnUtilityDespawn()
	{
	}

	private void OnUtilityPosSync()
	{
	}

	private void OnExplosion()
	{
	}

	private void OnPlayerPositionSync()
	{
	}

	protected abstract void TreatPlayerPositionSync(int lobbyID, Vector3 pos, float angle, byte camAngle, byte fightMode, byte spineCorrectionInput);

	private void OnPlayerHealthState()
	{
	}

	protected abstract void TreatPlayerHealthState(int lobbyID, PlayerMain.HealthState health);

	protected abstract void OnBossAction();

	private void OnBossPropStage(int connectionID)
	{
	}

	protected abstract void TreatBossPropStage(int zombieID, byte stage, byte propState, int connectionID);

	protected abstract void OnGenericAggroSound(int connectionID);

	private void OnBossHealth()
	{
	}

	private void OnBossShot()
	{
	}

	private void OnPlayerRevive()
	{
	}

	private void OnPlayerAnimation()
	{
	}

	protected abstract void TreatPlayerAnimation(int lobbyID, bool isArms, byte mode, byte animIndex, byte param);

	private void OnShotEvent()
	{
	}

	protected abstract void TreatShotEvent(int lobbyID, Vector3 vector);

	private void OnPlayerEquipment()
	{
	}

	protected abstract void OnPlayerEquipmentRequest();

	protected abstract void TreatPlayerEquipment(int lobbyID, PlayerMain playerMain);

	protected abstract void OnPlayerDamage();

	private void OnPlayerRollVector()
	{
	}

	protected abstract void TreatPlayerRollVector(int lobbyID, byte dirIndex);

	protected abstract void OnRequestRespawnPosition();

	protected abstract void OnDeliverRespawnPosition();

	protected abstract void OnLootRequest(int connectionID);

	protected abstract void OnLootDelivery();

	protected abstract void OnClientLootDrop();

	protected abstract void OnRemoveLoot();

	protected abstract void OnZombieDamage(int connectionID);

	protected abstract void OnZombieDeath();

	protected abstract void OnZombieSpawnBatch();

	protected abstract void OnZombieDeltaPosBatch();

	protected abstract void OnZombiePosBatch();

	protected abstract void OnSingleZombieSpawn();

	protected abstract void OnZombieAnimation();

	protected abstract void OnInitialMapInfo();

	protected abstract void OnPlayerInstantiated();

	private void OnCellMeshRequest()
	{
	}

	protected abstract void TreatCellMeshRequest(int lobbyID, int x, int y);

	protected abstract void OnCellMeshSync();

	protected abstract void OnCellMeshVertex();

	protected abstract void OnCellMeshUV();

	protected abstract void OnCellLootBatch();

	protected abstract void OnPolygonFencing();

	protected abstract void OnPolygonBakedTris();

	protected abstract void OnBuildingBaseData();

	protected abstract void OnBuildingFloorGrid();

	protected abstract void OnBuildingDoorsAndWindows();

	protected abstract void OnBuildingFurnitureDecor();

	protected abstract void OnBuildingYardFurniture();

	protected abstract void OnPolygonVegetation();

	protected abstract void OnMapSilhouette();

	protected abstract void OnInterFurnitureData();

	protected abstract void OnClientFurniInteraction();

	protected abstract void OnClientFurniDamage();

	protected abstract void OnBuildingFloorRooms();

	protected abstract void OnZombieAudio();

	protected abstract void OnZombieAttackAudio();

	private void OnPlayerCoreAudio()
	{
	}

	private void OnPlayerMeleeAudio()
	{
	}

	protected abstract void OnFurnitureAudio();

	private void OnImpactSFX(int connection)
	{
	}
}
