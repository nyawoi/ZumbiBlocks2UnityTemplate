using System.Collections.Generic;
using UnityEngine;

public class PlayerInputReader : MonoBehaviour
{
	[Header("Settings")]
	public float mouseSensitivityVert;

	public PlayerInputKey[] keys;

	public List<PlayerInputKey.KeyID> menuKey;

	[Header("Runtime")]
	public float mouseX;

	public float mouseY;

	public float MouseX => 0f;

	public float MouseY => 0f;

	public bool GetRoll()
	{
		return false;
	}

	public bool GetVault()
	{
		return false;
	}

	public void MyUpdate()
	{
	}

	public bool IsMovementMenu()
	{
		return false;
	}

	public bool IsMovementMenu(PlayerInputKey.KeyID keyID, bool testAllowedKeys = true)
	{
		return false;
	}

	public bool NotInputBlocked()
	{
		return false;
	}

	public bool GetKey(KeyCode keyID)
	{
		return false;
	}

	public bool GetKeyDown(KeyCode keyID)
	{
		return false;
	}

	public bool GetKey(PlayerInputKey.KeyID keyID)
	{
		return false;
	}

	public bool GetKeyDown(PlayerInputKey.KeyID keyID)
	{
		return false;
	}

	public static PlayerInputReader FindMyInputRead()
	{
		return null;
	}
}
