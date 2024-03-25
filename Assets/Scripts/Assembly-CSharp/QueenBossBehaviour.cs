public class QueenBossBehaviour : BossBehaviour
{
	public enum ActionID
	{
		Intro = 0,
		Transition1 = 1,
		Transition2 = 2,
		DodgeRight = 3,
		DodgeLeft = 4,
		Stab = 5,
		Swing = 6,
		Twirl = 7,
		ToxBall = 8,
		Laser = 9,
		LaserCurved = 10,
		MultiToxBall = 11,
		Explode = 12,
		Grab = 13
	}

	private ActionID[] meleeAttack;

	private ActionID[] allAttacks;

	private ActionID RandomMelee => default(ActionID);

	private ActionID RandomAttack => default(ActionID);

	public void StartAction(ActionID id, float cooldown = -1f)
	{
	}

	public void StartAction(ActionID id, float cd1, float cd2)
	{
	}

	public override int MaxAnimStage()
	{
		return 0;
	}

	public override void SubOnAggro()
	{
	}

	public override bool IsProtectedAction(int i)
	{
		return false;
	}

	public override Zombie.Type MyZombieType()
	{
		return default(Zombie.Type);
	}

	public QueenBossBehaviour(Zombie z)
	{
	}

	public void Dodge()
	{
	}

	private ActionID? SelectActionByStage(float distance)
	{
		return null;
	}

	private ActionID? SelectActionStage1(float distance)
	{
		return null;
	}

	private ActionID? SelectActionStage2(float distance)
	{
		return null;
	}

	private ActionID? SelectActionStage3(float distance)
	{
		return null;
	}

	public override void GeneralUpdate()
	{
	}

	public override void CombatUpdate()
	{
	}

	public override int BlockadeAttackIndex()
	{
		return 0;
	}

	public override bool UseCustomFlightSettings()
	{
		return false;
	}

	public override (float, float) GetFlightSettings()
	{
		return default((float, float));
	}
}
