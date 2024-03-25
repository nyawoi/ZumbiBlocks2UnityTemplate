using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Steamworks;
using Steamworks.Data;
using UnityEngine;

public class ClientMatchmaking : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CConnectToLobbyAsync_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SteamId lobbyId;

		public Action failureCallback;

		public ClientMatchmaking _003C_003E4__this;

		private Task<Lobby?> _003CjoinLobbyTask_003E5__2;

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
		public _003CConnectToLobbyAsync_003Ed__15(int _003C_003E1__state)
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

	public Lobby ConnectedLobby { get; private set; }

	public ulong LobbyOwnerID => 0uL;

	public bool IsConnected { get; private set; }

	public bool CanJoinLobby => false;

	public void Initialize()
	{
	}

	private void SteamFriends_OnGameLobbyJoinRequested(Lobby lobby, SteamId steamID)
	{
	}

	public void ConnectToLobby(SteamId lobbyId, Action failureCallback)
	{
	}

	[IteratorStateMachine(typeof(_003CConnectToLobbyAsync_003Ed__15))]
	private IEnumerator ConnectToLobbyAsync(SteamId lobbyId, Action failureCallback)
	{
		return null;
	}

	public void LeaveLobby()
	{
	}
}
