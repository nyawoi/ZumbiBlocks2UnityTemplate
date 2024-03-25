public class NetConnectionMessage
{
	public enum SubType : byte
	{
		HandShake = 0,
		Auth = 1,
		ConfirmEntry = 2,
		SyncReady = 3,
		AddLobbyPlayer = 4,
		RemoveLobbyPlayer = 5,
		Ping = 6,
		DCMsg = 7,
		PlayerName = 8
	}

	public static void Handshake(Buffer buffer)
	{
	}

	public static void AddLobbyPlayer(Buffer buffer, int lobbyID)
	{
	}

	public static void RemoveLobbyPlayer(Buffer buffer, int lobbyID, bool removeObj)
	{
	}

	public static void ConfirmClientEntry(Buffer buffer, int lobbyID)
	{
	}

	public static void SyncReady(Buffer buffer, int lobbyID, bool readyState)
	{
	}

	public static void Ping(Buffer buffer, int requestID)
	{
	}

	public static void DCMsg(Buffer buffer, DisconnectionReason msgID)
	{
	}

	public static void PlayerName(Buffer buffer, int lobbyID, string playerName)
	{
	}
}
