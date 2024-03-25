using UnityEngine;

public class NetAudioMessage
{
	public enum SubType : byte
	{
		ZombieAudio = 0,
		ZombieAttack = 1,
		PlayerCore = 2,
		PlayerMelee = 3,
		KillFeed = 4,
		IFurniAudio = 5,
		ImpactSFX = 6
	}

	public static void Simple(Buffer buffer, SubType st)
	{
	}

	public static void ZombieAudio(Buffer buffer, int zombieID, byte audioID)
	{
	}

	public static void ZombieAttackAudio(Buffer buffer, int zombieID, byte attackIndex)
	{
	}

	public static void PlayerCoreAudio(Buffer buffer, int playerSlotID, byte coreAudioID)
	{
	}

	public static void PlayerMeleeAudio(Buffer buffer, int playerSlotID, byte meleeID)
	{
	}

	public static void InteractableFurnitureAudio(Buffer buffer, byte cellX, byte cellY, int id, byte soundIndex)
	{
	}

	public static void ImpactSFX(Buffer buffer, Vector3 pos, byte id)
	{
	}
}
