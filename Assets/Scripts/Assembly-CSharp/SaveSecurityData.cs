using System;

[Serializable]
public class SaveSecurityData
{
	public int saveVersion;

	public byte[] saveHash;

	public SaveSecurityData(int version)
	{
	}
}
