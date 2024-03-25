using UnityEngine;

public class ThrowableInstance : MonoBehaviour
{
	private static readonly float groundSlowDownFactor;

	public Rigidbody body;

	public Collider col;

	[Header("Runtime")]
	public DatabaseThrowable dbRef;

	public float contactCooldown;

	public float timer;

	[Header("Settings")]
	public PlayerMain throwingPlayer;

	public GameObject throwingObject;

	public Transform homingTarget;

	public float interpolateSpeed;

	public float forceHomingSpeed;

	[SerializeField]
	private float convergeSpeed;

	[Header("Online and control")]
	public bool localControl;

	public int lobbyID;

	public int utilityID;

	public Vector3 syncPos;

	public Quaternion syncRot;

	[Header("Audio")]
	public Vector2 impactAudioRange;

	public Vector2 impactVolumeRange;

	public AudioPack impactAudio;

	public AudioPlayer audioPlayer;

	[Header("Converging")]
	public bool converging;

	private Vector2 convergingOrigin;

	private Vector2 convergingDirection;

	public void SetTarget(Transform t)
	{
	}

	public void MyUpdate()
	{
	}

	public void SetVel(Vector3 vec, Vector3 minRot, Vector3 maxRot)
	{
	}

	public void AddVel(Vector3 vel)
	{
	}

	public void OnDrawGizmos()
	{
	}

	public void OnCollisionEnter(Collision collision)
	{
	}

	private void PlayImpactSound(Collision collision)
	{
	}

	private void ProcessCollision(Collision collision)
	{
	}

	private bool IsCollisionUpwards(Collision collision)
	{
		return false;
	}

	private Vector3 GetCollisionNormal(Collision collision)
	{
		return default(Vector3);
	}

	private void ProcessCollisionDamage(Collision collision)
	{
	}

	private void Converge()
	{
	}

	public void SetConverging(Vector3 origin, Vector3 direction)
	{
	}

	private Vector3 ConvergencePoint(Vector3 currentPoint)
	{
		return default(Vector3);
	}
}
