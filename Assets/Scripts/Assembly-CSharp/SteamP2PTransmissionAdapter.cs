using Steamworks;

public class SteamP2PTransmissionAdapter : IPacketTransmissionAdapter
{
	private P2PSend ToP2PSend(ServerController.PacketReliability reliability)
	{
		return default(P2PSend);
	}

	public void SendToServer(byte[] data, ServerController.PacketReliability reliability)
	{
	}

	public void SendToConnection(int connectionID, byte[] data, ServerController.PacketReliability reliability)
	{
	}
}
