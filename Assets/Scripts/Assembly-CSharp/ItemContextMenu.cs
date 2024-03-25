using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemContextMenu : MonoBehaviour
{
	public InventoryDisplay targetDisplay;

	public TMP_Text titleText;

	public Image tierSprite;

	public TranslationGroup translationGroup;

	public Button splitButton;

	public Button unloadButton;

	public Button dropButton;

	private InventoryItem targetItem;

	public void ContextFor(InventoryItem item)
	{
	}

	public void Split()
	{
	}

	public void Unload()
	{
	}

	public void Drop()
	{
	}
}
