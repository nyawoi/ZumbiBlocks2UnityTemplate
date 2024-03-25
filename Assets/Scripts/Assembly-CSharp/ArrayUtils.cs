using System;
using System.Collections.Generic;

public static class ArrayUtils
{
	public static T GetRandom<T>(this T[] array)
	{
		return default(T);
	}

	public static int GetRandomIndex<T>(this T[] array)
	{
		return 0;
	}

	public static T GetRandom<T>(this List<T> list)
	{
		return default(T);
	}

	public static int GetRandomIndex<T>(this List<T> list)
	{
		return 0;
	}

	public static int GetRandomIndex<T>(this List<T> list, Random systemRandom)
	{
		return 0;
	}
}
