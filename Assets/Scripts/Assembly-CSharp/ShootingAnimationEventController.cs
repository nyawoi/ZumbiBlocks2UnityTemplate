using UnityEngine;

public class ShootingAnimationEventController : MonoBehaviour
{
	public static ShootingAnimationEventController instance;

	public ShootingAnimation[] animations;

	private bool[] eventRanFlags;

	public void Init()
	{
	}

	public void ClearEvents()
	{
	}

	public void ProcessEventsFor(PlayerAnimationEvents animationEvents, Animator playerAnimator)
	{
	}

	private ShootingAnimation GetAnimation(AnimatorStateInfo stateInfo)
	{
		return null;
	}
}
