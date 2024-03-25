using UnityEngine;

public class AuxiliarMapObjects : MonoBehaviour
{
	public static AuxiliarMapObjects instance;

	public Light sun;

	public Transform waterPlane;

	public Transform sandPlane;

	public Transform resetHeight;

	[Header("Runtime")]
	public float waterY;

	public void Init()
	{
	}
}
