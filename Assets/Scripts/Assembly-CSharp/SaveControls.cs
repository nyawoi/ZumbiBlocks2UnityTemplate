using System;
using UnityEngine;

[Serializable]
public class SaveControls
{
	public float sensitivity;

	public KeyCode[] keyBinds;

	public float AdaptedSensitivity => 0f;

	public void ApplyControls(SaveControls refControls)
	{
	}
}
