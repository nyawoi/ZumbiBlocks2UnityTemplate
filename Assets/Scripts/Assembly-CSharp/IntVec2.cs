using System;
using UnityEngine;

[Serializable]
public struct IntVec2
{
	public int x;

	public int y;

	public static IntVec2 One => default(IntVec2);

	public IntVec2(int x_, int y_)
	{
		x = x_;
		y = y_;
	}

	public static IntVec2 operator -(IntVec2 a, IntVec2 b)
	{
		return default(IntVec2);
	}

	public static IntVec2 operator -(IntVec2 a)
	{
		return default(IntVec2);
	}

	public static IntVec2 operator *(IntVec2 a, int f)
	{
		return default(IntVec2);
	}

	public static IntVec2 operator +(IntVec2 a, IntVec2 b)
	{
		return default(IntVec2);
	}

	public static bool operator ==(IntVec2 a, IntVec2 b)
	{
		return false;
	}

	public static bool operator !=(IntVec2 a, IntVec2 b)
	{
		return false;
	}

	public int Manhattan()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public Vector3 x0y()
	{
		return default(Vector3);
	}
}
