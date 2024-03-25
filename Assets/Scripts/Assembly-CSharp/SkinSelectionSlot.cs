using UnityEngine;
using UnityEngine.UI;

public class SkinSelectionSlot : MonoBehaviour
{
	public int selectedSkin;

	public int selectedGender;

	public int selectedColor;

	public Image genderImg;

	public Image color1;

	public Image color2;

	public SkinDatabase.SkinID SelectedSkinID => default(SkinDatabase.SkinID);

	public SkinDatabase.Gender SelectedGender => default(SkinDatabase.Gender);

	public void NextColor()
	{
	}

	public void PreviousColor()
	{
	}

	public void ChangeGender()
	{
	}

	private void ChangeColor(int add)
	{
	}

	public void ApplySkinToLobby()
	{
	}

	private void UpdateDisplay()
	{
	}

	public void OnEnable()
	{
	}
}
