public class PlayerReviveInteraction : InteractableObject
{
	public PlayerMain player;

	public int subID;

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
}
