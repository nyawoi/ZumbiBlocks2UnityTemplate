using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MosaicButton : MonoBehaviour
{
	public bool interactable;

	public string descriptionTag;

	[Header("References")]
	public Image bgImg;

	public Image outline;

	public RectTransform textTransform;

	public RectTransform p1;

	public RectTransform p2;

	public UnityEvent buttonAction;

	[Header("Runtime")]
	public bool isHovering;

	private Color bgUnselectedColor => default(Color);

	public void OnMouseEnter()
	{
	}

	public void OnMouseExit()
	{
	}

	public void ButtonClicked()
	{
	}

	public void OnDisable()
	{
	}

	private void ResetButton()
	{
	}

	public void Update()
	{
	}
}
