using System;
using UnityEngine;

[Serializable]
public class Buffer
{
	public byte[] content;

	public int writeCount;

	public int readCount;

	public Buffer()
	{
	}

	public Buffer(int capacity)
	{
	}

	public void SetContentReferenceForReading(byte[] contentReference)
	{
	}

	public void StartWrite()
	{
	}

	public void StartRead(int at = 2)
	{
	}

	public void PushByte(int i)
	{
	}

	public void PushByte(byte b)
	{
	}

	public byte GetByte()
	{
		return 0;
	}

	public void PushBool(bool b)
	{
	}

	public bool GetBool()
	{
		return false;
	}

	public void PushInt(int v)
	{
	}

	public int GetInt()
	{
		return 0;
	}

	public void PushFloat(float v)
	{
	}

	public float GetFloat()
	{
		return 0f;
	}

	public void PushVector3(Vector3 vec3)
	{
	}

	public Vector3 GetVector3()
	{
		return default(Vector3);
	}

	public void PushVector2(Vector2 vec2)
	{
	}

	public Vector2 GetVector2()
	{
		return default(Vector2);
	}

	public void PushQuaternion(Quaternion q)
	{
	}

	public Quaternion GetQuaternion()
	{
		return default(Quaternion);
	}

	public void PushTriangle(Triangle tri)
	{
	}

	public Triangle GetTriangle()
	{
		return null;
	}

	public void PushVegetationInstance(Polygon.VegetationInstance veg)
	{
	}

	public Polygon.VegetationInstance GetVegetationInstance()
	{
		return default(Polygon.VegetationInstance);
	}

	public IntVec2Couple GetIntVec2Couple(int add = 0)
	{
		return null;
	}

	public Furniture.WallInstance GetWallFurni(int add = 0)
	{
		return default(Furniture.WallInstance);
	}

	public void PushFurnitureInstance(Furniture.Instance inst)
	{
	}

	public Furniture.Instance GetFurniture()
	{
		return null;
	}

	public void PushYardFurnitureInstance(Furniture.YardDecor inst)
	{
	}

	public Furniture.YardDecor GetYardFurniture()
	{
		return null;
	}

	public void PushStagger(Stagger st)
	{
	}

	public Stagger GetStagger()
	{
		return null;
	}
}
