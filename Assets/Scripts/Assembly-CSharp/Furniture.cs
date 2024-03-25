using UnityEngine;

public class Furniture : MonoBehaviour
{
	public class YardDecor
	{
		public ID id;

		public Vector2 pos;

		public float angle;

		public YardDecor(ID id_, Vector2 pos_, float rot)
		{
			id = id_;
			pos = pos_;
			angle = rot;
		}
	}

	public struct WallInstance
	{
		public ID furniID;

		public IntVec2Couple couple;

		public WallInstance(ID id, IntVec2Couple c)
		{
			furniID = id;
			couple = c;
		}
	}

	public class Instance
	{
		public ID id;

		public IntVec2 pos;

		public byte rotation;

		public Instance(ID id_, IntVec2 pos_, byte rot)
		{
			id = id_;
			pos = pos_;
			rotation = rot;
		}
	}

	public enum ID : byte
	{
		WoodenDoor = 0,
		WoodenWindow = 1,
		DoorStair = 2,
		AvgCloset = 3,
		BigFan = 4,
		BoxBedSingle = 5,
		Broom = 6,
		TowelBrown = 7,
		Clock1 = 8,
		DeadGuyInTheFloor = 9,
		DeadGuySitting = 10,
		DecorTable1 = 11,
		Extinguisher = 12,
		Fridge2 = 13,
		Garbage1 = 14,
		Jesus = 15,
		KitchenSink2 = 16,
		LightBox = 17,
		Microwave1 = 18,
		MidToilet = 19,
		PCDesk2 = 20,
		BathSink1 = 21,
		Shower1 = 22,
		Sofa2Blue = 23,
		Stove2 = 24,
		TableForTwo = 25,
		TPaintingCity = 26,
		TPaintingChicken = 27,
		TPaintingNazi = 28,
		TPaintingTank = 29,
		TvRack2Big = 30,
		WallLight2 = 31,
		WPaintingFields = 32,
		WPaintingKitchen = 33,
		BoxBedCouple = 34,
		BedsideTable = 35,
		Bucket = 36,
		DogFood = 37,
		WaltoneBoat = 38,
		Bathtub = 39,
		ToiletPaperPile = 40,
		Urinal = 41,
		GoodAir = 42,
		PoliceMainDoor = 43,
		EbonyDoor = 44,
		PoliceWindow = 45,
		CellWindow = 46,
		CellDoor = 47,
		MainStair = 48,
		PrisonBed = 49,
		DetentionBench = 50,
		MugBanner = 51,
		TallSingleLocker = 52,
		DetentionDesk = 53,
		ReceptionBenchCops = 54,
		ReceptionDeskPD = 55,
		DetectiveDesk1 = 56,
		DrinkFountain1 = 57,
		DetectiveDesk2 = 58,
		FileCabinet = 59,
		LawDiploma = 60,
		SimpleChair1 = 61,
		HatStand = 62,
		WhiteBoard = 63,
		FramedMap = 64,
		BoxShelves = 65,
		BoxShelves2 = 66,
		GunLocker = 67,
		GunLocker2 = 68,
		GunRack = 69,
		TroughUrinal = 70,
		DoublePublicSink = 71,
		PoliceSign = 72,
		CountryFlag = 73,
		IslandFlag = 74,
		PoliceFlag = 75,
		ParkingSpot = 76,
		Staircase = 77,
		FactorySign = 78,
		ToolWall = 79,
		OrangeLadder = 80,
		FactoryShelves = 81,
		PalletShelves = 82,
		BigCrate = 83,
		PaintPallet = 84,
		BeamPile = 85,
		CNCMachine = 86,
		Anvil = 87,
		GatePile = 88,
		MetalSheetRoller = 89,
		HeavyLocker = 90,
		AirCompressor = 91,
		BasicCrate = 92,
		BrickCrate = 93,
		ScrapCrate = 94,
		FactoryStorageShelves = 95,
		BlueWaterBarrel = 96,
		BlackWaterBarrel = 97,
		RustyBarrel = 98,
		FactoryWoodCloset = 99,
		FactoryMiscPile = 100,
		COUNT = 101
	}

	public enum Group
	{
		Misc = 0,
		Bed = 1,
		Closet = 2,
		PC = 3,
		Toilet = 4,
		BathSink = 5,
		Shower = 6,
		Towel = 7,
		Fridge = 8,
		KitchenSink = 9,
		Stove = 10,
		KitchenTable = 11,
		Microwave = 12,
		Sofa = 13,
		TVRack = 14,
		DecorTable = 15,
		Painting = 16,
		Body = 17,
		SpecialGroup = 18,
		GeneralResidenceDecor = 19,
		Garbage = 20,
		CorridorDecor = 21,
		Bathtub = 22,
		ToiletDecor = 23,
		MainDoor = 24,
		CNCRoom = 25,
		Metalworks = 26,
		FactoryStorage = 27,
		Barrels = 28,
		COUNT = 29
	}

	public enum SuperGroup
	{
		GeneralResidenceDecor = 0,
		GeneralToiletDecor = 1,
		COUNT = 2
	}

	public enum Interaction
	{
		None = 0,
		Door = 1
	}

	public LODTarget lodTarget;

	public ID id;

	public Group group;

	[Header("Sizing")]
	public IntVec2 size;

	public bool occupyLow;

	public bool occupyHigh;

	public bool touchesWall;

	[Header("Interaction Settings")]
	public bool hasInteraction;

	public bool destroyable;

	public InteractableObject.ID interactionID;
}
