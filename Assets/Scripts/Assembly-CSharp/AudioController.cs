using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
	public enum AmbientID
	{
		Menu = 0,
		City = 1,
		Waves = 2
	}

	public enum GlobalFXID
	{
		HitMarker = 0,
		Kill = 1,
		PlayerDeath = 2,
		BossIntro = 3,
		UnlockLoadout = 4
	}

	public enum ImpactFXID
	{
		CleanPunch = 0,
		CrunchyPunch = 1
	}

	public enum UIFXID
	{
		Hover = 0,
		Click = 1,
		InventoryEquip = 2,
		InventoryRelease = 3
	}

	public static AudioController instance;

	public SoundMenu soundMenu;

	public AudioSource[] ambientSource;

	public float[] ambientBaseVolume;

	public float ambientFadeSpeed;

	public float minDistanceToBeach;

	public AudioListener cameraListener;

	[Header("Global audio")]
	public PredefinedAudioPlayer[] globalSFXPlayer;

	[Header("UI SFX")]
	public AudioSource[] uiSFXPlayer;

	[Header("ImpactSFX")]
	public AudioPack[] impactSFX;

	public float[] impactSFXRange;

	public GameObject independentAudioPrefab;

	public Transform independentAudioHolder;

	[Header("Runtime")]
	public float[] ambientTargetVolume;

	public float distanceFromBeachFactor;

	[Header("IndoorReverb")]
	public AudioMixer masterMixer;

	public float reverbFactorLerpSpeed;

	public float curReverbFactor;

	public float targetReverbFactor;

	public float targetReverb;

	[Header("Flash")]
	public ScreenFlashController flashControl;

	public AudioSource deafEffectSource;

	public float flashEffectFactor;

	public void PlayImpact(Vector3 pos, ImpactFXID id, bool sync)
	{
	}

	public void PlayGlobalFX(GlobalFXID id)
	{
	}

	public void PlayUI(int id)
	{
	}

	public void PlayUI(UIFXID id)
	{
	}

	public void Init()
	{
	}

	public void MyUpdate()
	{
	}

	private void SetAmbientVolumes()
	{
	}

	private void ReverbAndListener()
	{
	}

	private void SetFlash()
	{
	}
}
