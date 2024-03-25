using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BossNameDisplay : MonoBehaviour
{
	public enum State
	{
		Entry = 0,
		Hold = 1,
		Exit = 2,
		Off = 3
	}

	public TMP_Text descriptionText;

	public TMP_Text nameText;

	public TMP_Text escText;

	public Image panelImg;

	public RectTransform descriptionTransform;

	public RectTransform nameTransform;

	public RectTransform panelTransform;

	[Header("Settings")]
	public float panelAlpha;

	public float entrySpeed;

	public float exitSpeed;

	public float textSideDistance;

	[Header("Runtime")]
	public State state;

	public float timer;

	public float totalTimer;

	public float duration;

	public string descTag;

	public string bossNameTag;

	public void Translate()
	{
	}

	public void StartDislay(string descTag_, string bossNameTag_, float duration_)
	{
	}

	public void UpdateDisplay()
	{
	}

	public void DisableAll()
	{
	}

	public void EnableAll()
	{
	}

	public void SetTextPosition()
	{
	}

	public void SetPanelFill()
	{
	}

	public void SetPanelAlpha(float a)
	{
	}
}
