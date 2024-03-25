using UnityEngine;

public class ControlsMenu : MonoBehaviour
{
	[Header("Settings")]
	public SaveControls controls;

	public KeyBindMenu keyBindMenu;

	[Header("UI Refs")]
	public ZBExpSlider mouseSenseSlider;

	public KeyBindUISlot[] keybindUISlot;

	public void UpdateAll()
	{
	}

	public void OnEnable()
	{
	}

	public void StartKeyBinding(PlayerInputKey.KeyID keyID)
	{
	}

	public void SetKeyTo(PlayerInputKey.KeyID keyID, KeyCode keyCode)
	{
	}

	public void LeaveControls()
	{
	}
}
