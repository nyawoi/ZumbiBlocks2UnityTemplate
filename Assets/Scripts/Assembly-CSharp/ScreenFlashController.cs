using UnityEngine;
using UnityEngine.UI;

public class ScreenFlashController : MonoBehaviour
{
	public static ScreenFlashController instance;

	public Image basicPanel;

	[Header("Flash settings")]
	public AnimationCurve intensityCurve;

	public float entryTime;

	public float exitTime;

	[Header("Runtime")]
	public bool isFlashed;

	public bool isTurned;

	public float curDuration;

	public float timer;

	public void Init()
	{
	}

	public void Clear()
	{
	}

	public void SetFlashed(float duration, bool flashTurned)
	{
	}

	public void Update()
	{
	}

	public float GetFlashCoef()
	{
		return 0f;
	}

	private void UpdateEffect()
	{
	}

	public void EnableFlash()
	{
	}

	public void DisableFlash()
	{
	}
}
