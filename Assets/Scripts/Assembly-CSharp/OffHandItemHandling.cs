using System;

[Serializable]
public class OffHandItemHandling
{
	public OffhandHandlingAnimation[] animations;

	public bool IsOffHand(PlayerArms arms)
	{
		return false;
	}
}
