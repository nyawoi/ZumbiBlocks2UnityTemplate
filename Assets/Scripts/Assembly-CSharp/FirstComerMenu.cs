using TMPro;
using UnityEngine;

public class FirstComerMenu : MonoBehaviour
{
	public static FirstComerMenu instance;

	[Header("Menu")]
	public StartScreens starterScreens;

	public GameObject nameTooShortpanel;

	public TMP_InputField inputField;

	public IconButton confirmButton;

	public SettingsSelector languageSelector;

	private const int minNameSize = 3;

	public void Init()
	{
	}

	public void Launch()
	{
	}

	private void FillWithSteamName()
	{
	}

	public static bool IsNameValid(string name)
	{
		return false;
	}

	public void OnInputUpdate()
	{
	}

	public void OnLanguageChanged()
	{
	}

	public void Confirm()
	{
	}
}
