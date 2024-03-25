using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ZombiePositionSync
{
	[Serializable]
	public class PosPack
	{
		public Vector3 pos;

		public float angle;

		public PosPack(Vector3 p, float a)
		{
		}
	}

	public int zombieID;

	public float deltaPrecision;

	public List<PosPack> posBuffer;

	public const int bufferMax = 5;

	public const float lerpExtraSpeed = 1f;

	public float curLerpT;

	public SmoothedVector3 positionHistory;

	public SmoothedFloat speedHistory;

	public Vector3 lerpedForward;

	public float deltaAngle;

	public ZombieLoader.ZombieLoadState zombieLoadState;

	[HideInInspector]
	public UnloadedZombie unloadedZombie;

	[HideInInspector]
	public ZombieProp zombieProp;

	[HideInInspector]
	public Zombie realZombie;

	[HideInInspector]
	public Transform physicalZombie;

	public float unusedTimer;

	public static float lerpSpeed => 0f;

	public bool foundZombie => false;

	public void FindZombieReference()
	{
	}

	public ZombieIdentity GetZombieIdentity()
	{
		return default(ZombieIdentity);
	}

	public Vector3 GetZombiePosition()
	{
		return default(Vector3);
	}

	public void UpdatePosition()
	{
	}

	private void UpdateZombieAnimator()
	{
	}

	private void UpdatePositionData()
	{
	}

	internal Vector3 GetDeltaPosVec3(byte dx, byte dy, byte dz)
	{
		return default(Vector3);
	}
}
