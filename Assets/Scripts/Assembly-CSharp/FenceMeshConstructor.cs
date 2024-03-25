using UnityEngine;

public class FenceMeshConstructor
{
	private static GenericMeshGenerator meshGen;

	private const float shortWallHeight = 1f;

	private const float midWallHeight = 2f;

	private const float tallWallHeight = 3f;

	private const float concreteFenceHeight = 1f;

	public static void GenFence(byte uvIndex, Vector3 startPos, Vector3 endPos, GenericMeshGenerator meshGen_, FenceType fenceType, FenceMode mode)
	{
	}

	public static void GenFenceConn(byte uvIndex, Vector3 pos, Vector3 avgVector, GenericMeshGenerator meshGen_, FenceType fenceType)
	{
	}

	public static void GenConcreteFence(byte uvIndex, Vector3 startPos, Vector3 endPos, FenceMode mode)
	{
	}

	public static void GenConcreteFenceConn(byte uvIndex, Vector3 pos, Vector3 avgVector)
	{
	}
}
