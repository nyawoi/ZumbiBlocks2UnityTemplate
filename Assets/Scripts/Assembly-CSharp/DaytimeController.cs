using UnityEngine;

public class DaytimeController : MonoBehaviour
{
	public enum Difficulty
	{
		Easy = 0,
		Medium = 1,
		Hard = 2,
		Insane = 3
	}

	public static DaytimeController instance;

	[Header("References")]
	public Light sunLight;

	[Header("Settings")]
	public float dayDurationInMinutes;

	public float daytimeStretchness;

	[Range(0f, 24f)]
	public float resetMenuTime;

	[Range(0f, 24f)]
	public float resetGameTime;

	[Range(0f, 24f)]
	public float lobbyTime;

	[Range(0f, 1f)]
	public float resetRot;

	[Header("Sun settings")]
	public float baseShadowStrength;

	public float baseShadowThreshold;

	public float baseSunRotation;

	public AnimationCurve sunRotationCurve;

	public AnimationCurve sunLightCurve;

	public Gradient sunColorGradient;

	public float sunLightMultiplier;

	[Header("Blood moon settings")]
	public float insaneTimeFadeSpeed;

	public float startTime;

	public float endTime;

	[Header("Fog settings")]
	public Color baseSkyAmbient;

	[Range(0f, 1f)]
	public float ambientEquatorBrightness;

	public Color baseGroundAmbient;

	[Header("Fog settings")]
	public Gradient fogGradient;

	[Header("Player light settings")]
	public float playerLightThreshold;

	public float playerLightMulti;

	[Header("Switches")]
	public bool masterSwitch;

	public bool sunLightSwitch;

	public bool sunColorSwitch;

	public bool ambientSwitch;

	public bool reflectionSwitch;

	public bool shadowSwitch;

	public bool playerLightSwitch;

	[Header("Runtime")]
	public float lightEval;

	public float timeCoef;

	public float curTime;

	[Header("Syncing")]
	public float syncTimer;

	public float syncFreq;

	public bool IsBloodMoon => false;

	public void Init()
	{
	}

	public void UpdateEnvironment()
	{
	}

	public void Update()
	{
	}
}
