using UnityEngine;

public class CharacterSkin : MonoBehaviour
{
	public SkinDatabase.SkinID skinID;

	public SkinDatabase.Gender gender;

	public PlayerMain curPlayer;

	[Header("Main")]
	public Animator animator;

	public SkinnedMeshRenderer wholeBodyRender;

	public SkinnedMeshRenderer onlyArmsRender;

	public PlayerSpineControl spineControl;

	public PlayerAnimationEvents animationEvents;

	[Header("Adapt")]
	public Transform[] adaptiveBone;

	public Vector3[] adaptivePos;

	[Header("Camera")]
	public Transform playerhead;

	public Transform fpsReference;

	[Header("Limbs Pivots")]
	public Transform rightHandPivot;

	public Transform leftHandPivot;

	public Transform rightFootPivot;

	public Transform shotRefPos;

	[Header("Inventory")]
	public Transform[] weaponPivot;

	[Header("Runtime")]
	public bool alwaysHide;

	[Header("Debug")]
	public bool calculateAdpatPos;

	public bool retargetActive;

	public void Init(PlayerMain pm)
	{
	}

	public void UpdateBasedOnCameraMode(PlayerCamera.Mode cameraMode)
	{
	}

	public void UpdateSkinColor(int colorIndex)
	{
	}

	public void LateUpdate()
	{
	}

	public void AdaptBones()
	{
	}

	public void CalculateAdaptPos()
	{
	}

	public void OnDrawGizmos()
	{
	}
}
