using System;

[Serializable]
public class LobbyPlayer
{
	public enum Type
	{
		Host = 0,
		Client = 1
	}

	public enum Status
	{
		NotReady = 0,
		Ready = 1,
		InGame = 2
	}

	public int lobbyID;

	public Type type;

	public SteamP2PConnection connection;

	public string playerName;

	public byte colorCode;

	public SkinDatabase.SkinID skinID;

	public SkinDatabase.Gender skinGender;

	public int skinColor;

	public bool isReady;

	public bool inGame;

	public PlayerMain playerObj;

	public int ping;

	public bool updatedLobbyLoadout;

	public bool ItsMe()
	{
		return false;
	}
}
