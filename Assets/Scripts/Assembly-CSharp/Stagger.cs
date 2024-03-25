using System;

[Serializable]
public class Stagger
{
	public StaggerPack.ID staggerPackID;

	public float chance;

	public static Stagger Standard;

	public Stagger()
	{
	}

	public Stagger(StaggerPack.ID id, float rate)
	{
	}
}
