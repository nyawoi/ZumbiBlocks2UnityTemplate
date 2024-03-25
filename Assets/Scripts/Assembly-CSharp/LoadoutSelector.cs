using System;
using System.Collections.Generic;
using UnityEngine;

public class LoadoutSelector : MonoBehaviour
{
	[Serializable]
	public class SlotOptions
	{
		public SlotID id;

		public List<LoadoutUnlockable> options;
	}

	public enum SlotID
	{
		Primary = 0,
		Secondary = 1,
		Melee = 2,
		Utility = 3,
		Tool = 4,
		Resources = 5,
		Skin = 6,
		COUNT = 7
	}

	public static LoadoutSelector instance;

	public const int loadoutVisualPackSize = 5;

	public SkinSelectionSlot skinSelectionSlot;

	public LoadoutSelectionScreen loadoutSelectionUI;

	public SlotID[] itemIDtoSlotID;

	[Header("Selected")]
	public int[] selectedLoadout;

	public PreferredLoadout[] preferredLoadout;

	[Header("Loadout Options")]
	public SlotOptions[] slotOptions;

	[Header("Unlocked")]
	public List<LoadoutUnlockable.ID> unlockedLoot;

	public int[] countPerType;

	private InventoryItem.ID[] lastLobbyLoadout;

	public void Init()
	{
	}

	public void UnselectAll()
	{
	}

	public void SetUnlockedLoot(List<LoadoutUnlockable.ID> unlockedList)
	{
	}

	public void UnlockAll()
	{
	}

	public void SetPreferredLoadoutAndSkin(SaveProgress saveProgress)
	{
	}

	public void SetPreferredLoadout()
	{
	}

	public void CountTypes()
	{
	}

	public void ListOptions()
	{
	}

	private int GetOptionIndex(LoadoutUnlockable.ID unlockableID, SlotOptions slotOp)
	{
		return 0;
	}

	private void SelectedPreferredloadout()
	{
	}

	public void OnChangedSkin(int gender, int color)
	{
	}

	public void ChangeSelectedSlot(SlotID slotID, int add)
	{
	}

	public void ApplyLoadoutToLobby()
	{
	}

	public void SyncLobbyLoadout(int lobbyID)
	{
	}

	private InventoryItem.ID GetPropID(SlotID slotID)
	{
		return default(InventoryItem.ID);
	}

	public void ApplyLoadout(PlayerInventory inventory)
	{
	}
}
