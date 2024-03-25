using System.Collections.Generic;
using UnityEngine;

public abstract class BossBehaviour
{
	public int stage;

	protected Zombie myZombie;

	public bool didAggro;

	public bool isIntro;

	public float attackCooldown;

	public List<ActiveAction> activeActions;

	public void SetStage(int s)
	{
	}

	public bool UpdateVerticalSpeed()
	{
		return false;
	}

	public void StartAction(int id, float cooldown = -1f)
	{
	}

	public void StartAction(int id, float cd1, float cd2)
	{
	}

	public BossAction StartAction(Zombie.Type zType, int index)
	{
		return null;
	}

	public void ExecuteEvents(ActiveAction activeAction)
	{
	}

	public void ProcessActions()
	{
	}

	public void ClearActions()
	{
	}

	public bool HasProtectedAction()
	{
		return false;
	}

	public void OnAggro()
	{
	}

	public virtual void SetTrailRendering(int index, bool b)
	{
	}

	protected void ClearTrails()
	{
	}

	public LaserController GetLaser(int index)
	{
		return null;
	}

	public virtual void SetLasering(int index, bool b, float distance)
	{
	}

	protected void ClearLasers()
	{
	}

	public Transform GetAuxiliarPivot(int index)
	{
		return null;
	}

	public void UpdateTrails()
	{
	}

	public void UpdateLasers()
	{
	}

	public virtual void GeneralUpdate()
	{
	}

	public virtual Zombie.Type MyZombieType()
	{
		return default(Zombie.Type);
	}

	public virtual int MaxAnimStage()
	{
		return 0;
	}

	public virtual void SubOnAggro()
	{
	}

	public virtual void OnDying()
	{
	}

	public virtual void CombatUpdate()
	{
	}

	public abstract int BlockadeAttackIndex();

	public virtual bool IsProtectedAction(int i)
	{
		return false;
	}

	public virtual bool UseCustomFlightSettings()
	{
		return false;
	}

	public virtual (float, float) GetFlightSettings()
	{
		return default((float, float));
	}
}
