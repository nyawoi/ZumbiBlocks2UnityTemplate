using TMPro;
using UnityEngine;

public class LobbyCodeDisplay : MonoBehaviour
{
	[SerializeField]
	private TMP_InputField codeField;

	[SerializeField]
	private TMP_Text copiedText;

	[SerializeField]
	private bool visible;

	private float copiedTextTimer;

	[SerializeField]
	private AnimationCurve alphaCurve;

	public void Update()
	{
	}

	public float GetAlpha(float timer)
	{
		return 0f;
	}

	public void UpdateCode()
	{
	}

	public void OnCopyClicked()
	{
	}

	public void ToggleVisible()
	{
	}
}
