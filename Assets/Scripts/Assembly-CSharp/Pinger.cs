using System.Collections.Generic;
using UnityEngine;

public class Pinger : MonoBehaviour
{
	private struct PingRequest
	{
		public int id;

		public double requestTime;
	}

	private const int requestLimit = 50;

	public ClientController client;

	private float timer;

	private int requestIDGenerator;

	private List<PingRequest> requests;

	public void UpdatePing()
	{
	}

	private void RequestPing()
	{
	}

	internal void ReceivedPingResponse(int requestID)
	{
	}

	public void Cleanup()
	{
	}
}
