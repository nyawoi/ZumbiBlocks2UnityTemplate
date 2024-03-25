using System;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
	[Serializable]
	public class MiscAudio
	{
		public AudioClip clip;

		public float baseVolume;

		public Vector2 freqRange;

		public AudioClip[] variations;

		public AudioClip GetClip()
		{
			return null;
		}
	}

	public enum MiscID
	{
		Jump = 0,
		Roll = 1,
		DropLoot = 2,
		PickLoot = 3,
		HolsterGeneric = 4
	}

	public PlayerMain playerMain;

	public AudioListener listener;

	[Header("Reference audio players")]
	public FootstepAudioPlayer foot;

	public AudioPlayer core;

	public AudioPlayer gun;

	public AudioPlayer gunExtra;

	public AudioPack[] audioPacks;

	public void UpdateFootsteps(float moveSpeed)
	{
	}

	public void PlayCore(MiscID id, bool sync)
	{
	}

	public void PlayCore(AudioPack audio)
	{
	}

	public void PlayGun(AudioPack audio)
	{
	}

	public void PlayGunExtra(AudioPack audio)
	{
	}
}
