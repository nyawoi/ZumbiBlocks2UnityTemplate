using UnityEngine;

public class FootstepAudioPlayer : MonoBehaviour
{
	[Header("Settings")]
	public AudioPlayer targetAudioPlayer;

	public AnimationCurve frequencyCurve;

	public AnimationCurve volumeCurve;

	public Vector2 freqRange;

	public float curSpeed;

	public float timer;

	public AudioClip[] stepClips;

	public int index;

	public void MyUpdate(float speed)
	{
	}

	public void Play(float volume, bool resetTimer = true)
	{
	}
}
