using UnityEngine;

public class InteractableFurniture : InteractableObject, DamageTarget
{
	public Furniture targetFurniture;

	public LODTarget lodTarget;

	[Header("Online ID")]
	public IntVec2 cellCoordinate;

	public int cellID;

	[Header("Sorting ID")]
	public ID sortID;

	public int sortSubID;

	[Header("Door Function")]
	public Transform doorPanelBody;

	[Header("Destroyable")]
	public FXProp.ID fxID;

	public Transform refFXTransform;

	public Collider[] destroyableCollider;

	public Renderer[] destroyableRenderer;

	public FXProp.ID hitFxID;

	[Header("Audio")]
	public AudioPlayer audioPlayer;

	public AudioPack[] audioFX;

	[Header("Base")]
	public byte baseState;

	public byte baseHealth;

	public float dynamicTimeout;

	[Header("Runtime")]
	public byte state;

	public byte health;

	public float dynamicTimer;

	public bool Dirty => false;

	public bool IsDestroyable => false;

	public bool IsDestroyed => false;

	public bool SpawnFXLocally()
	{
		return false;
	}

	public FXProp.ID GetFXProp(Damage dmg)
	{
		return default(FXProp.ID);
	}

	public override ID GetInteractableID()
	{
		return default(ID);
	}

	public override string GetObjectName()
	{
		return null;
	}

	public override int GetSubID()
	{
		return 0;
	}

	public void UpdateColliding()
	{
	}

	public void UpdateRendering()
	{
	}

	public void ApplyInteraction(byte targetState)
	{
	}

	public void SetState(byte tState, bool forceUpdate = false)
	{
	}

	public void PlayAudio(int index)
	{
	}

	public void TakeDamage(Damage dmg)
	{
	}

	public void DamageFurniture(int dmg)
	{
	}

	public void SetHealth(byte h)
	{
	}

	public void SetDestroyed(bool b)
	{
	}

	public void ServerSideStateBroadcast()
	{
	}

	public void ClientSideSendDamage(float dmg)
	{
	}
}
