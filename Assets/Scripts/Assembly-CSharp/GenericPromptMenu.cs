using UnityEngine;
using UnityEngine.Events;

public class GenericPromptMenu : MonoBehaviour
{
	public TranslatedTMPText headerText;

	public TranslatedTMPText bodyText;

	public TranslatedTMPText confirmText;

	public TranslatedTMPText cancelText;

	private UnityAction confirmAction;

	private UnityAction cancelAction;

	public GameObject confirmButton;

	public GameObject cancelButton;

	public void EnterPrompt(string headerTag, string bodyTag, string confirmTag, string cancelTag, UnityAction confirm, UnityAction cancel)
	{
	}

	public void OnConfirm()
	{
	}

	public void OnCancel()
	{
	}
}
