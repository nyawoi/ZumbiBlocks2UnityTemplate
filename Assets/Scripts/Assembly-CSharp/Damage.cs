using System;
using UnityEngine;

[Serializable]
public class Damage
{
	public float amount;

	public Vector3 hitPoint;

	public Vector3 hitDirection;

	public float permanency;

	public bool dodgeOverride;

	public PlayerMain sourcePlayer;

	public Stagger stagger;

	public Damage(float am, Vector3 point, Vector3 dir, float perma, bool dodgeOR, PlayerMain pl, Stagger st)
	{
	}

	public Damage Clone()
	{
		return null;
	}

	public Damage(float amount)
	{
	}

	public Damage(float perma, bool dodgeOR, float am, Vector3 point, Vector3 dir)
	{
	}

	public Damage(Stagger st, PlayerMain sPlayer, float am, Vector3 point)
	{
	}

	public static void ProcessDamage(DamageTarget target, Damage dmg, bool localCall)
	{
	}
}
