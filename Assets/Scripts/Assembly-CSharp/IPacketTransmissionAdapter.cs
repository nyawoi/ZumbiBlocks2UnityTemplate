public interface IPacketTransmissionAdapter
{
	void SendToServer(byte[] data, ServerController.PacketReliability reliability);

	void SendToConnection(int connectionID, byte[] data, ServerController.PacketReliability reliability);
}
