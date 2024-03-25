using TMPro;
using UnityEngine;

public class ServerMonitoring : MonoBehaviour
{
	public static ServerMonitoring Instance;

	[Header("Data")]
	private int loadedZombies;

	private int zombieSightRaycasts;

	private float zombieRaycastTimer;

	[Header("UI")]
	[SerializeField]
	private TMP_Text loadedZombiesText;

	[SerializeField]
	private TMP_Text zombiesRaycastText;

	public int LoadedZombies
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public void AddZombieSightRaycast()
	{
	}

	private void SetText(TMP_Text text, string value)
	{
	}

	public void Initialize()
	{
	}

	private void Update()
	{
	}
}
