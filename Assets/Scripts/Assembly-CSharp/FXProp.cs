using UnityEngine;

public class FXProp : MonoBehaviour
{
	public enum ID
	{
		None = 0,
		PistolCasing = 1,
		RifleCasing = 2,
		ShotgunCasing = 3,
		BigMuzzleSmoke = 4,
		MiddleMuzzleSmoke = 5,
		SmallMuzzleSmoke = 6,
		SmallMuzzleFlash = 7,
		MediumMuzzleFlash = 8,
		BigMuzzleFlash = 9,
		BulletImpact1 = 10,
		ZombieRespawnDirt = 11,
		PoundExplosion = 12,
		WhiteArea2 = 13,
		WhiteArea4 = 14,
		ShieldDashTrail = 15,
		Spark = 16,
		ShotgunCasingBig = 17,
		PoundExplosionSmall = 18,
		BossShotgun = 19,
		FlashBang = 20,
		Blood1 = 21,
		Blood2 = 22,
		Blood3 = 23,
		WoodenDoorExplosion = 24,
		EbonyDoorExplosion = 25,
		CellDoorExplosion = 26,
		PoliceDoorExplosion = 27,
		ShelfExplosion = 28,
		GlassWindowExplosion = 29,
		GarandEmptyClip = 30,
		MicroMuzzleFlash = 31,
		ToxExplosion = 32,
		FragExplosion = 33,
		StunExplosion = 34,
		WaterImpact = 35,
		ToxicBlood = 36
	}

	[Header("Settings")]
	public ID id;

	public float defaultTimeout;

	public Rigidbody body;

	public ParticleSystem[] particle;

	[Header("Runtime")]
	public float timer;

	public void Setup(Vector3 velocity, Vector3 startAngularVelocity)
	{
	}
}
