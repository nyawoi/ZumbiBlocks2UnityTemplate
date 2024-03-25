using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
	public enum Mode
	{
		ThirdPerson = 0,
		FirstPerson = 1
	}

	public const float maxAngle = 80f;

	public const float recoilMultiplier = 1.8f;

	public static PlayerCamera instance;

	[Header("Settings")]
	public PlayerMain playerMain;

	public PlayerInputReader input;

	public Transform camTransform;

	public LayerMask raycastMask;

	public float baseCameraDistance;

	public float hidePlayerDistance;

	[Header("First person settings")]
	public float eyeHeight;

	public float shoulderHeight;

	public Vector3 FPSOffset;

	public float adsShotFactor;

	public float adsShotDist;

	public float adsShotSpeed;

	[Header("CamPivots")]
	public Transform camTargetFarRight;

	public Transform camTargetCloseRight;

	public Transform camTargetFarLeft;

	public Transform camTargetCloseLeft;

	[Header("Runtime")]
	public float swayTimer;

	public float angle;

	public float distanceFactor;

	public float camSideFactor;

	public bool cameraOnTheRight;

	public Mode mode;

	[Header("Forced First Person Offset")]
	public float forcedFPSOffsetFactor;

	public Vector3 forcedFPSOffset;

	public bool forcedFPSRealHead;

	public float forcedFPSOffsetSpeed;

	public float forcedFPSOffsetDuration;

	[Header("Shake")]
	public float shakeAmp;

	public float shakeDecay;

	public Vector4 shakeState;

	public Vector4 shakeSpeed;

	[Header("Recoil")]
	public AnimationCurve verticalRecoilCurve;

	public AnimationCurve horizontalRecoilCurve;

	public Vector2 recoilMagnitude;

	public float recoilSpeed;

	public float recoilTimer;

	[Header("Test Shake")]
	[Range(0.2f, 5f)]
	public float testShakeAmp;

	[Range(0.2f, 3f)]
	public float testShakeDuration;

	[Range(0.7f, 2.5f)]
	public float testShakeFreq;

	public byte AngleInByte => 0;

	public static float ByteToAngle(byte b)
	{
		return 0f;
	}

	private float RandShakeSpeed()
	{
		return 0f;
	}

	public float EvalDelta(AnimationCurve curve, float t0, float t1)
	{
		return 0f;
	}

	public void ForceFPSOffset(Vector3 offset, float speed, float duration, bool realHead = false)
	{
	}

	public void SetCameraMode(Mode m)
	{
	}

	public void Recoil(float speed, Vector2 magnitude, float randomness)
	{
	}

	public void Shake(float amp, float duration, float freq)
	{
	}

	public void ADSShot(float speed)
	{
	}

	private void Start()
	{
	}

	public void LerpCameraDistance(float target)
	{
	}

	private Vector3 SetupCameraWithFactor(float factor)
	{
		return default(Vector3);
	}

	private void SetupFPSCamera()
	{
	}

	public void SetupADSPosition()
	{
	}

	private void SetupCameraRotationFPS()
	{
	}

	public Vector2 CalculateExtraMovement()
	{
		return default(Vector2);
	}

	public void UpdateCamera()
	{
	}

	private float ReadMouseInput(Vector2 extraCamMovement)
	{
		return 0f;
	}

	public void SetCameraTransform()
	{
	}

	public void UpdateShake()
	{
	}
}
