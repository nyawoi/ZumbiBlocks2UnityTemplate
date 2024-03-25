using UnityEngine;

public class LootController : MonoBehaviour
{
	public static LootController instance;

	public GameObject droppedLootPrefab;

	public Material[] lootMaterial;

	public Color[] tierColor;

	public Sprite[] tierSprite;

	[Header("Loot distro")]
	public int printProbabilites;

	public int printRarity;

	[Header("Loot distro")]
	public LootDistribution lootDistro;

	[Header("Loot count settings")]
	public float lootCountMultiplier;

	[Header("Item removal")]
	public bool itemRemoveEnabled;

	public float removeTimeSeconds;

	public float removeTimer;

	[Header("Item spawning")]
	public bool itemSpawnEnabled;

	public float spawnTimeSeconds;

	public float spawnTimer;

	public LayerMask groundMask;

	[Header("LOD")]
	public float lootInteractDistance;

	public float loot3dDrawDistance;

	public float lootLightDrawDistance;

	public int curLodIndex;

	public int lodSplitCount;

	private int idPool;

	private GameObject lootHolder;

	public void Init()
	{
	}

	public void CleanUp()
	{
	}

	public Vector3 AdaptLootPositionToGround(Vector3 origin, float maxDistance = 500f)
	{
		return default(Vector3);
	}

	public void TreatClientRequest(int connectionID, int lootID)
	{
	}

	public HashCell GetLootLocation(int lootID, out int index)
	{
		index = default(int);
		return null;
	}

	public InventoryItem PullLoot(DroppedLoot droppedLoot)
	{
		return null;
	}

	public void RemoveLoot(int lootID)
	{
	}

	private void RemoveLoot(HashCell cell, int lootIndex)
	{
	}

	public InventoryItem.ID GetLootID(int tier)
	{
		return default(InventoryItem.ID);
	}

	private void PrintProbabilities(int tier)
	{
	}

	private void PrintRarity(int tier)
	{
	}

	public void GenerateHolders()
	{
	}

	public void CalculateCellLootCount(HashCell cell)
	{
	}

	public DroppedLoot GenerateSingleLootForCell(HashCell cell)
	{
		return null;
	}

	public void GenerateLootForCell(HashCell cell)
	{
	}

	public InventoryItem GetLootItem()
	{
		return null;
	}

	public DroppedLoot SpawnLootAt(Vector3 vec3, Transform holder, InventoryItem ii = null)
	{
		return null;
	}

	public DroppedLoot SpawnLootAt(Vector3 vec3, InventoryItem item, Transform holder)
	{
		return null;
	}

	public DroppedLoot SpawnLootAtClient(Vector3 vec3, int id, InventoryItem.ID itemID, int numericValue, Transform holder)
	{
		return null;
	}

	public DroppedLoot SpawnLoot(InventoryItem item, Vector3 pos)
	{
		return null;
	}

	public void Update()
	{
	}

	private HashCell PickRandomCell(bool destroyMode)
	{
		return null;
	}

	private void RemoveOldItems()
	{
	}

	private void SpawnNewItems()
	{
	}

	private void LOD()
	{
	}

	public static bool LootLootable(PlayerMain player, Vector3 lootPos, float distanceSqr)
	{
		return false;
	}
}
