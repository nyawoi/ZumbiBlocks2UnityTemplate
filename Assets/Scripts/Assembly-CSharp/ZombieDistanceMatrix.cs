using System.Runtime.CompilerServices;
using UnityEngine;

public class ZombieDistanceMatrix : MonoBehaviour
{
	public const int defaultZombiePadding = 512;

	public static ZombieDistanceMatrix instance;

	public int curZombieCap;

	public int curPlayerCap;

	[HideInInspector]
	public float[,] matx;

	[Header("References")]
	public ZombieLoader loader;

	public PlayersController playerController;

	public void AllocateMatrix(int zombieCap)
	{
	}

	public void Init()
	{
	}

	public void CleanUp()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void BakeDistancesForZombie(float x, float z, int zIndex)
	{
	}

	public void BakeSqrDistances()
	{
	}
}
