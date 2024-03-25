using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
	[Serializable]
	public class TaskPack
	{
		public List<TaskID> ids;
	}

	[Serializable]
	public class TaskProgress
	{
		public float maxProgress;

		public string descriptionTag;

		public PlayerInputKey.KeyID displayKey;

		public float progress;

		public bool Done => false;
	}

	public enum TaskID
	{
		WalkF = 0,
		WalkB = 1,
		WalkL = 2,
		WalkR = 3,
		Sprint = 4,
		Jump = 5,
		Aim = 6,
		Roll = 7,
		Loot = 8,
		Inventory = 9,
		SelectGun = 10,
		Reload = 11,
		Shoot = 12,
		OpenMap = 13,
		KillBoss = 14,
		SwapCameraMode = 15,
		SwapCameraSide = 16,
		Punch = 17,
		DealMelee = 18
	}

	public static TutorialController instance;

	public TMP_Text title;

	public ControlsMenu controls;

	public TaskPack[] packs;

	public TaskUI[] taskUI;

	public int curTutorialVersion;

	[Header("Runtime")]
	public int curPack;

	public TaskProgress[] taskProgress;

	public bool update;

	public float taskDoneTimer;

	private List<TaskID> dontShowButtonIds;

	public bool IsDoingTutorial => false;

	public void Init()
	{
	}

	public void SetTutorial(int packNumber, int version = -1)
	{
	}

	public void Update()
	{
	}

	private void AddProgress(TaskID taskID, float amount)
	{
	}

	public void FinishPacks()
	{
	}

	public void CheckProgress()
	{
	}

	public void OnJump()
	{
	}

	public void OnRoll()
	{
	}

	public void OnLoot()
	{
	}

	public void OnReload()
	{
	}

	public void OnShoot()
	{
	}

	public void OnOpenedMap()
	{
	}

	public void OnKilledBoss()
	{
	}

	public void OnPunchedAZombie()
	{
	}

	public void OnButted()
	{
	}

	public void OnChangedCameraMode()
	{
	}

	public void OnChangedCameraShoulder()
	{
	}

	public void UpdateAll()
	{
	}

	public string GetButtonString(TaskID taskID)
	{
		return null;
	}
}
