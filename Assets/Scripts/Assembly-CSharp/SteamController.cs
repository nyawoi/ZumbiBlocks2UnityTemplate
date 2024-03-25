using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks;
using Steamworks.Data;
using UnityEngine;

public class SteamController : MonoBehaviour
{
	private enum RelayAccessState
	{
		None = 0,
		Attempting = 1,
		Granted = 2
	}

	[CompilerGenerated]
	private sealed class _003CWaitForAccess_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SteamController _003C_003E4__this;

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
		public _003CWaitForAccess_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CEnsureRelayAccessCoroutine_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SteamController _003C_003E4__this;

		public Action<string> failureCallback;

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
		public _003CEnsureRelayAccessCoroutine_003Ed__38(int _003C_003E1__state)
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

	public static SteamController instance;

	[Header("Steam Config")]
	[SerializeField]
	public bool useSteam;

	public bool useSpaceWars;

	[SerializeField]
	private bool fullNetworkDebug;

	[Header("References")]
	[SerializeField]
	private SteamProfilePicture profilePictures;

	[SerializeField]
	private uint zumbiBlocks2ID;

	[SerializeField]
	private uint spaceWarsID;

	private uint AppID => 0u;

	public bool Functional { get; private set; }

	[field: Header("Runtime")]
	[field: SerializeField]
	public string MySteamName { get; private set; }

	public SteamId MySteamID { get; private set; }

	private RelayAccessState RelayAccess { get; set; }

	public bool HaveRelayAccess => false;

	public bool LookingForRelayAccess => false;

	private SteamNetworkingAvailability SuccessAvailability => default(SteamNetworkingAvailability);

	public void Initialize()
	{
	}

	private void InitializeSteamClient()
	{
	}

	public void HandleConnectToLobbyCommandArgument(string lobbyIdParam)
	{
	}

	private void DebugOutput(NetDebugOutput output, string message)
	{
	}

	public void EnsureRelayAccess()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForAccess_003Ed__37))]
	private IEnumerator WaitForAccess()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CEnsureRelayAccessCoroutine_003Ed__38))]
	public IEnumerator EnsureRelayAccessCoroutine(Action<string> failureCallback)
	{
		return null;
	}

	public IEnumerable<(Friend, SteamId)> GetFriendsLobbies()
	{
		return null;
	}

	private void AddMyOwnLobbyTo(List<(Friend, SteamId)> friendsLobbies)
	{
	}

	private void AddFriendLobbyTo(List<(Friend, SteamId)> friendsLobbies, Friend friend)
	{
	}

	public void Shutdown()
	{
	}

	public void Update()
	{
	}

	public void LogLobbyInfo()
	{
	}

	private void LogLobbyInfo(Lobby lobby)
	{
	}
}
