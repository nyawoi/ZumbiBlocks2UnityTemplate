using UnityEngine;

public class ReloadGunAnimation : MonoBehaviour
{
	public enum ID
	{
		Pistol1 = 0,
		SMG1 = 1,
		Shotgun1 = 2,
		SpeedPistol = 3,
		BulpupLeftHandle = 4,
		RifleLeftHandle = 5,
		RifleRightHandleD = 6,
		BreachReload = 7,
		TerminatorReload = 8,
		BreachReloadSlow = 9,
		WelrodReload = 10,
		GreaseGunReload = 11,
		RockAndLock1 = 12,
		Pistol2 = 13,
		Enfield = 14,
		PPSH = 15,
		B38Reload = 16,
		STGReload = 17,
		UltimaxReload = 18,
		C96Reload = 19,
		DeLisleReload = 20,
		GarandReload = 21
	}

	public ID id;

	public string baseAnimationName;

	public float reloadTime;

	public float endAnimTime;

	public float duration;

	[Header("Repeated anim")]
	public string repeatAnimationName;

	public string finishAnimationName;

	public int repeatReloadAmount;

	public float repeatDuration;

	public bool IsRepeating => false;
}
