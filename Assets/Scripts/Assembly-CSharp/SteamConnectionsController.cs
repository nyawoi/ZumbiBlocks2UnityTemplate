using System.Collections.Generic;
using Steamworks;
using Steamworks.Data;
using UnityEngine;

public class SteamConnectionsController : MonoBehaviour
{
	private static readonly byte[] DummyMessage;

	private const float StatisticsGenerationFrequency = 1f;

	private static int MaxPacketsPerFrame;

	private const int ServerListenChannel = 0;

	private const int ClientListenChannel = 1;

	public static SteamConnectionsController instance;

	private int ListenChannel;

	private int SendingChannel;

	private bool IsListening;

	private float statisticsTimer;

	public List<SteamP2PConnection> Connections { get; private set; }

	public SteamId ServerID { get; private set; }

	public double TotalBytesSent { get; private set; }

	public double TotalBytesReceived { get; private set; }

	public float TotalDownloadRate { get; private set; }

	public float TotalUploadRate { get; private set; }

	public void Initialize()
	{
	}

	private void SteamNetworking_OnP2PSessionRequest(SteamId id)
	{
	}

	private void SteamNetworking_OnP2PConnectionFailed(SteamId arg1, P2PSessionError arg2)
	{
	}

	private string ChannelName(int channel)
	{
		return null;
	}

	public bool IsConnectedTo(SteamId id)
	{
		return false;
	}

	public SteamP2PConnection AddConnection(SteamId id)
	{
		return null;
	}

	public void RemoveConnection(int connectionID)
	{
	}

	public void RemoveConnection(SteamP2PConnection connection)
	{
	}

	public void ClearConnections()
	{
	}

	public SteamP2PConnection GetServerConnection()
	{
		return null;
	}

	private SteamP2PConnection GetConnection(SteamId steamId)
	{
		return null;
	}

	public SteamP2PConnection GetConnection(int connectionID)
	{
		return null;
	}

	public void StartServerListening()
	{
	}

	public void StartClientListening()
	{
	}

	public void AcceptPacketsFrom(SteamId id)
	{
	}

	public void StopListening()
	{
	}

	public void AttemptServerConnection(SteamId serverID)
	{
	}

	private void SendDummyPacketTo(SteamId id)
	{
	}

	public void SendToServer(byte[] data, P2PSend p2pSend)
	{
	}

	public void SendTo(int connectionID, byte[] data, P2PSend p2pSend)
	{
	}

	private void SendTo(SteamId id, byte[] data, P2PSend p2pSend)
	{
	}

	public void Update()
	{
	}

	private void CalculateStatistics()
	{
	}

	private void ListenForPackets()
	{
	}

	private void ReadAllPackets(int targetChannel, bool dumpPackets = false)
	{
	}

	private void TreatPacket(P2Packet packet)
	{
	}

	private static void TreatPacketFromConnection(P2Packet packet, SteamP2PConnection connection)
	{
	}

	private SteamP2PConnection TreatFirstTimeReceivingPacket(SteamId senderID)
	{
		return null;
	}

	private SteamP2PConnection CreateConnectionAndSession(SteamId id)
	{
		return null;
	}

	public void PrintState()
	{
	}
}
