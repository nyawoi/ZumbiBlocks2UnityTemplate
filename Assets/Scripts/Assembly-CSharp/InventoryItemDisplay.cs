using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemDisplay : MonoBehaviour
{
	public RectTransform rTransform;

	public Image img;

	public Shadow shadow;

	public TMP_Text tmpText;

	public RectTransform tmpTextTransform;

	public float gridSquareSize;

	[Header("Runtime")]
	public InventoryItem.ID itemID;

	public InventoryDisplay.ContainerType containerType;

	public int itemIndex;

	public void SetItem(InventoryItem.ID id, InventoryDisplay.ContainerType cType, int index)
	{
	}

	public void Clone(InventoryItemDisplay display)
	{
	}

	public void ShowItem(DatabaseItem dbItem, bool rotated, int numericValue, RectTransform equipmentSlotBG = null)
	{
	}
}
