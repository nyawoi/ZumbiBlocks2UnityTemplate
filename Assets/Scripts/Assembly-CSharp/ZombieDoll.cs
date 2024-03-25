using UnityEngine;

public class ZombieDoll : MonoBehaviour
{
	public SkinnedMeshRenderer meshRenderer;

	public Transform[] armatureBone;

	public Rigidbody[] armaturePhysics;

	public Transform targetParent;

	public bool copyArmature;

	public bool getBodies;

	public void SetSkin(Mesh mesh, Material mat)
	{
	}

	public void CopyArmature(ZombieObject original, Vector3 deathForce)
	{
	}

	public void OnDrawGizmos()
	{
	}
}
