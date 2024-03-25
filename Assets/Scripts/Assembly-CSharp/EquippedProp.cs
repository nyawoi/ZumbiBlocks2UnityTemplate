using UnityEngine;

public class EquippedProp : MonoBehaviour
{
	public InventoryItem.ID itemID;

	public string idleAnimation;

	public bool oneHanded;

	[Header("Attach Settings")]
	public Vector3 attachPosition;

	public Vector3 attachRotation;

	[Header("FPS Settings")]
	public float extraFPSRotation;

	public Vector3 FPSOffset;

	public float FPSOffsetFactor;

	public bool autoAim;

	[Header("Audio")]
	public AudioPack drawPack;

	public AudioPack[] eventAudio;
}
