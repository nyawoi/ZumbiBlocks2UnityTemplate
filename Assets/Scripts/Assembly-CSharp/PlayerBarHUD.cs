using UnityEngine;
using UnityEngine.UI;

public class PlayerBarHUD : MonoBehaviour
{
	[SerializeField]
	private Image primaryBarImg;

	[SerializeField]
	private Image secondaryBarImg;

	[SerializeField]
	private float fadeSpeed;

	public void UpdateDisplay(float currentValuePrimary, float currentValueSecondary, float maxValue)
	{
	}
}
