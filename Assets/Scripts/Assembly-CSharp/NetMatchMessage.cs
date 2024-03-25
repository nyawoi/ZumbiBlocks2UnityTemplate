using UnityEngine;

public class NetMatchMessage
{
	public enum SubType : byte
	{
		Daytime = 0,
		FXPropPos = 1,
		MatchState = 2,
		Settings = 3,
		LobbyLoadout = 4,
		LobbyLoadoutRequest = 5,
		UnlockLoadout = 6,
		KilledBoss = 7
	}

	public static void DaytimeSync(Buffer buffer, float daytime, float difficulty, float gameTime)
	{
	}

	public static void FXPropSync(Buffer buffer, FXProp.ID id, Vector3 pos)
	{
	}

	public static void MatchStateSync(Buffer buffer, MatchController.MatchState state)
	{
	}

	public static void MatchSettingsSync(Buffer buffer, int difficulty)
	{
	}

	public static void LobbyLoadout(Buffer buffer, int lobbyID, InventoryItem.ID[] itemID)
	{
	}

	public static void LobbyLoadoutRequest(Buffer buffer, int lobbyID)
	{
	}

	public static void UnlockLoadout(Buffer buffer, int tier)
	{
	}

	public static void KilledBoss(Buffer buffer)
	{
	}
}
