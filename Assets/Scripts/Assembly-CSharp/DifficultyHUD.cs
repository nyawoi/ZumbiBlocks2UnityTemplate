using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyHUD : MonoBehaviour
{
	public Image diffBar;

	public Image bloodMoonIcon;

	public TMP_Text diffText;

	public TMP_Text timeText;

	public int lastDiffIndex;

	public bool lastBloodmoon;

	public TMP_Text killsText;

	public float bloodMoonTimer;

	public void Translate()
	{
	}

	public void UpdateDisplay()
	{
	}

	public string GetFormattedTime(int time)
	{
		return null;
	}
}
