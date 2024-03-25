using UnityEngine;

public class PhysicalMelee : MonoBehaviour
{
	[Header("Settings")]
	public EquippedProp prop;

	public float reach;

	public PlayerMeleeAttack.ID[] weakAttack;

	public PlayerMeleeAttack.ID[] strongAttack;

	[HideInInspector]
	public DatabaseMelee dbRef;

	public void Init()
	{
	}
}
