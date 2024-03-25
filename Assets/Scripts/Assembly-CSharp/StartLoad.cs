using UnityEngine;

public class StartLoad : MonoBehaviour
{
	public RectTransform loadingMask;

	public RectTransform loadingMaskRef;

	[Header("Runtime")]
	public float loadingAmount;

	public float loadingDisplay;

	public bool loaded;

	private AsyncOperation loadOperation;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
