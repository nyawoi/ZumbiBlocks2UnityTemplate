using TMPro;
using UnityEngine;

public class FPSAndStatistics : MonoBehaviour
{
	[Header("Text")]
	public TMP_Text fpsText;

	public TMP_Text downText;

	public TMP_Text upText;

	public TMP_Text pingText;

	[Header("Settings")]
	public float fpsPoolingFreq;

	public float fpsUpdateFreq;

	public float pingUpdateFreq;

	[Header("Info")]
	public float fps;

	public int ping;

	private float accFPS;

	private float FPSPoolCount;

	private float fpsPoolTimer;

	private float fpsUpdateTimer;

	private float pingUpdateTimer;

	public void CustomUpdate()
	{
	}

	private void UpdatePing()
	{
	}

	private void UpdateFPS()
	{
	}
}
