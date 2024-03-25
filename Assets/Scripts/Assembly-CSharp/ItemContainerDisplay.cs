using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemContainerDisplay : MonoBehaviour
{
	[Header("Settings")]
	public Color[] slotColor;

	public InventoryDisplay.ContainerType containerType;

	[Header("References")]
	public GridLayoutGroup gridLayoutGroup;

	public RectTransform gridRTransform;

	public GameObject gridSquarePrefab;

	public GameObject spritePrefab;

	public Transform gridTransform;

	public Transform spritesTransform;

	[Header("Runtime")]
	public IntVec2 size;

	private byte[,] gridColor;

	public bool gridInit;

	public List<Image> gridSquare;

	public List<InventoryItemDisplay> itemDisplay;

	[HideInInspector]
	public List<InventoryItem> hoverIntersections;

	public float CellSize => 0f;

	public float CellSpacing => 0f;

	public IntVec2? GetHoverSlot(Vector3 refPos)
	{
		return null;
	}

	public bool FindHoverIntersection(ItemContainer ic, IntVec2 pos, InventoryItem item)
	{
		return false;
	}

	public void UpdateHighlights(ItemContainer ic, IntVec2 pos, InventoryItem item, bool drawHeldItem, bool canDropItem, IntVec2 hoverSlot)
	{
	}

	private int GetIndex(int x, int y)
	{
		return 0;
	}

	public static void ShowItemOnImage(InventoryItemDisplay itemDisplay, DatabaseItem dbItem, bool rotated)
	{
	}

	public void ShowContainter(ItemContainer ic)
	{
	}

	public void InitializeGrid(int width, int height)
	{
	}
}
