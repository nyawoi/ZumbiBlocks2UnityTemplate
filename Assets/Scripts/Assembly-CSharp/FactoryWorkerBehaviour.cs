public class FactoryWorkerBehaviour
{
	public static float hearingMultiplier;

	public static bool IgnorePlayer(Zombie zombie, PlayerMain player)
	{
		return false;
	}

	public static bool PlayerInSameFloor(Zombie zombie, PlayerMain player)
	{
		return false;
	}
}
