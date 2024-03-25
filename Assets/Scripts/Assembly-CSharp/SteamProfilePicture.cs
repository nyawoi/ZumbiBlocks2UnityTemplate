using UnityEngine;

public class SteamProfilePicture : MonoBehaviour
{
	public static SteamProfilePicture instance;

	[SerializeField]
	private AnimationCurve saturationCurve;

	public void Initialize()
	{
	}

	public Texture2D MakeTextureFromRGBA(int width, int height, byte[] rgbaData)
	{
		return null;
	}
}
