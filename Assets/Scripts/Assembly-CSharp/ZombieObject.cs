using UnityEngine;

public class ZombieObject : MonoBehaviour, DamageTaker
{
	public enum AudioID
	{
		Growl = 0,
		Grunt = 1,
		Hit = 2
	}

	public Zombie.Type zType;

	public Rigidbody body;

	public CapsuleCollider capsuleCol;

	public Animator animator;

	public SkinnedMeshRenderer meshRenderer;

	public ZombieLimbColliders limbColliders;

	public Transform[] armatureBone;

	public CustomZombieObject customObj;

	public float halfH;

	public Transform zombieEyeRef;

	public Transform zombieFootRef;

	[Header("Climb settings")]
	public LayerMask climbMask;

	public float climbDistance;

	public float climbHeight;

	public float climbDepth;

	public AnimationPack climbAnimation;

	private Zombie zombie;

	[Header("Sound")]
	public AudioPlayer[] audioPlayer;

	public float growlMinCD;

	public float growlMaxCD;

	public AudioPack growlClips;

	public AudioPack gruntClips;

	public AudioPack hitPack;

	[Header("Runtime")]
	public float growlCooldown;

	[Header("Debug")]
	public GameObject redhalo;

	public GameObject greenhalo;

	public Zombie GetZombie => null;

	public int GetZombieID => 0;

	public void MyUpdate()
	{
	}

	private void ProcessGrowl()
	{
	}

	public void PlayAudio(AudioID aid, bool sync)
	{
	}

	public void PlayPack(AudioPack targetpack)
	{
	}

	public void SetZombieReference(Zombie z)
	{
	}

	public void InitializeSkin()
	{
	}

	public DamageTarget GetTarget()
	{
		return null;
	}

	public float GetDamageMultiplier()
	{
		return 0f;
	}

	public bool ClimbCheck()
	{
		return false;
	}
}
