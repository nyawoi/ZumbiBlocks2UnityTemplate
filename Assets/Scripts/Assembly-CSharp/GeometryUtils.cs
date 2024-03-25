using UnityEngine;

public class GeometryUtils
{
	public static IntVec2[] directions;

	public static IntVec2[] squareCorners;

	public const int iUP = 0;

	public const int iUPRIGHT = 1;

	public const int iRIGHT = 2;

	public const int iDOWNRIGHT = 3;

	public const int iDOWN = 4;

	public const int iDOWNLEFT = 5;

	public const int iLEFT = 5;

	public const int iUPLEFT = 5;

	public static IntVec2 UP => default(IntVec2);

	public static IntVec2 UPRIGHT => default(IntVec2);

	public static IntVec2 RIGHT => default(IntVec2);

	public static IntVec2 DOWNRIGHT => default(IntVec2);

	public static IntVec2 DOWN => default(IntVec2);

	public static IntVec2 DOWNLEFT => default(IntVec2);

	public static IntVec2 LEFT => default(IntVec2);

	public static IntVec2 UPLEFT => default(IntVec2);

	public static IntVec2 GetRight(int directionIndex)
	{
		return default(IntVec2);
	}

	public static IntVec2 GetRight(IntVec2 direction)
	{
		return default(IntVec2);
	}

	public static IntVec2 GetCorner(IntVec2 bl, IntVec2 tr, byte corner)
	{
		return default(IntVec2);
	}

	public static bool IsInsideBounds(Vector2 bottomLeft, Vector2 topRight, Vector2 p)
	{
		return false;
	}

	public static float RandomAngleDegrees()
	{
		return 0f;
	}

	public static Vector3 PolarCoordinateXZ(float angleDegrees, float radius)
	{
		return default(Vector3);
	}

	public static Vector3 RandomVector3(Vector3 v1, Vector3 v2)
	{
		return default(Vector3);
	}

	public static int ManhatanDistance(IntVec2 p1, IntVec2 p2)
	{
		return 0;
	}

	public static int GetDirectionIndex(IntVec2 v)
	{
		return 0;
	}

	public static Vector2 ClosestPointToLine(Vector2 v, Vector2 w, Vector2 p)
	{
		return default(Vector2);
	}

	public static bool IntersectBounds(IntVec2 p1, IntVec2 size1, IntVec2 p2, IntVec2 size2)
	{
		return false;
	}

	public static Vector2 Rotate2DNormalized(Vector2 p, Vector2 rotationVectorNormalized)
	{
		return default(Vector2);
	}

	public static Vector2? SegmentIntersection(Line2D l1, Line2D l2)
	{
		return null;
	}

	public static Vector2? SegmentIntersection(Line2D l1, Line2D l2, out float t)
	{
		t = default(float);
		return null;
	}

	public static bool SegmentIntersectsHoritontal(Line2D horLine, Line2D arbitraryLine)
	{
		return false;
	}

	public static Vector3 RandomTrianglePoint(Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(Vector3);
	}

	public static bool PointInTriangle(Vector2 a, Vector2 b, Vector2 c, Vector2 p)
	{
		return false;
	}

	public static void PITW(Vector2 a, Vector2 b, Vector2 c, Vector2 p, out float w1, out float w2)
	{
		w1 = default(float);
		w2 = default(float);
	}

	public static bool CrossingNumber(Polygon poly, Vector2 point)
	{
		return false;
	}

	public static bool PointInPolygon(Polygon poly, Vector2 point)
	{
		return false;
	}

	public static bool PointInPolygonShrinked(Polygon poly, Vector2 point, float shrinkFactor)
	{
		return false;
	}

	private static float Squared(float x)
	{
		return 0f;
	}

	private static float DistanceSquared(Vector2 v, Vector2 w)
	{
		return 0f;
	}

	private static float DistToSegmentSquared(Vector2 point, Vector2 start, Vector2 end, out float t)
	{
		t = default(float);
		return 0f;
	}

	public static double DistanceToSegment(Vector2 p, Vector2 v, Vector2 w, out float t)
	{
		t = default(float);
		return 0.0;
	}
}
