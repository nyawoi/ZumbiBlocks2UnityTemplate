using UnityEngine;

public class PhysicalThrowable : MonoBehaviour
{
	public EquippedProp prop;

	[HideInInspector]
	public DatabaseThrowable dbRef;

	[Header("Throw Animation")]
	public string throwAnimation;

	public float throwTime;

	[Header("Audio")]
	public AudioPack audioPack;

	public void Init()
	{
	}
}
