using System.Collections.Generic;
using UnityEngine;

public class PlayersController : MonoBehaviour
{
	public GameObject playerPrefab;

	public Transform holder;

	public static PlayersController instance;

	public List<PlayerMain> players;

	public int PlayerCount => 0;

	public void CleanUp()
	{
	}

	public void Init()
	{
	}

	public void Suicide()
	{
	}

	public void DeletePlayer(PlayerMain p)
	{
	}

	public void DeletePlayer(int lobbyID)
	{
	}

	public PlayerMain InstantiatePlayer(LobbyPlayer lobbyPlayer)
	{
		return null;
	}

	public PlayerMain GetPlayer(int lobbyID)
	{
		return null;
	}

	public int GetPlayerIndex(PlayerMain pm)
	{
		return 0;
	}

	public PlayerMain GetMyPlayer()
	{
		return null;
	}

	public List<InteractableObject> ReviveInteractions(PlayerMain me)
	{
		return null;
	}
}
