using TMPro;
using UnityEngine;

public class LobbyMenu : MonoBehaviour
{
	[Header("UtilsToggle")]
	public string yesString;

	public string noString;

	[Header("Slots")]
	public LobbySlotView[] slots;

	[Header("Refs")]
	public LobbyController lobby;

	public Toggle readyToggle;

	public GameObject startButton;

	public GenericPromptMenu prompt;

	public UISelector difficultySelector;

	public LobbyCodeDisplay lobbyCodeDisplay;

	public GameObject[] difficultySelectorButtons;

	public TMP_Text playerNameText;

	public TMP_InputField playerNameInputField;

	public GameObject changePlayerNamePopUp;

	[Header("Runtime")]
	public float timer;

	public void OnEnable()
	{
	}

	private void UpdatePlayerNameHeader()
	{
	}

	public void OnRequestChangeName()
	{
	}

	public void OnNameChanged()
	{
	}

	public void OnCancelNameChanged()
	{
	}

	public void Update()
	{
	}

	private static void RequestAllMissingLobbyLoadouts()
	{
	}

	public void OnDifficultyChanged()
	{
	}

	public void UpdateAllSlots()
	{
	}

	public void UpdateSingleSlot(int index)
	{
	}

	public void OnSyncLobbyLoadout(int lobbyID, InventoryItem.ID[] items)
	{
	}

	public void OnSyncLobbySkin(int lobbyID)
	{
	}

	public void RefreshAllAnimations()
	{
	}

	public void UpdateToggle(bool b, bool interactable)
	{
	}

	public void OnReadyChanged()
	{
	}

	public void LaunchMatch()
	{
	}

	public void BackToLobby()
	{
	}

	public void QuitLobby()
	{
	}

	public void UpdateLobbyCode()
	{
	}

	public void CopyLobbyIDToClipboard()
	{
	}
}
