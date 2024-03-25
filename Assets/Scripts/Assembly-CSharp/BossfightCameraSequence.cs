using UnityEngine;

public class BossfightCameraSequence : MonoBehaviour
{
	public static BossfightCameraSequence instance;

	public float rotLerpSpeed;

	public float posLerpSpeed;

	public Vector3 localPos1;

	public Vector3 localPos2;

	public LayerMask raycastMask;

	[Header("Runtime")]
	public Transform target;

	public bool active;

	public float duration;

	public float timer;

	public float camDistanceMulti;

	public static bool Active => false;

	public void Init()
	{
	}

	public void ClearCameraSequence()
	{
	}

	public void TryBossIntroSequence(Zombie.Type zType, Transform bossTransform, float introDuration)
	{
	}

	public void StartCameraSequence(Transform t, float dur)
	{
	}

	public void MyUpdate()
	{
	}
}
