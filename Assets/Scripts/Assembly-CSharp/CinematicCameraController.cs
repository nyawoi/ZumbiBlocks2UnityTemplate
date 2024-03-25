using UnityEngine;

public class CinematicCameraController : MonoBehaviour
{
	public static CinematicCameraController instance;

	public CinematicCameraMode currentMode;

	public CinematicFreeCamera freeCamera;

	public CinematicPlayerCamera playerCamera;

	public bool Active => false;

	public void Init()
	{
	}
}
