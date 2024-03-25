using System.Collections.Generic;
using UnityEngine;

public class PlayerMeleeHitDetector
{
	public class VectorAndTime
	{
		public Vector3 origin;

		public Vector3 vector;

		public float time;
	}

	public List<VectorAndTime> history;

	public List<DamageTaker> alreadyHit;

	public List<InteractableFurniture> alreadyHitFurni;

	public InteractableFurniture latestHitFurniture;

	private float hitStart;

	private float hitEnd;

	private int layerMask;

	private float step;

	private float curTime;

	public void Reset(float hStart, float hEnd, int lMask)
	{
	}

	public VectorAndTime GetLerpVector(float time)
	{
		return null;
	}

	public DamageTaker AddVectorAndTime(Vector3 playerPos, Vector3 origin, Vector3 vec, float time, out Vector3 outHit)
	{
		outHit = default(Vector3);
		return null;
	}
}
