using UnityEngine;

public class DatabaseThrowable : DatabaseItem
{
	[Header("Prefab")]
	public GameObject handPrefab;

	public GameObject throwPrefab;

	[Header("Throw Settings")]
	public float throwSpeed;

	public Vector3 localSpeed;

	public bool useGrenadeThrowMode;

	public bool homing;

	public float homingSpeed;

	public Vector3 localRotationMin;

	public Vector3 localRotationMax;

	public bool groundSlowEffect;

	[Header("Contact damage options")]
	public bool enableContactDamage;

	public float contactDmgCooldown;

	public Vector2 contactVelRange;

	public Vector2 contactDmgRange;

	[Header("Destroy settings")]
	public float timeOut;

	public bool contactDestroy;

	public FXProp.ID contactFX;

	public FXProp.ID fxID;

	public Explosion.ID explosionID;

	public InventoryItem onDestroyLoot;

	public override GameObject GetEquippedProp()
	{
		return null;
	}

	public override SubType GetSubType()
	{
		return default(SubType);
	}
}
