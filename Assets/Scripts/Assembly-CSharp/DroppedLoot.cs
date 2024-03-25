using UnityEngine;

public class DroppedLoot : InteractableObject
{
	public Renderer lightRenderer;

	public GameObject obj3D;

	[HideInInspector]
	public InventoryItem item;

	public int id;

	public float timer;

	public void Init(InventoryItem item_, int id_)
	{
	}

	public override ID GetInteractableID()
	{
		return default(ID);
	}

	public override int GetSubID()
	{
		return 0;
	}

	public override string GetObjectName()
	{
		return null;
	}
}
