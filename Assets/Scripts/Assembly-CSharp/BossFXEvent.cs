using UnityEngine;

public class BossFXEvent : BossActionEvent
{
	public FXProp.ID fxID;

	public Vector3 localPosition;

	public bool attachLocal;

	public override void RunEvent(Zombie targetZombie)
	{
	}
}
