using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
	public PlayerMain playerMain;

	public List<InteractableObject> objectsToInteract;

	public int currentSelected;

	private InteractableObject selectedObject;

	[HideInInspector]
	public InteractableObjectComprarer ioc;

	public LayerMask interactionMask;

	public void MyUpdate()
	{
	}

	public InteractableObject GetInteractObject()
	{
		return null;
	}

	public void AddInteraction(InteractableObject interactableObj)
	{
	}

	public void ClearInteractions()
	{
	}

	public bool CanInteract(InteractableObject interactableObj)
	{
		return false;
	}

	public void Interact(InteractableObject interactableObj)
	{
	}

	public void GotLootFromServer(InventoryItem.ID itemID, int numericvalue)
	{
	}
}
