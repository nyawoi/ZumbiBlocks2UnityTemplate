using System.Collections.Generic;

public class PolygonDataBuffers
{
	public class BuildingBuffers
	{
		public Buffer baseBuildingBuffer;

		public Buffer yardFurnitureBuffer;

		public List<BuildingFloorBuffer> floorBuffers;
	}

	public class BuildingFloorBuffer
	{
		public Buffer gridBuffer;

		public Buffer doorsAndWindowsBuffer;

		public Buffer furnitureBuffer;

		public Buffer roomsBuffer;
	}

	public Buffer polyTrisBuffer;

	public Buffer vegetationBuffer;

	public Buffer fencingBuffer;

	public BuildingBuffers buildingBuffers;

	public int totalBytes;

	public PolygonDataBuffers(Polygon polygon)
	{
	}

	private void GenerateFencingBuffer(Polygon polygon)
	{
	}

	private void GeneratedVegetationBuffer(Polygon polygon)
	{
	}

	private void GenerateBakedTrianglesBuffer(Polygon polygon)
	{
	}

	private void GenerateBuildingBuffer(Polygon polygon)
	{
	}

	private void GenerateYardFurnitureBuffer(BuildingBlueprint building)
	{
	}

	private void GenerateBaseBuildingBuffer(Polygon.ContentType contentType, BuildingBlueprint building)
	{
	}

	private BuildingFloorBuffer GenerateFloorBufferFor(int floorIndex, BuildingBlueprint building)
	{
		return null;
	}

	private void GenerateFloorGridBuffer(BuildingFloorBuffer floorBuffer, int floorIndex, BuildingBlueprint building)
	{
	}

	private void GenerateDoorsAndWindowsBuffer(BuildingFloorBuffer floorBuffer, int floorIndex, BuildingBlueprint.Floor floor)
	{
	}

	private void GenerateFurnitureBuffer(BuildingFloorBuffer floorBuffer, int floorIndex, BuildingBlueprint.Floor floor)
	{
	}

	private void GenerateRoomsBuffer(BuildingFloorBuffer floorBuffer, int floorIndex, BuildingBlueprint.Floor floor)
	{
	}
}
