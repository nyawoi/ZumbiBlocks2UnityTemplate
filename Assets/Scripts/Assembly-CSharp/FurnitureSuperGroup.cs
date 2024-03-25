using System;
using System.Collections.Generic;

[Serializable]
public class FurnitureSuperGroup
{
	public Furniture.SuperGroup id;

	public Furniture.Group[] groups;

	public List<Furniture.ID> furnitureID;
}
