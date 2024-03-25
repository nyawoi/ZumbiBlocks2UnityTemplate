using System;

[Serializable]
public struct ZombieIdentity
{
	public int id;

	public Zombie.Type type;

	public Zombie.SubClass subclass;

	public byte meshIndex;

	public byte materialIndex;

	public bool IsBoss => false;

	public ZombieIdentity(int id_, Zombie.Type zType_, Zombie.SubClass zSubclass_, byte m, byte s)
	{
		id = id_;
		type = zType_;
		subclass = zSubclass_;
		meshIndex = m;
		materialIndex = s;
	}
}
