public interface DamageTarget
{
	void TakeDamage(Damage dmg);

	bool SpawnFXLocally();

	FXProp.ID GetFXProp(Damage dmg);
}
