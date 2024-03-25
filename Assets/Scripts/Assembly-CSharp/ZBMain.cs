using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ZBMain : MonoBehaviour
{
	public static ZBMain instance;

	public string gameVersion;

	public string myUniqueID;

	[Header("References")]
	public MainCamera mainCamera;

	public DeveloperConsole console;

	public CommandLine cmd;

	public MenuController menu;

	public MatchController match;

	public MultiplayerController multiplayer;

	public TranslationController translations;

	public Map map;

	public AuxiliarMapObjects auxiliarObjs;

	public DaytimeController daytime;

	public Log log;

	public DatabaseController db;

	public EntityController entityController;

	public PersistenceController persistence;

	public FPSAndStatistics fpsCounter;

	public MapRendering mapRendering;

	public StartScreens startScreen;

	public AudioController audio;

	public CinematicCameraController cinematicCamera;

	public ServerMonitoring serverMonitoring;

	public AnalyticsController analyticsController;

	public SteamController steam;

	public PhysicsController physics;

	[Header("Canvas Canvas")]
	public GameObject canvasObject;

	public GameObject canvas3DObject;

	public GameObject canvasAltObject;

	public CanvasScaler canvasScaler;

	private bool canvasEnabled;

	[Header("Settings")]
	public TMP_Text versionText;

	public Transform baseCamPosition;

	public bool debugEnabled;

	[Header("Runtime")]
	public bool mapIsLoaded;

	public int argsTimer;

	public SavePreferences prefs;

	public void Start()
	{
	}

	public void DisplayConsole(bool show)
	{
	}

	public void Update()
	{
	}

	private void RunCommandLineArgs()
	{
	}

	public void OnEnteredMap()
	{
	}

	public void CleanUp(bool cleanUpLobby)
	{
	}

	public void ResetCamera()
	{
	}

	public bool ChangePlayerName(string newName)
	{
		return false;
	}

	public void OnQuitButton()
	{
	}

	public void QuitToDesktop()
	{
	}

	private void OnApplicationQuit()
	{
	}
}
