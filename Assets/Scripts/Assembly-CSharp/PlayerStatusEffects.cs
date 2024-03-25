using UnityEngine;

public class PlayerStatusEffects : MonoBehaviour
{
	public PlayerMain targetPlayer;

	public StatusEffect[] statusEffect;

	[Header("Food settings")]
	public float foodDecayRate;

	public float foodUsageBaseSpeed;

	public float foodUsageExtraSpeed;

	public float foodUsageEffectMultiplier;

	[Header("Drink settings")]
	public float drinkBaseUsage;

	public float drinkExtraUsage;

	public float drinkEffectMultiplier;

	[Header("Med settings")]
	public float medsDecayRate;

	public float medsUsageBaseSpeed;

	public float medsUsageExtraSpeed;

	public float medsUsageBaseEffect;

	public bool HasToxic => false;

	public float GetStaminaDrainMutliplier(StaminaDrainEffect staminaDrainEffect)
	{
		return 0f;
	}

	public void AddEffect(StatusEffect.ID statusID, float amount, float tier)
	{
	}

	public void MyUpdate()
	{
	}

	private void ProcessFood()
	{
	}

	private void ProcessHealingThroughFood(StatusEffect foodSE)
	{
	}

	private void ProcessDrink()
	{
	}

	private void ProcessStaminaRecoveryWithDrink(StatusEffect drinkEffect)
	{
	}

	private void ProcessMeds()
	{
	}

	private void ProcessToxic()
	{
	}

	private float EffectConsumption(StatusEffect effect, float usageSpeed, float maxComsumption)
	{
		return 0f;
	}
}
