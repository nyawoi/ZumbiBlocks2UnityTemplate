using UnityEngine;

public class PredefinedAudioPlayer : AudioPlayer
{
	[Header("Predefined")]
	public AudioPack pack;

	public bool playOnAwake;

	private void Awake()
	{
	}

	public void Play()
	{
	}
}
