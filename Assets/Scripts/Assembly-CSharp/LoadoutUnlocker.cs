using System.Collections.Generic;
using UnityEngine;

public class LoadoutUnlocker : MonoBehaviour
{
	public static LoadoutUnlocker instance;

	public UnlockLoadoutMenu menu;

	public float bossDamageShare;

	public void Init()
	{
	}

	public void DistributeLoadoutUnlock(Zombie z)
	{
	}

	public void UnlockLoadout(int tier)
	{
	}

	public List<LoadoutUnlockable> SelectPrimaries(List<LoadoutUnlockable> lockedUnlockables)
	{
		return null;
	}
}
