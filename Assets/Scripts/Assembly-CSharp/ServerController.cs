using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ServerController : MonoBehaviour
{
	public enum State
	{
		Off = 0,
		Starting = 1,
		Started = 2
	}

	public enum Mode
	{
		Multiplayer = 0,
		Singleplayer = 1
	}

	public enum PacketReliability
	{
		Reliable = 0,
		ReliableSequenced = 1,
		Unreliable = 2
	}

	[CompilerGenerated]
	private sealed class _003CStartLobbyCoroutine_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ServerController _003C_003E4__this;

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
		public _003CStartLobbyCoroutine_003Ed__33(int _003C_003E1__state)
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

	private float AuthenticationTimeOut;

	private float DefaultConnectionTimeout;

	public static ServerController instance;

	[Header("References")]
	public LobbyMenu lobbyMenu;

	public SpinnerMenu spinnerMenu;

	public LobbyController lobby;

	public GenericPromptMenu prompt;

	private ServerListener listener;

	private ServerSpeaker speaker;

	[Header("Settings")]
	public const int MessageBufferSize = 1024;

	public const int DefaultPlayerCount = 6;

	[Header("Runtime")]
	public State state;

	public Mode mode;

	public ServerSpeaker GetSpeaker => null;

	[field: SerializeField]
	public ServerMatchmaking Matchmaking { get; private set; }

	public bool IsMultiplayer => false;

	public void Initialize()
	{
	}

	public void LaunchMatch()
	{
	}

	private void Update()
	{
	}

	private void VerifyNormalTimeout()
	{
	}

	private void VerifyUnauthenticatedConnectionsTimeout()
	{
	}

	private void KickPlayer(int connectionID, DisconnectionReason kickReason)
	{
	}

	public void TryStartServer()
	{
	}

	public void StartSinglePlayer()
	{
	}

	public void BackToServerCreation()
	{
	}

	[IteratorStateMachine(typeof(_003CStartLobbyCoroutine_003Ed__33))]
	public IEnumerator StartLobbyCoroutine()
	{
		return null;
	}

	private void FailedToStartServer(string errorMessageTag)
	{
	}

	private void FailedToStartSteamLobby()
	{
	}

	public void InitSinglePlayerStep()
	{
	}

	private void JoinOwnLobby()
	{
	}

	private void OnSuccessfullyStartedServer()
	{
	}

	public void CloseServer()
	{
	}

	private void Shutdown()
	{
	}

	private void KickEveryone(DisconnectionReason disconnectionMessage)
	{
	}

	public void OnPlayerEntryMidgame(int lobbyID)
	{
	}

	internal void OnPacketReceived(byte[] data, int connectionID)
	{
	}

	public void PlayerEntrySync(LobbyPlayer player)
	{
	}

	public void OnConnectionLost(SteamP2PConnection steamConnection)
	{
	}

	public void OnReceivedHandshake(int connectionID)
	{
	}

	public void OnClientAuthAttempt(string ver, string cname, int connectionID)
	{
	}

	private void ClientWasAuthenticated(string playerName, int connectionID)
	{
	}
}
