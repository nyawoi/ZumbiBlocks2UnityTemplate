using System;

[Serializable]
public class StaggerPack
{
	public enum ID
	{
		None = 0,
		QuickBasic = 1,
		LegSweep = 2,
		CrowdControl = 3,
		Butting = 4,
		Stun = 5
	}

	public ID id;

	public float staggerTime;

	public StaggerID[] animationID;

	public int[] prob;
}
