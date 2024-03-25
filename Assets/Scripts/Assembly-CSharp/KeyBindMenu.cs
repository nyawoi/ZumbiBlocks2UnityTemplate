using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyBindMenu : MonoBehaviour
{
	public ControlsMenu controls;

	public TMP_Text centerText;

	public PlayerInputKey.KeyID targetKeyID;

	public List<KeyCode> forbiddenKeys;

	public int frameCounter;

	public void StartKeyBinding(PlayerInputKey.KeyID keyID)
	{
	}

	public void Update()
	{
	}

	private void ListenToKey()
	{
	}

	public void OnCancel()
	{
	}
}
