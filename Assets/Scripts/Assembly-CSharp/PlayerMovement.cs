using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public enum State
	{
		Transition = 0,
		Walk = 1,
		Jump = 2,
		Air = 3,
		Sprint = 4,
		Roll = 5,
		Stagger = 6,
		Dying = 7,
		Dead = 8,
		Melee = 9,
		Swim = 10,
		Vault = 11,
		ReviveFriend = 12,
		Recovering = 13
	}

	public PlayerMain playerMain;

	public PlayerInputReader input;

	[Header("Settings")]
	public Rigidbody body;

	public LayerMask groundMask;

	public float walkSpeed;

	public float walkSpeedDamp;

	public float airSpeedForce;

	public float jumpSpeed;

	[Header("Curves")]
	public float rollSpeed;

	public AnimationCurve rollSpeedCurve;

	[Header("StaggerAnimations")]
	public PlayerStaggerAnimation[] staggerAnimations;

	private PlayerStaggerAnimation curStagger;

	[Header("Ground detection")]
	public CapsuleCollider hitbox;

	public float sphereRadius;

	public float sphereCastDistance;

	[Header("State")]
	public State state;

	public State targetState;

	public float stateTimer;

	public bool touchingGround;

	[Header("Interaction")]
	public List<State> nonInteracitonState;

	[Header("Runtime")]
	public Vector2 speedCoef;

	public Vector2 targetSpeed;

	public Vector2 rollVector;

	public float mouseHor;

	public float waterDmgTimer;

	public float normTime;

	public bool genericAnimationTrigger;

	[Header("RuntimeMelee")]
	private PlayerMeleeHitDetector hitDetector;

	public PlayerMeleeAttack curMeleeAttack;

	public bool attackIsStrong;

	[Header("Reviving")]
	public PlayerMain reviveTarget;

	[Header("Vaulting")]
	public Vector2 capsuleHeight;

	public Vector2 capsuleY;

	public float capsuleCoef;

	public AnimationCurve vaultPosition;

	public AnimationCurve vaultHeight;

	[Header("Cur vault")]
	public bool vaultTrigger;

	public VaultHash.VaultSpot curVaultSpot;

	public Vector3 curVaultPoint;

	public Vector3 curVaultDir;

	public Animator PlayerAnimator => null;

	public float SwimHeight => 0f;

	public float WaterDMGHeight => 0f;

	public bool CanInteract => false;

	private void CrossFadeInFixedTime(string animName, float fixedTime, string sendFakeAnim = null)
	{
	}

	private void PlayAnimation(string animName)
	{
	}

	public bool IsRolling()
	{
		return false;
	}

	private Vector2 ReadMovementInput(bool forceSpeed = false)
	{
		return default(Vector2);
	}

	private float GetSprintSpeed()
	{
		return 0f;
	}

	private void ReadTargetSpeed(bool canSprint, bool immediate)
	{
	}

	private void DampSpeed(float dampSpeed)
	{
	}

	private void SetBodyVelocity(Vector2 speed)
	{
	}

	private void LerpBodyVelocitySelf(Vector2 speed, float lerpSpeed)
	{
	}

	private void UpdateWalkAnimation()
	{
	}

	public void GoToStateAfterTransitionAnimated(State s, string animationState, float fadeTime, bool forcePlay = false)
	{
	}

	private void GoToStateAfterTransition(State s)
	{
	}

	public void GetGround(bool fallDamage)
	{
	}

	public State GetEffectiveState()
	{
		return default(State);
	}

	public void EnterDyingState()
	{
	}

	public void Die()
	{
	}

	public void TryStagger()
	{
	}

	private void Roll()
	{
	}

	public void StartRevive(PlayerMain target)
	{
	}

	private bool TryVault()
	{
		return false;
	}

	public void UpdateMovement()
	{
	}

	private void TestMeleeTutorial(PlayerMeleeAttack.ID hitAttackID)
	{
	}

	public void EnterSwim(bool playSound = true)
	{
	}

	public void EnterWalkState(bool playSound = true)
	{
	}

	public void MeleeAttack(PhysicalMelee meleeWeapon, bool isStrong)
	{
	}

	public void MeleeAttack(PlayerMeleeAttack.ID attackID, bool isStrong)
	{
	}
}
