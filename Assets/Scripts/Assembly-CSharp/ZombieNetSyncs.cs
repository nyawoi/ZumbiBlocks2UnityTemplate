using System.Collections.Generic;
using UnityEngine;

public class ZombieNetSyncs : MonoBehaviour
{
	public class RecentlyRemovedZombie
	{
		public float timer;

		public int id;

		public RecentlyRemovedZombie(int id_)
		{
		}
	}

	public static ZombieNetSyncs instance;

	[Header("Settings")]
	public float syncPosFreq;

	public int syncPreciseDataFreq;

	public float maxDeltaPerSec;

	[Header("Animation list")]
	public string[] animName;

	[Header("Runtime")]
	public float timer;

	public int preciseCounter;

	public List<Zombie> zombieInMovement;

	public List<ZombiePositionSync> zombiePosSync;

	private List<RecentlyRemovedZombie> recentlyRemoved;

	[Header("Pos sync saturation")]
	public long posSyncSent;

	public long posSyncSat;

	public float saturationRate;

	private int zombieBatchSpecificConnection;

	public void CleanUp()
	{
	}

	public bool WasRecentlyRemoved(int zombieID)
	{
		return false;
	}

	public ZombiePositionSync GetPosSyncByID(int zombieID)
	{
		return null;
	}

	public void Init()
	{
	}

	public void SyncBossAction(int zombieID, Zombie.Type zType, int actionIndex)
	{
	}

	public int GetZombieAnimationIndex(string name)
	{
		return 0;
	}

	public void SendAnimation(int id, byte mode, string animName, float param)
	{
	}

	public void OnZombieChangedState(int id)
	{
	}

	public void UpdateZombiePositions()
	{
	}

	public void RemoveZombieSync(int zombieID)
	{
	}

	public void RemoveZombieSyncIndex(int index)
	{
	}

	public void ReceivedZombiePosition(int id, Vector3 pos, float angle)
	{
	}

	public void ReceivedZombieDelta(int id, byte dx, byte dy, byte dz, byte ang)
	{
	}

	private ZombiePositionSync NewZombiePositionSync(int id)
	{
		return null;
	}

	public void OnBossAction(int id, Zombie.Type zType, int index)
	{
	}

	public void OnBossStageProp(int id, byte stage, byte propState)
	{
	}

	public void SyncBosshealth(int id, float health)
	{
	}

	public void SyncBossShot(int id, Vector3 dir)
	{
	}

	public void SyncCurrentlySpawnedZombies(int sendToSpecificConnection = -1)
	{
	}

	private Buffer AddZombieSpawnToSync(Buffer curBuffer, ZombieIdentity identity, ZombieTransform transform)
	{
		return null;
	}

	private Buffer AddZombieSpawnToSync(Buffer curBuffer, int id, Vector3 pos, byte bAngle, byte mesh, byte skinMaterial, Zombie.Type zType)
	{
		return null;
	}

	private void SendZombieBatch(Buffer curBuffer)
	{
	}

	public void PositionSyncUpdate()
	{
	}

	public void ListZombiesInMovement()
	{
	}

	public Buffer AddZombieToDeltaBuffer(Buffer curBuffer, int id, byte deltaX, byte deltaY, byte deltaZ, byte angle)
	{
		return null;
	}

	private float GetMaxSpeedForZombie(Zombie.Type zombieType)
	{
		return 0f;
	}

	private float GetDeltaPrecisionForZombie(Zombie.Type zombieType)
	{
		return 0f;
	}

	public void SyncDeltaPositions()
	{
	}

	public Buffer AddZombieToPositionBuffer(Buffer curBuffer, int id, Vector3 precisePos, float angle)
	{
		return null;
	}

	public void SyncPrecisePositions()
	{
	}

	public void BroadcastZombiePositions(Buffer buffer, bool reliable)
	{
	}
}
