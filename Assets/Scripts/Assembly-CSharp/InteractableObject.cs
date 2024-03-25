using UnityEngine;

public abstract class InteractableObject : MonoBehaviour
{
	public enum ID
	{
		Loot = 0,
		Door = 1,
		Revive = 2
	}

	public abstract ID GetInteractableID();

	public abstract int GetSubID();

	public abstract string GetObjectName();
}
