using UnityEngine;

public class AnalyticsController : MonoBehaviour
{
	public static AnalyticsController instance;

	public int zombiesKilled;

	public int riotBossKilled;

	public int queenBossKilled;

	public int matchesPlayed;

	public int deathCount;

	public int clickedSinglePlayer;

	public int clickedMultiPlayer;

	public void Initialize()
	{
	}

	public void OnZombieKilled(Zombie.Type zombieType)
	{
	}

	public void OnClickedSinglePlayer()
	{
	}

	public void OnClickedMultiPlayer()
	{
	}

	public void OnMatchStarted()
	{
	}

	public void OnPlayerDied()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void RaiseSessionEndAnalyticsEvent()
	{
	}
}
