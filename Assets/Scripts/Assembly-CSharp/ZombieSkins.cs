using System;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSkins : MonoBehaviour
{
	[Serializable]
	public class SubClassSkins
	{
		public Zombie.SubClass subclass;

		[Header("Settings")]
		public Material[] materials;

		public Mesh[] meshes;

		[Header("Runtime")]
		public int[] materialIndex;

		public int[] meshIndex;

		public void Init(ZombieSkins skins)
		{
		}
	}

	public static ZombieSkins instance;

	[Header("Subclass")]
	public SubClassSkins basicSkins;

	public SubClassSkins factorySkins;

	private List<Material> zombieMaterial;

	private List<Mesh> zombieMesh;

	public Material GetMaterial(byte index)
	{
		return null;
	}

	public Mesh GetMesh(byte index)
	{
		return null;
	}

	public Material GetMaterial(int index)
	{
		return null;
	}

	public Mesh GetMesh(int index)
	{
		return null;
	}

	private int GetMaterialIndex(Material material)
	{
		return 0;
	}

	private int GetMeshIndex(Mesh mesh)
	{
		return 0;
	}

	public void Init()
	{
	}

	private void RegisterMaterialsAndSkins(SubClassSkins skins)
	{
	}

	private SubClassSkins GetSubClassSkins(Zombie.SubClass subClass)
	{
		return null;
	}

	public byte SelectMeshForZombie(Zombie.SubClass subClass)
	{
		return 0;
	}

	public byte SelectMaterialForZombie(Zombie.SubClass subClass)
	{
		return 0;
	}
}
