using System;
using UnityEngine;

public class PlayerSpineControl : MonoBehaviour
{
	[Serializable]
	public struct SpineCorrectionSettings
	{
		public float[] spineCorrectionAmp;

		public float[] headAngleAmp;
	}

	[Serializable]
	public struct CorrectionInput
	{
		public enum Tag : byte
		{
			Aiming = 0,
			Idle = 1,
			ArmAnimationOnly = 2,
			Disable = 3,
			HalfAngleWithArmAnimation = 4,
			HalfAngleNoArmAnimation = 5
		}

		public Tag tag;

		[Range(0f, 1f)]
		public float correctionCoef;

		[Range(0f, 1f)]
		public float angleAddtion;

		[Range(0f, 1f)]
		public float rotateArmCoef;

		[Range(0f, 1f)]
		public float armOverrideWeight;

		public CorrectionInput(float coef, float angAdd, bool armRotate, bool armOverride)
		{
			tag = Tag.Aiming;
			correctionCoef = coef;
			angleAddtion = angAdd;
			rotateArmCoef = 0f;
			armOverrideWeight = 0f;
		}
	}

	[Header("Baked inputs")]
	public CorrectionInput[] bakedInput;

	[Header("Reference")]
	public Transform playerTransform;

	public Animator playerAnimator;

	public Transform referenceTransform;

	public Transform[] spineBones;

	public Transform[] headBones;

	public Transform[] shoulderBones;

	[Header("Settings")]
	public SpineCorrectionSettings settings;

	[Range(0f, 1f)]
	public float camAngCoef;

	[Range(0f, 1f)]
	public float headRotation;

	[Header("Input")]
	public float inputLerpSpeed;

	public CorrectionInput curInput;

	public CorrectionInput.Tag targetInpuTag;

	[Header("Runtime")]
	public float deviationY;

	public float deviationX;

	[Range(-80f, 80f)]
	public float camAng;

	public bool disableCorrection;

	[Header("FPS Overrides")]
	public bool firstPerson;

	public float FPSRotation;

	public float effectiveFPSRotation;

	public void SetTargetInput(CorrectionInput.Tag t)
	{
	}

	public void UpdateSpineControl()
	{
	}

	private void AddAngleToSpine()
	{
	}

	private void AngleSpineThirdPerson()
	{
	}

	private void AngleSpineFirstPerson()
	{
	}

	private void CorrectSpine()
	{
	}
}
