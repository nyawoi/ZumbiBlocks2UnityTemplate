using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentSlot : MonoBehaviour
{
	public RectTransform rTransform;

	public Image bgImg;

	public Image silhoutteIcon;

	public PlayerInputKey.KeyID keyID;

	public TMP_Text keyIDText;

	public bool interactable;

	public void SetHighlight(Color bgColor)
	{
	}

	public void SetIcon(bool active)
	{
	}
}
