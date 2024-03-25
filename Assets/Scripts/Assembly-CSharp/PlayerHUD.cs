using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour
{
	public static PlayerHUD instance;

	public PlayerMain targetPlayer;

	[Header("Extra")]
	public TMP_Text centerText;

	[Header("Refs")]
	public EntityUIIconController entityIcons;

	public InteractionHUD interactionHUD;

	public EquipmentHUD equipHUD;

	public StatusEffectHUD statusEffect;

	public TutorialController tutorial;

	public DifficultyHUD dificulltyHUD;

	public BossNameDisplay bossName;

	public BossHealthBar bossHealth;

	public DmgIndicatorController dmgIndicators;

	[Header("Bars")]
	public PlayerBarHUD hpBar;

	public PlayerBarHUD staminaBar;

	[Header("Crosshair")]
	public float minResolutionToScaleCrosshair;

	public float crossHairAlpha;

	public RectTransform crossHairTransform;

	public RectTransform innerCrossHairTransform;

	public RawImage[] crossHairLine;

	public RectTransform innerHitmarkerTransform;

	public RawImage[] hitMarkerLine;

	public float hitMarker;

	public void Init()
	{
	}

	public void HitMarker()
	{
	}

	public void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void SetCrosshairAlpha(float f)
	{
	}

	private void UpdateCrosshair()
	{
	}

	private void UpdateCrosshairScaleInLowResolution()
	{
	}

	private void UpdateCrosshairSizeBasedOnAccuracy()
	{
	}

	private void UpdateHitmarkerDisplay()
	{
	}

	private void UpdateCrosshairAlpha()
	{
	}

	private void UpdatePlayerBars()
	{
	}

	public void UpdateInteractionHUD()
	{
	}

	public void UpdateStatusEffect()
	{
	}

	private void UpdateCenterText()
	{
	}

	public void UpdateEquipment()
	{
	}
}
