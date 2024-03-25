using System.Collections.Generic;
using UnityEngine;

public class EntityUIIconController : MonoBehaviour
{
	[Header("Settings")]
	public GameObject playerMarkerPrefab;

	[Header("Runtime")]
	public List<PlayerMarkerView> playerMarkers;

	public void UpdateDisplay()
	{
	}
}
