using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ZombieLoader : MonoBehaviour
{
	public class PropPool
	{
		public List<ZombieProp> pooledProp;
	}

	public enum ZombieLoadState
	{
		Unloaded = 0,
		Prop = 1,
		Real = 2
	}

	public static ZombieLoader instance;

	public ZombieDistanceMatrix zombieDistMatrix;

	public Transform zombieHolder;

	public Transform zombiePropHolder;

	[Header("Prefabs")]
	public GameObject[] lowLODzombiePrefab;

	public GameObject[] zombiePrefab;

	public GameObject[] zombieDollPrefab;

	[Header("Load distances")]
	public float sleepDistance;

	public float paddingDistance;

	public float sqrActiveDistance;

	[Header("Zombie lists")]
	public int curID;

	[HideInInspector]
	public List<UnloadedZombie> unloadedZombies;

	[HideInInspector]
	public List<ZombieProp> zombieProp;

	[HideInInspector]
	public PropPool[] propPool;

	[HideInInspector]
	public List<Zombie> zombies;

	[HideInInspector]
	public List<GameObject> zombieDolls;

	[Header("Aux loading lists")]
	private List<int> removeUnloadedID;

	private List<int> removePropID;

	private List<int> removeRealID;

	private List<AllPurposeZombie> addUnloaded;

	private List<AllPurposeZombie> addProp;

	private List<AllPurposeZombie> addReal;

	private int myPlayerIndex;

	[Header("Counts")]
	public int totalUnloadedZombies;

	public int totalPropZombies;

	public int totalRealZombies;

	public int totalZombies;

	[Header("Debugging")]
	public bool drawZombiePaths;

	public bool drawZombieTarget;

	public bool drawZombies;

	public bool drawUnloadedZombies;

	public PropPool GetPool(Zombie.Type t)
	{
		return null;
	}

	public bool ZombieAlreadyExists(int id)
	{
		return false;
	}

	public void Init()
	{
	}

	private void CreatePoolForZombieProps()
	{
	}

	public void UpdateZombieLevels()
	{
	}

	public void CleanUp()
	{
	}

	public void CleanUpDolls(int maxDolls)
	{
	}

	public UnloadedZombie CreateUnloadedZombie(ZombieIdentity zIdentity, ZombieTransform zTransform, bool skipSpawnAnim)
	{
		return null;
	}

	public void CreateZombieProp(ZombieIdentity zIdentity, ZombieTransform zTransform, bool ssa)
	{
	}

	private void CreateRealZombie(ZombieIdentity zIdentity, ZombieTransform zTransform, bool skipSpawnAnim, bool autoActiveAI)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void SpawnZombieByLoadState(ZombieLoadState targetState, ZombieIdentity zIdentity, ZombieTransform zTransform, bool ssa, bool autoActiveAI)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void SpawnZombieByLoadState(ZombieLoadState targetState, AllPurposeZombie apz)
	{
	}

	public void OnZombieChangedState(int id)
	{
	}

	public void UpdateZombieLoadingStates()
	{
	}

	private void CalcSqrActiveDistance()
	{
	}

	public void ForceLoadRealZombie(int id)
	{
	}

	private AllPurposeZombie GetFromUnloadedZombie(UnloadedZombie uz, bool goActive)
	{
		return null;
	}

	private AllPurposeZombie GetFromPropZombie(ZombieProp prop, bool goActive)
	{
		return null;
	}

	private AllPurposeZombie GetFromRealZombie(Zombie z)
	{
		return null;
	}

	public void UpdateLoadState()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ZombieLoadState GetTargetZombieState(ZombieLoadState curState, int zombieIndex, out bool goActive)
	{
		goActive = default(bool);
		return default(ZombieLoadState);
	}

	public void ClearZombies()
	{
	}

	public UnloadedZombie GetUnloadedZombie(int zombieID)
	{
		return null;
	}

	public ZombieProp GetZombieProp(int zombieID)
	{
		return null;
	}

	public Zombie GetRealZombie(int zombieID)
	{
		return null;
	}

	public void RemovePropZombie(int zombieID)
	{
	}

	public void RemoveUnloadedZombie(int zombieID)
	{
	}

	public void OnDrawGizmos()
	{
	}
}
