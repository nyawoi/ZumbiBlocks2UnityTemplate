using UnityEngine;

public class GunAnimationController : MonoBehaviour
{
	public enum AnimID
	{
		Shoot = 0,
		OpenBolt = 1,
		OpenedBolt = 2,
		CloseBolt = 3,
		ClosedBolt = 4
	}

	[Header("MAG renderer")]
	public Renderer magRenderer;

	[Header("MAG spawning")]
	public GameObject magPrefab;

	public Vector3 magSpawnPos;

	public Vector3 magSpawnRotation;

	public Vector3 magEjectDirection;

	[Header("Animation settings")]
	public Animation legacyAnimator;

	public AnimID defaultAnim;

	public string[] animations;

	public float[] animationSpeed;

	[Header("-- Offhand")]
	public Vector3 offHandPos;

	public Vector3 offHandEuler;

	[Header("-- ADSOffhand")]
	public Vector3 offHandPosADS;

	public Vector3 offHandEulerADS;

	[Header("-- Offhand Female")]
	public Vector3 offHandPosFemale;

	public Vector3 offHandEulerFemale;

	[Header("-- ADSOffhand Female")]
	public Vector3 offHandPosADSFemale;

	public Vector3 offHandEulerADSFemale;

	public void Play(int index)
	{
	}

	public void Play(AnimID id)
	{
	}

	public void SetMagVisible(bool b)
	{
	}
}
