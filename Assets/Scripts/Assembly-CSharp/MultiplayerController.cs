using UnityEngine;

public class MultiplayerController : MonoBehaviour
{
	public static MultiplayerController instance;

	[Header("References")]
	public ServerController server;

	public ClientController client;

	public LobbyController lobby;

	public SteamConnectionsController connections;

	public bool IsMultiplayer => false;

	public int GetMyLobbyID()
	{
		return 0;
	}

	public string GetLobbyCode()
	{
		return null;
	}

	public void PrintDownload()
	{
	}

	public void PrintUpload()
	{
	}

	public void PrintStatistic()
	{
	}

	public LobbyPlayer GetMySlottedPlayer()
	{
		return null;
	}

	public void Init()
	{
	}

	public bool IsServer()
	{
		return false;
	}

	public bool IsOnlineServer()
	{
		return false;
	}

	public bool IsOfflineServer()
	{
		return false;
	}

	public bool IsClient()
	{
		return false;
	}
}
