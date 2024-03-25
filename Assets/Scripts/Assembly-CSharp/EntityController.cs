using UnityEngine;

public class EntityController : MonoBehaviour
{
	public static EntityController instance;

	public ZombieController zombies;

	public PlayersController players;

	public ThrowableController throwables;

	public EntityLocator locator;

	public ExplosionController explosion;

	[Header("Pools")]
	public ShotPool shotPool;

	[Header("Debug")]
	public bool enableUpdateLocation;

	public void Init()
	{
	}

	private void Update()
	{
	}
}
