using UnityEngine;

public class ZombieAISettings : MonoBehaviour
{
	public static ZombieAISettings instance;

	public bool DisableAllPathfinding;

	[Header("Sight Settings")]
	public LayerMask zombieSightMask;

	public float maxSightDistance;

	public float targetDecaySpeed;

	[Header("Sight maths")]
	public float zombieFovMin;

	public float fastestTargetAcquireSpeed;

	public float sightDotPower;

	public float sightDistPower;

	[Header("Give Up Settings")]
	public float unconditionalGiveUpDistance;

	public float timedGiveUpDistance;

	public float timeToGiveUp;

	[Header("Repath Settings")]
	public float minRepathTime;

	public int repathGiveUpCount;

	[Header("AI Reach Settings")]
	public float zombieFindTargetFreq;

	public float zombieReachabilityFreq;

	public float zombieCombatDistance;

	public float zombieAttackDistance;

	[Header("AI Flying Settings")]
	public float flyingCombatDistance;

	public Vector2 flyingDistanceRange;

	public float flyingHeightTangent;

	public Vector2 flyingTimerRange;

	public Vector2 strafeSpeedRange;

	public void Init()
	{
	}
}
