using System;
using UnityEngine;

[Serializable]
public class AudioPack
{
	public AudioClip[] clips;

	public float baseVolume;

	public Vector2 freqRange;

	public bool HasClip => false;

	public AudioClip GetClip()
	{
		return null;
	}
}
