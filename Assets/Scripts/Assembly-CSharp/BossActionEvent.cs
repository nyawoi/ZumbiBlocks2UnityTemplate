using UnityEngine;

public abstract class BossActionEvent : MonoBehaviour
{
	public float eventTime;

	public abstract void RunEvent(Zombie targetZombie);
}
