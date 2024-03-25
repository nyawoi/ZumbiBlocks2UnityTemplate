using System;
using UnityEngine;

[Serializable]
public struct ZombieTarget
{
	public enum Type
	{
		None = 0,
		Player = 1,
		Place = 2
	}

	public Type type;

	public PlayerMain player;

	public EntityLocation pos;

	public bool Exists => false;

	public PlayerMain GetPlayer()
	{
		return null;
	}

	public EntityLocation GetLocation()
	{
		return null;
	}

	public void SetPositionTarget(Vector3 pos3d)
	{
	}
}
