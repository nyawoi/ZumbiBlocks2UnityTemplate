using System;
using UnityEngine;

public class PlayerMain : MonoBehaviour, DamageTarget, DamageTaker
{
	public enum HealthState
	{
		Alive = 0,
		Dying = 1,
		Dead = 2
	}

	[Header("Lights")]
	public Light nightLight;

	public Light muzzleLight;

	[Header("Skin")]
	public CharacterSkin spawnedSkin;

	[Header("Script References")]
	public PlayerMovement movement;

	public PlayerArms arms;

	public PlayerCamera cam;

	public PlayerInventory inventory;

	public PlayerInputReader input;

	public PlayerInteraction interaction;

	public PlayerStatusEffects statusEffects;

	public PlayerAudio audio;

	public NoClip noClip;

	public Sizzling sizzling;

	public PlayerReviveInteraction reviveInteraction;

	[Header("Online stuff")]
	public PlayerPositionSynchronizer posSync;

	private PlayerControlEnabler controlEnabler;

	[NonSerialized]
	[HideInInspector]
	public LobbyPlayer lobbyPlayer;

	[Header("Health settings")]
	public float healthSlowMin;

	public float fastHealthBaseRegen;

	public float slowHealthBaseRegen;

	public float defaultHeight;

	[Header("Health")]
	public HealthState healthState;

	public float maxHealth;

	public float healthFast;

	public float healthSlow;

	[Header("Stamina settings")]
	public float staminaBaseRegenFactor;

	public float staminaBaseDrain;

	public float staminaSlowFactor;

	[Header("Stamina")]
	public float maxStamina;

	public float staminaFast;

	public float staminaSlow;

	public float staminaUsabilityCooldown;

	private float staminaRegenCooldown;

	[Header("Respawn request")]
	public float deadTimer;

	public bool requestedRespawn;

	[Header("Location")]
	public EntityLocation entityLocation;

	[Header("Muzzle light")]
	public float muzzleLightTimer;

	[HideInInspector]
	public PhysicalGun.MuzzleLight? muzzleLightSettings;

	public Animator MyAnimator => null;

	public PlayerSpineControl SpineControl => null;

	public PlayerControlEnabler ControlEnabler => null;

	public bool HasLocalControl => false;

	public bool SyncingLocalControl => false;

	public bool ForeignPlayer => false;

	public float respawnTime => 0f;

	private void Start()
	{
	}

	public void UpdateMuzzleLight()
	{
	}

	public void SetMuzzleLight(DatabaseGun gun)
	{
	}

	public void SetLobbyReference(LobbyPlayer slottedPlayer)
	{
	}

	public void SetSkin(CharacterSkin skin)
	{
	}

	public void RespawnAt(Vector3 pos)
	{
	}

	public void Revive()
	{
	}

	public void SetHealthState(HealthState h, bool sync = false)
	{
	}

	public void SetKinematic()
	{
	}

	public void StartSyncingByPlayer()
	{
	}

	public void OnControlEnabled()
	{
	}

	public bool CanInteract()
	{
		return false;
	}

	public void Update()
	{
	}

	private void UpdateLocallyControlled()
	{
	}

	private void ReadDebugInput()
	{
	}

	public void LateUpdate()
	{
	}

	public void AggroZombiesBySound(float range)
	{
	}

	private void ClampStamina()
	{
	}

	public void DrainStamina(float amount, StaminaDrainEffect staminaDrainEffect)
	{
	}

	public bool CanUseStamina()
	{
		return false;
	}

	private void ProcessStamina()
	{
	}

	private void ProcessHealth()
	{
	}

	private void DieForGood()
	{
	}

	public DamageTarget GetTarget()
	{
		return null;
	}

	public float GetDamageMultiplier()
	{
		return 0f;
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

	public Vector3 GroundPosition(Vector3 origin)
	{
		return default(Vector3);
	}

	public void OnDrawGizmos()
	{
	}
}
