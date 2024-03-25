using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SettingsSelector : MonoBehaviour
{
	public int selected;

	public Image[] option;

	public Color disabledColor;

	public Color enabledColor;

	public GameObject prefab;

	public UnityEvent callback;

	public bool alreadyPopulated;

	private void OnEnable()
	{
	}

	public void SetSelected(int index, bool playSound)
	{
	}

	public void SetSelected(int index)
	{
	}

	private void UpdateDisplay()
	{
	}

	public void PopulateWithLanguages()
	{
	}

	public void Populate(string[] strs)
	{
	}
}
