using UnityEngine;

public class ConsumableAnimation : MonoBehaviour
{
	public enum ID
	{
		Drink = 0,
		Eat = 1,
		Bandage = 2
	}

	public ID id;

	public string baseAnimationName;

	public float useTime;
}
