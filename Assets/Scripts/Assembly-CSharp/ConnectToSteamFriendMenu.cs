using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks;
using TMPro;
using UnityEngine;

public class ConnectToSteamFriendMenu : BaseMenu
{
	[CompilerGenerated]
	private sealed class _003CCooldownRefreshButtonCoroutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ConnectToSteamFriendMenu _003C_003E4__this;

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
		public _003CCooldownRefreshButtonCoroutine_003Ed__9(int _003C_003E1__state)
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

	[SerializeField]
	public GameObject slotPrefab;

	[SerializeField]
	public GameObject noFriendsPanel;

	[SerializeField]
	public TMP_Text noFriendsText;

	[SerializeField]
	public TMP_InputField lobbyCodeField;

	private List<GameObject> slots;

	[SerializeField]
	private IconButton refreshButton;

	public void OnEnable()
	{
	}

	public void RefreshList()
	{
	}

	private void CooldownRefreshButton()
	{
	}

	[IteratorStateMachine(typeof(_003CCooldownRefreshButtonCoroutine_003Ed__9))]
	private IEnumerator CooldownRefreshButtonCoroutine()
	{
		return null;
	}

	private void FillList()
	{
	}

	private void AddFriendToList((Friend friend, SteamId lobbyId) info)
	{
	}

	private void ClearList()
	{
	}

	public void OnJoinClicked(string playerName, SteamId lobbyId)
	{
	}

	public void JoinByCode()
	{
	}
}
