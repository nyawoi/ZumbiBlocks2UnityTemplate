using System;
using System.Collections.Generic;

[Serializable]
public class SaveProgress
{
	public int tutorialProgressV2;

	public int tutorialVersion;

	public List<LoadoutUnlockable.ID> unlockedLoadout;

	public PreferredLoadout[] preferredLoadout;

	public SkinDatabase.SkinID preferredSkinID;

	public SkinDatabase.Gender preferredGender;

	public int preferredSkinColor;
}
