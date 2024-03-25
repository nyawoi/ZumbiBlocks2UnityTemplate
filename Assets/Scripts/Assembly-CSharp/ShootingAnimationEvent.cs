using UnityEngine;

public abstract class ShootingAnimationEvent : MonoBehaviour
{
	[Range(0f, 1f)]
	public float runTime;

	public abstract void Run(PlayerAnimationEvents playerEvents);
}
