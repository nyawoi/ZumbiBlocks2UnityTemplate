using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Steamworks;
using Steamworks.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JoinSteamFriendSlot : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGetImage_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Friend friend;

		public JoinSteamFriendSlot _003C_003E4__this;

		private Task<Steamworks.Data.Image?> _003Ctask_003E5__2;

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
		public _003CGetImage_003Ed__8(int _003C_003E1__state)
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
	private RawImage picture;

	[SerializeField]
	private TMP_Text nameText;

	[SerializeField]
	private IconButton joinButton;

	[SerializeField]
	private ConnectToSteamFriendMenu connectMenu;

	private SteamId targetLobbyId;

	public void Display(Friend friend, SteamId lobbyId)
	{
	}

	private string ClampName(string text, int size)
	{
		return null;
	}

	public void OnJoinClicked()
	{
	}

	[IteratorStateMachine(typeof(_003CGetImage_003Ed__8))]
	private IEnumerator GetImage(Friend friend)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
