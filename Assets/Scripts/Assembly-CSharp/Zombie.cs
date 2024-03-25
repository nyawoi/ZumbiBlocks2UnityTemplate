using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Zombie : DamageTarget
{
	public enum State
	{
		Transition = 0,
		Spawning = 1,
		Unaware = 2,
		Aware = 3,
		Air = 4,
		Attack = 5,
		Stagger = 6,
		Dying = 7,
		Dead = 8,
		Climbing = 9,
		BossAction = 10,
		Vaulting = 11,
		FlyingAware = 12
	}

	public enum AIState
	{
		Idle = 0,
		Wander = 1,
		Investigate = 2,
		Combat = 3
	}

	public enum PathAIState
	{
		Idle = 0,
		NoOutdoorPath = 1,
		OutdoorMoving = 2,
		SameFeatureMoving = 3,
		Combat = 4
	}

	public enum Type
	{
		BasicZombie = 0,
		BossRiot = 1,
		BossQueen = 2,
		COUNT = 3
	}

	public enum SubClass
	{
		EasyRegion = 0,
		MediumRegion = 1,
		HardRegion = 2,
		InsaneRegion = 3,
		FactoryWorker = 4,
		Boss = 5
	}

	public struct LocalTarget
	{
		public enum Type
		{
			WalkFeatureTransition = 0,
			ClimbFeatureTransition = 1,
			EndTarget = 2
		}

		public Vector3 pos3D;

		public Type type;
	}

	public struct PossibleTarget
	{
		public PlayerMain player;

		public float val;

		public bool visibleThisFrame;
	}

	[Header("Settings")]
	public ZombieIdentity identity;

	public ZombieProperties properties;

	public ZombieObject obj;

	public ZombieHealth health;

	[Header("State machine")]
	public bool sleeping;

	public State state;

	public State targetState;

	[Header("Flying")]
	public bool isFlying;

	public float flyDistance;

	public float flyHeight;

	public float flyParamTimer;

	public float flyingClimbTimer;

	public float verticalSpeed;

	[Header("Strafe")]
	public float strafeTimer;

	public float strafeEffectiveTimer;

	public float strafeSpeed;

	[Header("Runtime vars")]
	public Vector2 movementCoef;

	public float forwardSpeed;

	public bool attackHit;

	public float slowFactor;

	public float climbCooldown;

	public bool unstaggarable;

	public float aggroSoundCooldown;

	private ZombieDeathAnimation curDeathAnimation;

	private ZombieAttack curAttack;

	[Header("Vault")]
	private VaultHash.VaultSpot curVaultSpot;

	private float vaultHeight;

	[Header("Stuck detection")]
	public float stuckTimer;

	public Vector3 stuckPos;

	[Header("Aux")]
	public int zombieIndex;

	public ZombieDebugUIText debugText;

	[Header("Boss")]
	private BossBehaviour bossBehaviour;

	[Header("Syncs")]
	public float? posSyncDeltaPrecision;

	public bool duringNetSync;

	public Vector3 lastSyncPos;

	[Header("Target finding")]
	public float targetFindTimer;

	public float reachabilityTimer;

	public List<PossibleTarget> possibleTargets;

	[Header("AI State")]
	public AIState aiState;

	public PathAIState pathingState;

	[Header("AI Target")]
	public ZombieTarget target;

	public float targetDistance;

	public bool targetReachable;

	public float repathTimer;

	public int repathCount;

	public float giveUpTimer;

	[Header("Other runtime stuff")]
	public EntityLocation entityLocation;

	private ZombieAttack targetAttack;

	private ZombieAttack attackCandidate;

	public float attackCandidateTimer;

	[Header("Pathing")]
	private LocalTarget localTarget;

	public Vector3 immediateTarget;

	private bool move;

	private bool immediateIsPathPoint;

	private List<PathingNode> featurePath;

	private YardPath localPath;

	private float reassureFeaturePathTimer;

	public ZombieTransform Transform => default(ZombieTransform);

	public static float WaterDMGHeight => 0f;

	public bool IsBoss => false;

	private float TopSpeed => 0f;

	private float TopHealth => 0f;

	private float MyDamage => 0f;

	public float StrafeSpeed => 0f;

	public float stuckThreshold => 0f;

	public float stuckTime => 0f;

	public BossBehaviour GetBossBehaviour => null;

	private bool hasLocalPath => false;

	public static float GetTopSpeed(float mobility = 10f)
	{
		return 0f;
	}

	private float CurrentTopSpeed()
	{
		return 0f;
	}

	public bool IsWalkState()
	{
		return false;
	}

	public Zombie(ZombieObject obj_, ZombieIdentity identity)
	{
	}

	public void Init(bool skipSpawn)
	{
	}

	public void DefineZombieLevel()
	{
	}

	public void SetSleep(bool b)
	{
	}

	public void SetState(State s)
	{
	}

	public Vector3 SafeTargetPosition()
	{
		return default(Vector3);
	}

	public State EffectiveState()
	{
		return default(State);
	}

	private void Attack(ZombieAttack zAttack)
	{
	}

	public void UpdateStateMachine(int zombieIndex_)
	{
	}

	private void WalkState(Vector3 curPos, Vector3 targetPos3D)
	{
	}

	public void UpdateBossBehaviour()
	{
	}

	public void UpdatePhysicsAndAnimation()
	{
	}

	private void PlayAnimationState(string anim, float fadeDur, State tState, bool broadcast = true)
	{
	}

	public void UpdateVerticalSpeed(Vector3 targetPos3D, Vector3 curPos)
	{
	}

	public float GetTargetAcquireSpeed(float sqrMaxDistance, float sqrDistance, float sightDot)
	{
		return 0f;
	}

	private void DebugDrawAcquireSpeed()
	{
	}

	public void FindTarget(float targetAcquireSpeed, float retargetChance)
	{
	}

	public int AddAggroForPlayer(PlayerMain player, float increment)
	{
		return 0;
	}

	public void SetTargetPlayer(PlayerMain targetPlayer)
	{
	}

	private void UpdateRigidBodySpeed()
	{
	}

	private void UpdateAnimatorParameters()
	{
	}

	public void SetSpeed(Vector2 target, float transitionSpeed)
	{
	}

	public void SetSpeedX(float target, float transitionSpeed)
	{
	}

	public void SetSpeedY(float target, float transitionSpeed)
	{
	}

	public void SetStrafeSpeed(float target, float transitionSpeed)
	{
	}

	public bool SpawnFXLocally()
	{
		return false;
	}

	public FXProp.ID GetFXProp(Damage dmg)
	{
		return default(FXProp.ID);
	}

	public void TakeDamage(Damage dmg)
	{
	}

	public void DestroyAndSpawnDoll(GameObject zombieDollPrefab, Mesh mesh, Material mat, bool isBoss, bool useDoll = true)
	{
	}

	private void TryClimb(bool attackOnFail)
	{
	}

	private void BlockadeAttack()
	{
	}

	public void ReceiveAnimation(byte mode, byte animationIndex, byte param)
	{
	}

	public int GetPossibleTargetIndex(PlayerMain player)
	{
		return 0;
	}

	private void TargetAcquisition()
	{
	}

	public void AIUpdate()
	{
	}

	private void TreatGivingUp()
	{
	}

	private ZombieAttack GetRandomAttack()
	{
		return null;
	}

	private void GetTargetReachability()
	{
	}

	public void InvestigatePosition(Vector3 pos)
	{
	}

	public void GoIdle()
	{
	}

	public void EnterCombatPathing()
	{
	}

	public void PathingAI()
	{
	}

	private void TreatLocaPath()
	{
	}

	private void UpdateFeaturePath()
	{
	}

	private void CalculateLocalTarget()
	{
	}

	private void CalculateLocalPath()
	{
	}

	private void FindLocalPathByType()
	{
	}

	private void FindLocalPathInBuilding()
	{
	}

	private void IndoorsPathing(int myFloorIndex, BuildingBlueprint building, EntityLocation targetLocation)
	{
	}

	private BuildingBlueprint.Floor GetFloorOnCurrentBuilding(int floorIndex)
	{
		return null;
	}

	private void GoDownstairs(int floorIndex)
	{
	}

	private void GoUpstairs(int floorIndex)
	{
	}

	private void LeaveHousePathing(int myFloorIndex, EntityLocation targetLocation)
	{
	}

	private void FindLocalPathAroundYard()
	{
	}

	private void GetDirectLocalPath()
	{
	}

	public void UpdateImmediateTarget()
	{
	}

	private void ResetPathing()
	{
	}

	private void VerifyPathConsistency()
	{
	}

	public void VerifyLocalPathConsistency(EntityLocation targetLocation)
	{
	}

	private Line2D LineZombieToTarget()
	{
		return default(Line2D);
	}

	private void DitchFullPaths()
	{
	}

	public void DebugPaths()
	{
	}
}
