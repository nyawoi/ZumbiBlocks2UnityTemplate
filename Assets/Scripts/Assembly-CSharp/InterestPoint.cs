using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InterestPoint : MonoBehaviour
{
	public enum Type
	{
		Player = 0,
		Loot = 1,
		Boss = 2,
		DeathSpot = 3,
		SpawnPoint = 4
	}

	[Header("Refs")]
	public RectTransform myTransform;

	public TMP_Text text;

	public Image imgArrow;

	public Image imgBall;

	public Image imgSkull;

	public Image imgHouse;

	public RectTransform imgTransform;

	[Header("Runtime")]
	public Type type;

	public Transform objTransform;

	public int bossID;

	public Vector3 pos3D;

	public Vector2 posMap;
}
