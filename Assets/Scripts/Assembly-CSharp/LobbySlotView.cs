using TMPro;
using UnityEngine;

public class LobbySlotView : MonoBehaviour
{
	public TMP_Text playerName;

	public Transform characterPivot;

	[Header("Physical stuff")]
	public CharacterSkin spawnedSkin;

	public EquippedProp[] loadoutProp;

	public InventoryItem.ID lastItemAnimation;

	public void UpdateWith(LobbyPlayer player, string y, string x)
	{
	}

	private void SpawnPlayerSkin(LobbyPlayer player)
	{
	}

	public void Hide()
	{
	}

	public void UpdateSkin(LobbyPlayer player)
	{
	}

	public InventoryItem.ID[] GetLoadoutFromProps()
	{
		return null;
	}

	public void UpdateWithLoadout(InventoryItem.ID[] items)
	{
	}

	public void UpdateHandItemAndAnimation(InventoryItem.ID[] items)
	{
	}

	private void FailedToUpdateHandItemAndAnimation(int loadoutSize, int itemIndex)
	{
	}

	public void UpdateAnimation(InventoryItem.ID handItem, bool forcePlay = false)
	{
	}

	public void UpdateProps(InventoryItem.ID[] items)
	{
	}
}
