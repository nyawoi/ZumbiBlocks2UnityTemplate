using UnityEngine;

public class DatabaseController : MonoBehaviour
{
	public static DatabaseController instance;

	public FurnitureDatabase furnitureDatabase;

	public ItemsBase itemsBase;

	public WeaponBase weaponsBase;

	public ThrowablesBase throwablesBase;

	public MeleeAttackBase meleeAttackBase;

	public ReloadAnimationDatabase reloadAnimBase;

	public ConsumableAnimationDatabase consumableAnimBase;

	public FXPropsController fxProps;

	public LoadoutDatabase loadout;

	public SkinDatabase skins;

	public BossAttackSetBase bossAttackSet;

	public ShootingAnimationEventController shootAnimationEvents;

	public void Init()
	{
	}
}
