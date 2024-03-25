using UnityEngine;

public class NetEntityMessage
{
	public enum SubType : byte
	{
		UtilitySpawn = 0,
		UtilitySync_UNUSED = 1,
		UtilityDespawn = 2,
		UtilityPosSync = 3,
		SyncExplosion = 4
	}

	public static void UtilitySpawn(Buffer buffer, byte itemID, int lobbyID, int localUtilityID, Vector3 pos, Quaternion rotation)
	{
	}

	public static void UtilityDespawn(Buffer buffer, int lobbyID, int localUtilityID)
	{
	}

	public static void UtilityPosSync(Buffer buffer, int lobbyID, int localUtilityID, Vector3 pos, Quaternion q)
	{
	}

	public static void SyncExplosion(Buffer buffer, int playerLobbyID, Vector3 origin, Explosion.ID explosionID, bool isZombieExplosion)
	{
	}
}
