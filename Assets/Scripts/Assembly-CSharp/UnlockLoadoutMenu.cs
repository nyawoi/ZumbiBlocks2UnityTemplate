using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLoadoutMenu : BaseMenu
{
	public enum State
	{
		Entry = 0,
		Hold = 1,
		Exit = 2,
		Off = 3
	}

	[Header("Texts")]
	public TMP_Text titleText;

	public TMP_Text itemNameText;

	public TMP_Text itemTierText;

	public RectTransform itemTransform;

	public Image itemSprite;

	public Image[] panelImg;

	[Header("Settings")]
	public float panelAlpha;

	public float entrySpeed;

	public float exitSpeed;

	public float duration;

	[Header("Runtime")]
	public State state;

	public float timer;

	public float totalTimer;

	public void StartDislay(LoadoutUnlockable unlocked, int tier)
	{
	}

	public void Update()
	{
	}

	public void DisableAll()
	{
	}

	public void EnableAll()
	{
	}

	public void SetPanelFill()
	{
	}

	public void SetPanelAlpha(float a)
	{
	}

	private void SetTextAlpha(TMP_Text text, float a)
	{
	}

	private void SetImgAlpha(Image img, float a)
	{
	}
}
