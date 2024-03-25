using System.Collections.Generic;
using UnityEngine;

public class LobbyController : MonoBehaviour
{
	public static LobbyController instance;

	public LobbyMenu lobbyMenu;

	public Color[] playerColor;

	[Header("Runtime")]
	public int idGen;

	public List<LobbyPlayer> players;

	public int GetSelectedDifficulty => 0;

	public Color GetPlayerColor(byte b)
	{
		return default(Color);
	}

	public void Initialize()
	{
	}

	public byte PullPlayerColor()
	{
		return 0;
	}

	public void CleanUp()
	{
	}

	public void StartLobby()
	{
	}

	public void SetIngamePlayers()
	{
	}

	public int AddPlayer(SteamP2PConnection connection, string playerName, SkinDatabase.SkinID skinID, SkinDatabase.Gender skinGender, int skinColor, bool applyLoadout)
	{
		return 0;
	}

	public void RemovePlayer(int index)
	{
	}

	public void RemovePlayerByLobbyID(int lobbyID)
	{
	}

	private int PullID()
	{
		return 0;
	}

	public LobbyPlayer GetPlayerByLobbyID(int lobbyID)
	{
		return null;
	}

	public LobbyPlayer GetPlayerByConnectionID(int connectionID)
	{
		return null;
	}

	public int GetInGamePlayerCount()
	{
		return 0;
	}

	public int GetPlayerIndex(int lobbyID)
	{
		return 0;
	}

	public int GetPlayerIndex(SteamP2PConnection conn)
	{
		return 0;
	}

	public void SetPlayerReady(int lobbyID, bool isReady)
	{
	}

	public void SetMyPlayerName(string playerName)
	{
	}

	public void SetPlayerName(int lobbyID, string playerName)
	{
	}

	public void ClearLobby()
	{
	}
}
