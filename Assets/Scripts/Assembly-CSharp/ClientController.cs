using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks;
using UnityEngine;

public class ClientController : MonoBehaviour
{
	public enum State
	{
		Off = 0,
		Connecting = 1,
		HandShaking = 2,
		Connected = 3
	}

	[CompilerGenerated]
	private sealed class _003CConnectToSteamLobbyCoroutine_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ClientController _003C_003E4__this;

		public SteamId lobbyId;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CConnectToSteamLobbyCoroutine_003Ed__39(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CConnectToSteamServerCoroutine_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ClientController _003C_003E4__this;

		public SteamId serverId;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CConnectToSteamServerCoroutine_003Ed__41(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CWaitUntilConnected_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ClientController _003C_003E4__this;

		public float timeOut;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CWaitUntilConnected_003Ed__42(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private const float ServerEntryTimeout = 5f;

	private const float DefaultConnectionTimeout = 10f;

	public const float PingTime = 0.5f;

	public static ClientController instance;

	[Header("References")]
	public SpinnerMenu spinnerMenu;

	public LobbyMenu lobbyMenu;

	public GenericPromptMenu prompt;

	private ClientSpeaker speaker;

	private ClientListener listener;

	[Header("Runtime")]
	public State state;

	public string targetPassword;

	[Header("Ping")]
	public int myPingInMS;

	public Pinger pinger;

	[Header("IDs")]
	public int myConnectionID;

	public int myLobbyID;

	private DisconnectionReason _disconnectionReason;

	private bool autoConnectToLobby;

	private SteamId autoConnectLobbyID;

	[field: SerializeField]
	public ClientMatchmaking Matchmaking { get; private set; }

	public ClientSpeaker GetSpeaker => null;

	public DisconnectionReason DisconnectionReason
	{
		get
		{
			return default(DisconnectionReason);
		}
		set
		{
		}
	}

	public void Initialize()
	{
	}

	public void Update()
	{
	}

	public void ReceivedPingResponse(int requestID)
	{
	}

	private void CheckForTimeout()
	{
	}

	public PlayerMain GetMyPlayer()
	{
		return null;
	}

	private void ResetIDs()
	{
	}

	public void SetAutoJoinLobby(SteamId lobbyId)
	{
	}

	public void OnReachedMainMenu()
	{
	}

	public void QuitServer()
	{
	}

	public void Shutdown()
	{
	}

	public void ConnectToSteamLobby(SteamId lobbyId)
	{
	}

	[IteratorStateMachine(typeof(_003CConnectToSteamLobbyCoroutine_003Ed__39))]
	private IEnumerator ConnectToSteamLobbyCoroutine(SteamId lobbyId)
	{
		return null;
	}

	public void DirectConnectToSteamServer(SteamId serverId)
	{
	}

	[IteratorStateMachine(typeof(_003CConnectToSteamServerCoroutine_003Ed__41))]
	private IEnumerator ConnectToSteamServerCoroutine(SteamId serverId)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitUntilConnected_003Ed__42))]
	private IEnumerator WaitUntilConnected(float timeOut)
	{
		return null;
	}

	private void FailedToConnectToSteamLobby()
	{
	}

	private void ReturnToJoinFriendList()
	{
	}

	public void Connect(string ip, int port, string password)
	{
	}

	private void ReturnToPlayMenu()
	{
	}

	public void OnServerEntryConfirmed(int lobbyID)
	{
	}

	internal void OnPacketReceived(byte[] data, int connectionID)
	{
	}

	public void SetLobbyID(int id)
	{
	}

	public void OnReadyChanged()
	{
	}

	private string GetDcMessage()
	{
		return null;
	}

	public void OnDisconnected()
	{
	}

	public void OnReceivedHandshake()
	{
	}

	public void RequestCell(IntVec2 coordinate)
	{
	}
}
