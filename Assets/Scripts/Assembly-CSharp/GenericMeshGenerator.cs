using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GenericMeshGenerator
{
	public static int byteCount;

	public List<Vector3> vertexList;

	public List<byte> uvList;

	public int uvTextureSize;

	public void StartMeshCreation(int uvSize)
	{
	}

	public void PushWall(byte uvIndex, Vector3 startPos, Vector3 endPos, float height, float width, byte faceMask = byte.MaxValue)
	{
	}

	public void PushTriangleElevated(Vector3 v1, Vector3 v2, Vector3 v3, byte uvIndex, float h)
	{
	}

	public void PushTriangleCCW(Vector3 v1, Vector3 v2, Vector3 v3, byte uvIndex)
	{
	}

	public void PushTriangle(Vector3 v1, Vector3 v2, Vector3 v3, byte uvIndex)
	{
	}

	public void PushQuad(Vector3 v1, Vector3 v2, Vector3 v3, Vector3 v4, byte uvIndex)
	{
	}

	public void PushQuadCCW(Vector3 v1, Vector3 v2, Vector3 v3, Vector3 v4, byte uvIndex)
	{
	}

	public void PushQuadElevated(Vector3 v1, Vector3 v2, Vector3 v3, Vector3 v4, byte uvIndex, float elevation)
	{
	}

	public void PushQuadElevatedCCW(Vector3 v1, Vector3 v2, Vector3 v3, Vector3 v4, byte uvIndex, float elevation)
	{
	}

	public Vector2 GetUv(byte index, int mode)
	{
		return default(Vector2);
	}

	public void ApplyMeshTo(MeshFilter filter, MeshCollider collider, Vector3 offset)
	{
	}

	public void FinalizeMesh(Mesh mesh, Vector3 offset, bool optmize, bool countBytes = false)
	{
	}

	public void DebugDraw(Color c, float duration)
	{
	}

	public void DebugDraw(Color c, float duration, Vector3 offset)
	{
	}
}
