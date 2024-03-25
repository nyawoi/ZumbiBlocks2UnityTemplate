using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BaseMenu : MonoBehaviour
{
	public enum ID
	{
		None = 0,
		Main = 1,
		Options = 2,
		Play = 3,
		ServerOptions = 4,
		Spinner = 5,
		Lobby = 6,
		ConnectByIP = 7,
		Prompt = 8,
		GameHUD = 9,
		Inventory = 10,
		EscapeMenu = 11,
		ServerQuitMenu = 12,
		GraphicsMenu = 13,
		ControlMenu = 14,
		KeyBind = 15,
		LoadoutSelection = 16,
		LoadoutUnlocked = 17,
		Map = 18,
		AudioMenu = 19,
		SteamFeaturesWarning = 20,
		ConnectToSteamFriend = 21
	}

	public ID id;

	public bool useLogo;

	public bool useSocials;

	public bool useBlur;

	public bool isInGameMenu;

	public List<PlayerInputKey.KeyID> allowedKeys;

	[Header("ESC")]
	public BaseMenu defaultReturnMenu;

	public UnityEvent escapeAction;

	public virtual void OnEnterMenu()
	{
	}
}
