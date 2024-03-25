using System;
using Steamworks;

[Serializable]
public class SteamP2PConnection
{
	private static int ConnectionIDGenerator;

	public bool IsAuthenticated;

	public SteamId SteamID { get; private set; }

	public int ConnectionID { get; private set; }

	private float ConnectionStartTime { get; set; }

	private float LastResponseTime { get; set; }

	public float GetConnectedTime => 0f;

	public float LastPacketDelay => 0f;

	public float LastPacketDelayMS => 0f;

	public SteamP2PConnectionStatistics statistics { get; private set; }

	public SteamP2PConnection(SteamId id)
	{
	}

	public void PacketReceived(double packetSize)
	{
	}

	public void PacketSent(double packetSize)
	{
	}
}
