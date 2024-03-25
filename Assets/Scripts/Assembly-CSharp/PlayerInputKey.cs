using System;
using UnityEngine;

[Serializable]
public class PlayerInputKey
{
	public enum KeyID
	{
		MoveForward = 0,
		MoveBack = 1,
		MoveLeft = 2,
		MoveRight = 3,
		Jump = 4,
		Run = 5,
		Shoot = 6,
		Aim = 7,
		SelectPrimary = 8,
		SelectSecondary = 9,
		SelectMelee = 10,
		Holster = 11,
		Inventory = 12,
		Reload = 13,
		Interact = 14,
		ChangeCameraShoulder = 15,
		SelectThrowable = 16,
		SelectConsumable = 17,
		Map = 18,
		CameraMode = 19,
		SelectHealing = 20,
		Roll = 21,
		Butting = 22
	}

	public bool getKey;

	public bool getKeyDown;

	public void Process(KeyCode keyCode)
	{
	}

	public void Zero()
	{
	}
}
