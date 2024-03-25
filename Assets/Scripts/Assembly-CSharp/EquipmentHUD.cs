using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentHUD : MonoBehaviour
{
	public RectTransform equipPanelTransform;

	public RectTransform equipImgTransform;

	public Image equipImg;

	public TMP_Text ammoText;

	private int lastDisplayedAmmo;

	private int lastDisplayedAmmoForGun;

	public void UpdateDisplay(PlayerMain targetPlayer)
	{
	}
}
