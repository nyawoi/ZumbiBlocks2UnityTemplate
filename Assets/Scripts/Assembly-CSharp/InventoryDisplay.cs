using UnityEngine;
using UnityEngine.UI;

public class InventoryDisplay : MonoBehaviour
{
	public enum ContainerType
	{
		Inventory = 0,
		Equipment = 1,
		Loot = 2
	}

	public enum SubMenu
	{
		None = 0,
		Details = 1,
		Context = 2,
		Split = 3
	}

	public static InventoryDisplay instance;

	public ItemContainerDisplay storageDisplay;

	public EquipmentDisplay equipmentDisplay;

	public InventoryItemDisplay heldItemDisplay;

	public Text debugText;

	public GameObject rotateItemTip;

	[Header("Runtime")]
	public PlayerInventory targetInventory;

	public InventoryItem heldItem;

	public bool originalRotateState;

	public bool heldItemReturnable;

	private bool canReleaseItem;

	[Header("Hover slot")]
	public bool hasHoverSlot;

	public ContainerType hoverContainer;

	public int hoverIndex;

	public IntVec2 hoverSlotPos;

	public bool canDropItemOnContainer;

	private InventoryItem hoveredItem;

	[Header("Submenus")]
	public GameObject[] subMenus;

	public ItemDescription description;

	public ItemContextMenu contextMenu;

	public SplitStackMenu splitStackMenu;

	public GameObject subMenuOutside;

	public SubMenu curSubMenu;

	[Header("Description")]
	public float descriptionTimer;

	private InventoryItem lastHoveredItem;

	public void SetSubMenu(SubMenu subMenuID, InventoryItem item)
	{
	}

	public void ResetSubMenu()
	{
	}

	public void Init()
	{
	}

	public void FindHoverSlot()
	{
	}

	private void Update()
	{
	}

	public void SetHelditem(InventoryItem item)
	{
	}

	private InventoryItem GetHoveredItem()
	{
		return null;
	}

	public void ClickedInventoryItem()
	{
	}

	public void RightClickedInventoryItem()
	{
	}

	public void UnloadContextItemAmmo(InventoryItem contextItem)
	{
	}

	public void SplitStack(InventoryItem contextItem, int extractAmount)
	{
	}

	public void ClickedOutsideOfInventory()
	{
	}

	public void ClickedOutsideSubMenu()
	{
	}

	public void DropHeldItem()
	{
	}

	public void DropContextItem(InventoryItem contextItem)
	{
	}

	public void ReturnItemToSource()
	{
	}

	private InventoryItem RemoveItemFromHoveredSlot(InventoryItem targetItem)
	{
		return null;
	}

	public void UpdateHighlights()
	{
	}

	public void Show(PlayerInventory inventory)
	{
	}
}
