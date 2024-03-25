using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemDescription : MonoBehaviour
{
	public GameObject slotPrefab;

	public Transform slotHolder;

	public TMP_Text titleText;

	public Image tierSprite;

	public RectTransform body;

	public Transform descriptionTextArea;

	public TMP_Text descriptionText;

	[Header("Slots")]
	public List<ItemDescriptionSlot> slots;

	public bool built;

	public int visibleSlots;

	[Header("Curves")]
	public AnimationCurve dmgCurve;

	public AnimationCurve ammoCurve;

	public AnimationCurve accuracyCurve;

	public Gradient defaultGradient;

	public Color barColor;

	public Color barLerpColor;

	public Color textLerpColor;

	[Header("Debug")]
	public InventoryItem.ID debugItem;

	public bool showDebugItem;

	public bool qualityInversed;

	public bool alwaysGood;

	public void BuildSlots()
	{
	}

	public void ResetSlots()
	{
	}

	public void DescribeItem(InventoryItem.ID itemID)
	{
	}

	public void SetSlotEnabled(ItemDescriptionSlot.ID id, bool b)
	{
	}

	public void SetSlotEnabled(int index, bool b)
	{
	}

	public void SetSlotCentralized(ItemDescriptionSlot.ID id, string rightText)
	{
	}

	public void SetSlot(ItemDescriptionSlot.ID id, string leftText, string rightText, bool centralize, float stat, Vector2 statRange)
	{
	}

	public void SetSlot(ItemDescriptionSlot.MeleeID id, string leftText, string rightText, bool centralize, float stat, Vector2 statRange)
	{
	}

	public void SetSlot(int index, string leftText, string rightText, bool centralize, float stat, Vector2 statRange)
	{
	}

	public void OnEnable()
	{
	}
}
