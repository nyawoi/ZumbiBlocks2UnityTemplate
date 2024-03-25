using System.Collections.Generic;
using UnityEngine;

public class ConsumableAnimationDatabase : MonoBehaviour
{
	public static ConsumableAnimationDatabase instance;

	public List<ConsumableAnimation> consumableAnim;

	public void Init()
	{
	}

	public ConsumableAnimation GetAnimation(ConsumableAnimation.ID id)
	{
		return null;
	}

	public ConsumableAnimation GetAnimation(string animName)
	{
		return null;
	}
}
