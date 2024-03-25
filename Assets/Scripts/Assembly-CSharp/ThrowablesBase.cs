using UnityEngine;

public class ThrowablesBase : MonoBehaviour
{
	public static ThrowablesBase instance;

	[Header("Base")]
	public DatabaseThrowable[] throwables;

	public void Init()
	{
	}

	public int GetThrowableSpecificID(InventoryItem.ID id)
	{
		return 0;
	}
}
