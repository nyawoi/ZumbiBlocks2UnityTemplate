using UnityEngine;

public class LoadoutDatabase : MonoBehaviour
{
	public static LoadoutDatabase instance;

	public bool printIDS;

	public Sprite noneSprite;

	public GameObject[] tierObjects;

	public LoadoutUnlockable[] allUnlockables;

	public void Init()
	{
	}

	public int GetTier(LoadoutUnlockable u)
	{
		return 0;
	}

	public LoadoutUnlockable GetUnlockable(LoadoutUnlockable.ID id)
	{
		return null;
	}
}
