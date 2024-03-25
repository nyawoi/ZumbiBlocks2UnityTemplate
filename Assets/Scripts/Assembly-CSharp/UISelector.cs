using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UISelector : MonoBehaviour
{
	[Serializable]
	public struct Option
	{
		public string tag;

		public Color textColor;

		public Sprite imgSprite;
	}

	public List<Option> options;

	public int selectedIndex;

	public TranslatedTMPText targetLabel;

	public Image targetImage;

	public UnityEvent clickAction;

	public void OnEnable()
	{
	}

	public void UpdateLabel()
	{
	}

	public void SetIndex(int index)
	{
	}

	public void Back()
	{
	}

	public void Next()
	{
	}
}
