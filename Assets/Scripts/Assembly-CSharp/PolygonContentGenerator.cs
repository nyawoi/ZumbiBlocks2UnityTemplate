using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class PolygonContentGenerator : MonoBehaviour
{
	public enum SpecialCellID : byte
	{
		Corridor = 252,
		Balcony = 253,
		ReservedID = 254,
		OutOfPolygon = byte.MaxValue
	}

	public const float cellSize = 2.5f;

	public Vector3 localForwardVec3;

	public Vector3 localRightVec3;

	public Vector3 localStartPos;

	protected IntVec2 initialIntBounds;

	protected List<IntVec2> freeCells;

	protected byte[,,] initCell;

	protected Vector3 gatePos;

	[HideInInspector]
	public static System.Random rand;

	private List<IntVec2> closeNodeList;

	protected IntVec2 RandomFreeCell => default(IntVec2);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool IsRoomID(byte id)
	{
		return false;
	}

	protected void FindFreeCells()
	{
	}

	public static bool IsOutdoors(byte b)
	{
		return false;
	}

	public static bool IsCorridor(byte b)
	{
		return false;
	}

	public byte GetCellID(int floorIndex, int x, int y)
	{
		return 0;
	}

	public abstract bool GeneratePolygonContent(Polygon poly);

	public virtual void AddWindow(Furniture.ID windowID, IntVec2 p1, IntVec2 p2, int floorIndex)
	{
	}

	protected void GenerateGridFor(Polygon poly, int floorCount, int additionalShrinkPasses)
	{
	}

	private void ShrinkNodes()
	{
	}

	private void ShrinkBorder()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void SetOutOfPolygon(int f, int x, int y, List<IntVec2> closeNodes = null)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool IsInsideInitialBounds(IntVec2 curPos)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool IsInsideInitialBounds(int x, int y)
	{
		return false;
	}

	protected void CalculateBoundsFor(Polygon poly)
	{
	}

	public void ClearReservedIDs()
	{
	}

	protected void GenerateHouseVegetation(Polygon poly, List<Furniture.WallInstance> doors, float treeProb, bool treeAlive = true)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector3 GetCellPosition(IntVec2 pos)
	{
		return default(Vector3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector3 GetCellPosition(int x, int y)
	{
		return default(Vector3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector3 GetCellCenter(IntVec2 pos)
	{
		return default(Vector3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector3 GetCellCenter(int x, int y)
	{
		return default(Vector3);
	}

	public Vector3 GetPointInLocalSpace(Vector3 pos)
	{
		return default(Vector3);
	}
}
