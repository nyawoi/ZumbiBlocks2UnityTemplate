using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
	public enum CamPivotID
	{
		Base = 0,
		Lobby = 1
	}

	public static MenuController instance;

	public InGameMenuController inGameMenus;

	public List<BaseMenu> allMenus;

	public GameObject logo;

	public GameObject socials;

	public Image blurImage;

	public GameObject menuBackgroundObjects;

	public GameObject gameHUDPanel;

	public GameObject lobbyObjects;

	public GameObject lobbyCanvas;

	[Header("Required specific refs")]
	public GenericPromptMenu prompt;

	public PlayerHUD hud;

	public InventoryDisplay inventory;

	public FirstComerMenu firstComer;

	[Header("Camera")]
	public Transform camTransform;

	public Transform[] campivot;

	[Header("Runtime")]
	public BaseMenu curMenu;

	public BaseMenu.ID curMenuID;

	public BaseMenu.ID returnMenuID;

	public void Update()
	{
	}

	public void OnPressEscape()
	{
	}

	public void Init()
	{
	}

	public void SetCameraTo(CamPivotID id)
	{
	}

	public void SetBGObjects(bool act)
	{
	}

	public void GoToMenu(BaseMenu targetMenu)
	{
	}

	public void GoToMenu(BaseMenu.ID id)
	{
	}

	public void SetReturnMenu(BaseMenu.ID id)
	{
	}

	public void SetReturnMenu()
	{
	}

	public void BackToReturnMenu()
	{
	}
}
