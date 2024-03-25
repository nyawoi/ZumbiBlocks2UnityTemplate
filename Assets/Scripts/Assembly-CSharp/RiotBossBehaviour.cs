public class RiotBossBehaviour : BossBehaviour
{
	public enum ActionID
	{
		IntroToShield = 0,
		FlashBang = 1,
		ShieldPound = 2,
		ShieldBash = 3,
		ShieldDash = 4,
		TransitionToShotgun = 5,
		ShotgunShot = 6,
		ShotgunBang = 7,
		BitchSlap = 8,
		IntroStage3 = 9,
		Slam = 10,
		TripleShot = 11,
		LeapSlam = 12
	}

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

	public override bool IsProtectedAction(int i)
	{
		return false;
	}

	public override Zombie.Type MyZombieType()
	{
		return default(Zombie.Type);
	}

	public RiotBossBehaviour(Zombie z)
	{
	}

	public override void SubOnAggro()
	{
	}

	public override void OnDying()
	{
	}

	public override void CombatUpdate()
	{
	}

	private void AttackDecision(float distanceToTarget)
	{
	}

	private void CooldownAttack(float distanceToTarget)
	{
	}

	public override int BlockadeAttackIndex()
	{
		return 0;
	}
}
