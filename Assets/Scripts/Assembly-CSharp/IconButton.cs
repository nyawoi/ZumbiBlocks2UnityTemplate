using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class IconButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	public bool interactable;

	public bool interectableAffectsColor;

	[Header("Settings")]
	public Color bgColor1;

	public Color bgColor2;

	public float darken;

	public Vector3 scaleUp;

	[Header("References")]
	public Image iconImage;

	public Image bgImage;

	public RectTransform bg;

	public TMP_Text text;

	public UnityEvent buttonAction;

	[Header("Runtime")]
	public bool isHovering;

	private Color bgUnselectedColor => default(Color);

	public void ButtonClicked()
	{
	}

	private void ResetButton()
	{
	}

	public void Update()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnDisable()
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}
}
