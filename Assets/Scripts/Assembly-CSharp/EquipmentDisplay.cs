using System.Collections.Generic;
using UnityEngine;

public class EquipmentDisplay : MonoBehaviour
{
	public GameObject spritePrefab;

	public Transform spriteHolder;

	public EquipmentSlot[] equipmentSlot;

	public List<InventoryItemDisplay> itemDisplay;

	[Header("Colors")]
	public Color bgNormalColor;

	public Color iconNormalColor;

	public bool init;

	public void Init()
	{
	}

	public void UpdateHighlights(PlayerInventory targetInventory, int highlightIndex, InventoryItem dropItem)
	{
	}

	public void ShowEquipment(PlayerInventory inventory)
	{
	}
}
