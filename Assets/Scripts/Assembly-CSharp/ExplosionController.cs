using UnityEngine;

public class ExplosionController : MonoBehaviour
{
	public static ExplosionController instance;

	public LayerMask expMask;

	public ScreenFlashController flashControl;

	public Explosion[] predefExplosion;

	public void Init()
	{
	}

	public void ProcessSyncedExplosion(Vector3 originPosition, Explosion.ID explosionID, int sourceLobbyID, bool isZombieExplosion)
	{
	}

	public void ProcessLocalExplosion(Vector3 origin, Explosion.ID explosionID, bool isZombieExplosion)
	{
	}

	public void ProcessExplosion(Vector3 origin, Explosion.ID explosionID, int sourceLobbyID, bool isZombieExplosion)
	{
	}

	private void ProcessExplosionAgainstFurniture(Vector3 origin, Explosion explosionSettings)
	{
	}

	private void ProcessExplosionAgainstZombies(Vector3 origin, Explosion explosionSettings, int playerID)
	{
	}

	private void ProcessExplosionAgainstMyPlayer(Vector3 origin, Explosion explosionSettings, int playerID)
	{
	}

	public void ExplosionResultFor(Vector3 origin, Vector3 target, Transform camT, Explosion expSettings, ExplosionResult res, bool saturateDamage)
	{
	}
}
