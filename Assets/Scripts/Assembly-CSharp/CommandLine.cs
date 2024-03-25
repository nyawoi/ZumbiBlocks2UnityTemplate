using System;
using TMPro;
using UnityEngine;

public class CommandLine : MonoBehaviour
{
	[Serializable]
	public class Command
	{
		public string cmdName;

		public string[] param;

		public bool allowedOnBuild;
	}

	public TMP_InputField input;

	public Unstuck unstuckRef;

	public Command[] allCmds;

	private string[] splitCmd;

	private int readIndex;

	public void Focus()
	{
	}

	public void OnEditEnd()
	{
	}

	public void TryRunCMD(string cmd)
	{
	}

	private string GetString()
	{
		return null;
	}

	private float GetFloat()
	{
		return 0f;
	}

	private int GetInt()
	{
		return 0;
	}

	public void help()
	{
	}

	public void settime()
	{
	}

	public void saveprogression()
	{
	}

	public void savesettings()
	{
	}

	public void dumphashlog()
	{
	}

	public void unlockallloadout()
	{
	}

	public void dumphashcontent()
	{
	}

	public void lang()
	{
	}

	public void printdownload()
	{
	}

	public void printupload()
	{
	}

	public void resetnetstats()
	{
	}

	public void langhelp()
	{
	}

	public void connect()
	{
	}

	public void connectp()
	{
	}

	public void connectwithpass()
	{
	}

	private void Connect(string ip, int port, string pass = "")
	{
	}

	public void get()
	{
	}

	public void setres()
	{
	}

	public new void name()
	{
	}

	public void fpslimit()
	{
	}

	public void cake()
	{
	}

	public void unstuck()
	{
	}

	public void steamlobby()
	{
	}

	public void steamselfconnect()
	{
	}

	public void steamconnectionstates()
	{
	}

	private void CantDoThatRightNow()
	{
	}
}
