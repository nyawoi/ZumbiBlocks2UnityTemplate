using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Steamworks;
using Steamworks.Data;
using UnityEngine;

public class ServerMatchmaking : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStartLobbyAsync_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ServerMatchmaking _003C_003E4__this;

		public int maxPlayers;

		public Action failureCallback;

		private Task<Lobby?> _003ClobbyTask_003E5__2;

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
		public _003CStartLobbyAsync_003Ed__10(int _003C_003E1__state)
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

	public Lobby CurrentLobby { get; private set; }

	public bool LobbyLaunched { get; private set; }

	public void StartSteamLobby(int maxPlayers, Action failureCallback)
	{
	}

	private void SteamMatchmaking_OnLobbyMemberJoined(Lobby lobby, Friend joined)
	{
	}

	[IteratorStateMachine(typeof(_003CStartLobbyAsync_003Ed__10))]
	private IEnumerator StartLobbyAsync(int maxPlayers, Action failureCallback)
	{
		return null;
	}

	public void EndLobby()
	{
	}

	public static void PrintLobbyInfo(Lobby lobby)
	{
	}
}
