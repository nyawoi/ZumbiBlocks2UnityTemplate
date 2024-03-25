using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResolutionSelector : MonoBehaviour
{
	[SerializeField]
	private TMP_Dropdown dropdown;

	public List<Resolution> availableResolutions;

	public int CurrentlySelected => 0;

	public void FillOptions()
	{
	}

	private void BuildResolutionList()
	{
	}

	private void AddCurrentResolution()
	{
	}

	private void RemoveResolutionDuplicates()
	{
	}

	private void FillDropdown()
	{
	}

	private void UpdateCurrentlySelected()
	{
	}

	public int GetSelectedWidth()
	{
		return 0;
	}

	public int GetSelectedHeight()
	{
		return 0;
	}

	public void Print()
	{
	}
}
