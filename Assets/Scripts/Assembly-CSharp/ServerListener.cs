using UnityEngine;

public class ServerListener : GenericListener
{
	protected override bool IsClientListener()
	{
		return false;
	}

	protected override void OnHandshakeEvent(int connectionID)
	{
	}

	protected override void OnClientAuthAttempt(int connectionID)
	{
	}

	protected override void TreatSyncReady(int lobbyID, bool isReady)
	{
	}

	protected override void TreatCellMeshRequest(int lobbyID, int x, int y)
	{
	}

	protected override void TreatPlayerPositionSync(int lobbyID, Vector3 pos, float angle, byte camAngle, byte fightMode, byte spineCorrectionInput)
	{
	}

	protected override void TreatPlayerAnimation(int lobbyID, bool isArms, byte mode, byte animIndex, byte param)
	{
	}

	protected override void TreatPlayerRollVector(int lobbyID, byte dirIndex)
	{
	}

	protected override void TreatPlayerEquipment(int lobbyID, PlayerMain playerMain)
	{
	}

	protected override void TreatPlayerSkin(int sourceConn, int lobbyID, SkinDatabase.SkinID skinID, SkinDatabase.Gender gender, int color)
	{
	}

	protected override void OnLootRequest(int connectionID)
	{
	}

	protected override void TreatShotEvent(int lobbyID, Vector3 vector)
	{
	}

	protected override void OnZombieDamage(int connectionID)
	{
	}

	protected override void OnRequestRespawnPosition()
	{
	}

	protected override void OnClientLootDrop()
	{
	}

	protected override void TreatFXPropPos(FXProp.ID propID, Vector3 pos, int srcConn)
	{
	}

	protected override void TreatPlayerHealthState(int lobbyID, PlayerMain.HealthState health)
	{
	}

	protected override void TreatLobbyLoadout(int sourceConnID, int lobbyID, InventoryItem.ID[] items)
	{
	}

	protected override void TreatLobbyLoadoutRequest(int lobbyID)
	{
	}

	protected override void TreatBossPropStage(int zombieID, byte stage, byte propState, int targetConnectionID)
	{
	}

	protected override void OnClientFurniInteraction()
	{
	}

	protected override void OnClientFurniDamage()
	{
	}

	protected override void OnGenericAggroSound(int connectionID)
	{
	}

	protected override void OnAddLobbyPlayer()
	{
	}

	protected override void OnRemoveLobbyPlayer()
	{
	}

	protected override void OnClientEntryConfirmed()
	{
	}

	protected override void OnInitialMapInfo()
	{
	}

	protected override void OnPlayerInstantiated()
	{
	}

	protected override void OnCellMeshSync()
	{
	}

	protected override void OnCellMeshVertex()
	{
	}

	protected override void OnCellMeshUV()
	{
	}

	protected override void OnPolygonFencing()
	{
	}

	protected override void OnBuildingBaseData()
	{
	}

	protected override void OnBuildingDoorsAndWindows()
	{
	}

	protected override void OnPolygonVegetation()
	{
	}

	protected override void OnZombieSpawnBatch()
	{
	}

	protected override void OnZombieDeltaPosBatch()
	{
	}

	protected override void OnZombiePosBatch()
	{
	}

	protected override void OnZombieAnimation()
	{
	}

	protected override void OnPlayerDamage()
	{
	}

	protected override void OnCellLootBatch()
	{
	}

	protected override void OnRemoveLoot()
	{
	}

	protected override void OnLootDelivery()
	{
	}

	protected override void OnZombieDeath()
	{
	}

	protected override void OnDeliverRespawnPosition()
	{
	}

	protected override void OnReceiveSingleLootSpawn()
	{
	}

	protected override void OnSingleZombieSpawn()
	{
	}

	protected override void OnReceiveDaytime()
	{
	}

	protected override void OnPlayerEquipmentRequest()
	{
	}

	protected override void OnPolygonBakedTris()
	{
	}

	protected override void OnBuildingFurnitureDecor()
	{
	}

	protected override void OnBuildingYardFurniture()
	{
	}

	protected override void OnPing(int connectionID)
	{
	}

	protected override void OnMatchSettings()
	{
	}

	protected override void OnDCMsg()
	{
	}

	protected override void OnMapSilhouette()
	{
	}

	protected override void OnBossAction()
	{
	}

	protected override void OnInterFurnitureData()
	{
	}

	protected override void OnZombieAudio()
	{
	}

	protected override void OnZombieAttackAudio()
	{
	}

	protected override void OnFurnitureAudio()
	{
	}

	protected override void OnBuildingFloorGrid()
	{
	}

	protected override void OnBuildingFloorRooms()
	{
	}
}
