using UnityEngine;

public class BossThrowableEvent : BossActionEvent
{
	public InventoryItem.ID id;

	public Vector3 refPos;

	public int quantity;

	[Header("Random spawn settings")]
	public bool useCustomSpawn;

	public Vector3 customSpeed1;

	public Vector3 customSpeed2;

	public float forceHomingSpeed;

	public override void RunEvent(Zombie targetZombie)
	{
	}
}
