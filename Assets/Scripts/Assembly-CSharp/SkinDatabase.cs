using System;
using UnityEngine;

public class SkinDatabase : MonoBehaviour
{
	[Serializable]
	public class SkinColor
	{
		public Material material;

		public Color refColor1;

		public Color refColor2;
	}

	[Serializable]
	public class SkinMeshPack
	{
		public CharacterSkin male;

		public CharacterSkin female;

		public CharacterSkin GetSkin(Gender gender)
		{
			return null;
		}
	}

	public enum SkinID
	{
		Standard = 0
	}

	public enum Gender
	{
		Male = 0,
		Female = 1
	}

	public static SkinDatabase instance;

	public RuntimeAnimatorController lobbySkinAnimator;

	public Sprite maleSprite;

	public Sprite femaleSprite;

	[Header("Skins")]
	public SkinID defaultSkin;

	public SkinMeshPack[] allSkins;

	public SkinColor[] allColors;

	public CharacterSkin GetSkinPrefab(SkinID id, Gender gender)
	{
		return null;
	}

	public CharacterSkin GetDefaultPrefab()
	{
		return null;
	}

	public Sprite GetGenderSprite(Gender gender)
	{
		return null;
	}

	public void Init()
	{
	}
}
