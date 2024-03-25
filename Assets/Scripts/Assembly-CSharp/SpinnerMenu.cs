using UnityEngine;
using UnityEngine.Events;

public class SpinnerMenu : MonoBehaviour
{
	public RectTransform spinner;

	public TranslatedTMPText msgText;

	public float spinnerCoef;

	public float spinnerSpeed;

	private UnityAction currentAction;

	public void StartSpinner(UnityAction action, string message, float speed = 1f)
	{
	}

	public void ResetSpinner()
	{
	}

	public void SetSpinnerMessage(string txt)
	{
	}

	private void UpdateSpinnerTransform()
	{
	}

	private void Update()
	{
	}
}
