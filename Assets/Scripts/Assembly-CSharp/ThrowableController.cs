using System.Collections.Generic;
using UnityEngine;

public class ThrowableController : MonoBehaviour
{
	public static ThrowableController instance;

	public Transform holder;

	public int localIDPool;

	public List<ThrowableInstance> instances;

	public LayerMask groundMask;

	public float syncFreq;

	public float syncTimer;

	private void Update()
	{
	}

	private void ProcessThrowable(ThrowableInstance instance, bool sync)
	{
	}

	private void ProcessLocalInstance(ThrowableInstance instance, bool sync)
	{
	}

	private void LocalInstanceTimedOut(ThrowableInstance instance)
	{
	}

	private static void SyncInstancePosition(ThrowableInstance instance, bool sync)
	{
	}

	public void OnLootRemoved(ThrowableInstance instance)
	{
	}

	public void RemoveInstance(int lobbyID, int utilityID)
	{
	}

	public void SetInstancePos(int lobbyID, int utilityID, Vector3 pos, Quaternion q)
	{
	}

	private void ExplodeThrowable(ThrowableInstance tInst)
	{
	}

	public ThrowableInstance Spawn(InventoryItem.ID id, GameObject thrower, Vector3 pos, Transform tRef, bool localControl, Vector3? speed = null, Transform target = null)
	{
		return null;
	}

	public void Init()
	{
	}

	public void CleanUp()
	{
	}
}
