using System.Collections.Generic;
using UnityEngine;

public class MeleeAttackBase : MonoBehaviour
{
	public static MeleeAttackBase instance;

	public float reachMultiplier;

	public float dmgMultiplier;

	public LayerMask meleeHitLayermask;

	public List<PlayerMeleeAttack> attacks;

	public void Init()
	{
	}

	public PlayerMeleeAttack GetAttack(PlayerMeleeAttack.ID id)
	{
		return null;
	}
}
