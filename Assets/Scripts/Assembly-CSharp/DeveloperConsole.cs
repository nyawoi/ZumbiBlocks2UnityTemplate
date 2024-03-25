using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Console;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DeveloperConsole : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CScrolldown_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DeveloperConsole _003C_003E4__this;

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
		public _003CScrolldown_003Ed__18(int _003C_003E1__state)
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

	public Color[] LogTypeColor;

	public static DeveloperConsole instance;

	public Scrollbar verticalBar;

	public TMP_Text logEntryPrefab;

	public int maxLogs;

	public TMP_Text versionText;

	public bool show;

	private List<GameObject> logEntries;

	[Header("Quick buttons panel")]
	public GameObject quickButtonsPanel;

	public GameObject quickButtonPrefab;

	public List<string> quickCommands;

	public void Init()
	{
	}

	private void FillQuickButtonsPanel()
	{
	}

	public void UpdateVersion(string v)
	{
	}

	public static void Log(string msg, LogSource source)
	{
	}

	public static void Log(string msg, LogSource source, LogMode mode, bool unityLog = false)
	{
	}

	public void LogMsg(string msg, LogSource source, LogMode mode, bool unityLog = true)
	{
	}

	private void AddEntry(string msg, LogMode mode)
	{
	}

	[IteratorStateMachine(typeof(_003CScrolldown_003Ed__18))]
	private IEnumerator Scrolldown()
	{
		return null;
	}

	private static void LogUsingUnity(LogMode t, string fullMsg)
	{
	}
}
