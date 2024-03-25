using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadoutSelectionSlotUI : MonoBehaviour
{
	public LoadoutSelector.SlotID slotID;

	public GameObject backButton;

	public GameObject forwardButton;

	public Image spriteIMG;

	public RectTransform spriteTransform;

	public Image lockIMG;

	public Image tierIMG;

	public TMP_Text itemNameText;

	public TMP_Text unlockedCountText;

	public int maxOptions;

	public void UpdateMaxOptions(int max)
	{
	}

	public void UpdateDisplay(LoadoutSelectionScreen screen, List<LoadoutUnlockable> slotOptions, int selected)
	{
	}

	private void SetSprite(Sprite sprt)
	{
	}

	public void SelectBack()
	{
	}

	public void SelectForward()
	{
	}
}
