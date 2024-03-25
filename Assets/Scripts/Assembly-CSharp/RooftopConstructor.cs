using System.Collections.Generic;
using UnityEngine;

public class RooftopConstructor
{
	public enum RoofType
	{
		None = 0,
		Standard = 1,
		Angled = 2
	}

	private class CornerNode
	{
		public IntVec2 pos;

		public IntVec2 dir;

		public byte height;

		public bool isConcave;

		public CornerNode curOther;

		public CornerNode(IntVec2 p, IntVec2 d, byte h, bool concave)
		{
		}
	}

	private static Color[] hColor;

	private const float roofOffset = 0.2f;

	private const float roofScale = 0.5f;

	private static GenericMeshGenerator meshGen;

	private static BuildingBlueprint building;

	private static IntVec2 roofgridSize;

	private static byte[,] roofgrid;

	private static List<CornerNode> openNodes;

	public static void GenerateBuildingRoof(BuildingBlueprint building_, GenericMeshGenerator meshGen_)
	{
	}

	private static RoofType GetRoofType()
	{
		return default(RoofType);
	}

	private static void GenerateAngledRoof()
	{
	}

	private static void GenerateStandardRoof()
	{
	}

	private static void FinalizeRoofPieces(byte baseH, byte roofColor)
	{
	}

	private static void PaintRoofSections()
	{
	}

	private static CornerNode GetNodeAt(IntVec2 pos)
	{
		return null;
	}

	private static bool TestContacts()
	{
		return false;
	}

	private static void FindInitialCorners(byte targetHeight, byte outside, byte overrideHeight)
	{
	}

	private static void MoveOpenNodes()
	{
	}

	private static void PaintBuildingNodes()
	{
	}

	private static Vector3 GetCellCenter(int x, int y)
	{
		return default(Vector3);
	}

	private static void DrawNodes()
	{
	}

	private static byte GetRoofH(IntVec2 vec2)
	{
		return 0;
	}

	private static byte GetRoofH(int x, int y)
	{
		return 0;
	}
}
