using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class CustomZombieObject : MonoBehaviour
{
	[Serializable]
	public class Contact
	{
		public DamageTarget obj;

		public float cooldown;

		public Contact(DamageTarget p, float cd)
		{
		}
	}

	public ZombieObject parentObject;

	public float defaultContactCD;

	private List<Contact> contacts;

	[Header("Audio")]
	public AudioPlayer audioPlayer;

	[Header("Effects")]
	public TrailRenderer[] trails;

	public LaserController[] laser;

	public Transform[] pivot;

	[Header("RUNTIME Prop State")]
	public int curPropState;

	[Header("RUNTIME Kill Count")]
	public List<BossDamageTracker> damageTracker;

	public void Attach(Transform attachee, Transform attachPoint)
	{
	}

	public void TrackDamage(PlayerMain player, float damage)
	{
	}

	public void Update()
	{
	}

	public bool HasContact(DamageTarget p)
	{
		return false;
	}

	public bool TryAddContact(DamageTarget p)
	{
		return false;
	}

	public void SetPropState(int v)
	{
	}

	public virtual void TreatPropState(int v)
	{
	}

	public virtual void EjectCasing()
	{
	}

	public virtual void ShootGun(Vector3? dir = null)
	{
	}

	public virtual void AnimateProp(string str)
	{
	}
}
