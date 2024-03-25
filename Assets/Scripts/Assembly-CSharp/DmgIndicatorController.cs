using System.Collections.Generic;
using UnityEngine;

public class DmgIndicatorController : MonoBehaviour
{
	public GameObject prefab;

	public List<DmgIndicator> indicators;

	public AnimationCurve alphaCurve;

	public AnimationCurve scaleCurve;

	public float fadeSpeed;

	public void UpdateDisplay()
	{
	}

	private void Clear()
	{
	}

	public void AddDmgIndicator(float angle)
	{
	}
}
