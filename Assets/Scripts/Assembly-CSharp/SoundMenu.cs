using UnityEngine;
using UnityEngine.Audio;

public class SoundMenu : BaseMenu
{
	[Header("Sounds")]
	public SettingsSelector languageSelector;

	public ZBExpSlider masterSlider;

	public ZBExpSlider sfxSlider;

	public ZBExpSlider enviroSlider;

	public SaveAudio saveAudio;

	public bool callbackStopper;

	[Header("Mixer")]
	public AudioMixer mixer;

	public AnimationCurve volumeToDbCurve;

	public void ReturnFromSounds(BaseMenu returnMenu)
	{
	}

	public void PullData()
	{
	}

	public void ToggleMute()
	{
	}

	public void ApplySounds()
	{
	}

	public void ApplyToUI()
	{
	}

	public override void OnEnterMenu()
	{
	}

	public void OnLanguageChanged()
	{
	}

	public void OnSettingsChanged()
	{
	}
}
