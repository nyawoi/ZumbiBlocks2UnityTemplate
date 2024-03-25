using UnityEngine;

public class DebugController : MonoBehaviour
{
	public static bool DebugEnabled => false;

	public static bool GetDebugKeyDown(KeyCode code)
	{
		return false;
	}

	public static bool GetDebugKey(KeyCode code)
	{
		return false;
	}
}
