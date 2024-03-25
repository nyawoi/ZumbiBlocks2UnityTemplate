using UnityEngine;

public class MatchController : MonoBehaviour
{
	public enum MatchState
	{
		Off = 0,
		Lobby = 1,
		GeneratingMap = 2,
		InGame = 3,
		GameOver = 4,
		ReturningToLobby = 5
	}

	public static MatchController instance;

	[Header("References")]
	public LobbyController lobby;

	public SpinnerMenu spinnerMenu;

	public RespawnPoints respawn;

	public LootController loot;

	public LoadoutSelector loadout;

	public LoadoutUnlocker loadoutUnlocker;

	public BossfightController boss;

	public GlobalInteractionController interactionController;

	[Header("Runtime")]
	public MatchState state;

	public float generalPurposeTimer;

	[Header("Singleplayer lives")]
	public int lives;

	[Header("Difficulty settings")]
	public float timeMultiplier;

	public float[] difficultyTimeMinutes;

	public string[] difficultyName;

	public AnimationCurve zombieLevelCurve;

	public AnimationCurve zombieCountCurve;

	public float zombieCountMultiplier;

	[Header("Difficulty and time")]
	public int selectedDiffculty;

	public float difficultyTimer;

	public float gameTimer;

	public int zombieLevel;

	[Header("Stats")]
	public int zombieKills;

	[Header("Special")]
	public bool dovesCakeAvailable;

	public static bool InGame => false;

	public static int defaultSingleplayerLives => 0;

	public void Init()
	{
	}

	public void CleanUp()
	{
	}

	public void SetState(MatchState s)
	{
	}

	public void CountTimes()
	{
	}

	public int GetDifficultyIndex()
	{
		return 0;
	}

	public float GetZombieCountMultiplier()
	{
		return 0f;
	}

	public float GetZombieRespawnTimeInSeconds()
	{
		return 0f;
	}

	public int GetZombieLevel()
	{
		return 0;
	}

	public void StartMatch(int difficulty)
	{
	}

	public void OnMapGenerated()
	{
	}

	private void EnterMatchState()
	{
	}

	private void SpawnPlayer(LobbyPlayer lobbyPlayer)
	{
	}

	public void SyncPlayerSpawn(int lobbyID, Vector3 pos, float rotation, SkinDatabase.SkinID skinID, SkinDatabase.Gender skinGender, int skinColor)
	{
	}

	public PlayerMain SpawnPlayerWithLobbyReference(LobbyPlayer lobbyPlayer)
	{
		return null;
	}

	public void Update()
	{
	}

	public void SetHostInGame(bool inGame)
	{
	}

	public bool ThereArePlayerInGame()
	{
		return false;
	}

	public void EnterGameOver()
	{
	}

	public void PlayerConfirmedLobbyState(int connectionID)
	{
	}
}
