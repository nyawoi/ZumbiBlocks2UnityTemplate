using System.Collections.Generic;
using UnityEngine;

public class InterestPointController : MonoBehaviour
{
	public static InterestPointController instance;

	public GameObject interestPointPrefab;

	public List<DatabaseItem.SubType> visibleLoot;

	public float pointMinScale;

	public float pointMaxScale;

	[Header("Runtime")]
	public List<InterestPoint> points;

	public Vector3 mapBottomLeft;

	public Vector3 mapTopRight;

	public bool addedSpawnPoint;

	public void Init()
	{
	}

	public void CleanUp()
	{
	}

	public void MyUpdate(MapRendering render)
	{
	}

	public void RemovePoint(Transform target)
	{
	}

	public void RemoveZombie(int id)
	{
	}

	public void RemoveByIndex(int index)
	{
	}

	public void AddLoot(DroppedLoot loot)
	{
	}

	public void AddBoss(int bossID, Zombie.Type zType, Vector3 bossLocation)
	{
	}

	public void AddPoint(InterestPoint.Type ipType, Transform target)
	{
	}

	public void AddDeathSpot(Vector3 pos)
	{
	}

	public void AddRespawnPoint(Vector3 pos)
	{
	}

	public void AddPoint(InterestPoint.Type ipType, Transform target, Vector3 pos, int bossID, int tier)
	{
	}

	private void LimitSkullPointToThree()
	{
	}

	public void UpdatedPlayerPoint(Transform target)
	{
	}

	public void UpdatePlayerPoint(InterestPoint point)
	{
	}

	public InterestPoint GetPoint(Transform target)
	{
		return null;
	}
}
