using UnityEngine;

public class PhysicalConsumable : MonoBehaviour
{
	[Header("Settings")]
	public EquippedProp prop;

	[HideInInspector]
	public DatabaseConsumable dbRef;

	public AudioPack consumeSound;

	public void Init()
	{
	}
}
