using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBar : MonoBehaviour
{
	private Zombie targetZombie;

	public TMP_Text nameText;

	public Image fillBar;

	public Image headImg;

	public bool hasZombie => false;

	public void OnZombieUnloaded(int id)
	{
	}

	public void ClearBar()
	{
	}

	public void SetZombie(Zombie z)
	{
	}

	public void Translate()
	{
	}

	public void UpdateDisplay()
	{
	}
}
