using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartScreens : MonoBehaviour
{
	public MenuController menus;

	public Image bgImg;

	public TMP_Text createdByText;

	public Image logoImg;

	public TMP_Text pressEnter;

	public FirstComerMenu firstComerPanel;

	public TranslationGroup translationGroup;

	[Header("Runtime")]
	public float timer;

	public bool visible;

	public void Launch()
	{
	}

	private void Update()
	{
	}
}
